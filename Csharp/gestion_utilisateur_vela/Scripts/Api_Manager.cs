using System;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using MySql.Data.MySqlClient;
using System.Net.Http;
using System.Net.Http.Json;
using Newtonsoft.Json.Linq;
using gestion_utilisateur_vela.Scripts;

namespace gestion_utilisateur_vela
{
   

    class Api_Manager
    {
        private static Api_Manager Instance;
        static HttpClient client = new HttpClient();
        public static Api_Manager getInstance() {
            if (Instance == null) {
                Instance = new Api_Manager(); 
            }

            return Instance;
        }


        //private string Connstring = @"server=localhost;userid=root;password=vela;database=vela_db;port=3305";

        

        public async void getUsers() {
            var usrs = await client.GetAsync("http://localhost:8080/user/AllUsers");
            var usrsJson = await usrs.Content.ReadAsStringAsync();
            dynamic usrsJsonArray = JsonConvert.DeserializeObject(usrsJson);
            UsersListForm.getInstance().updateUsrList(usrsJsonArray);
            MongoApiConnector.getInstance().Log("Fetched Users List");

        }

        public async void deleteUser(int id)
        {
            var del = await client.DeleteAsync("http://localhost:8080/user/DeleteUser/"+id.ToString());
            var usrsJson = await del.Content.ReadAsStringAsync();
            Console.WriteLine(usrsJson);
            
        }

        public Boolean checkCredentials(string login, string pw)
        {
            //TODO: an actual login check
            if(login.Length>5 && pw.Length > 5)return true;
            return false;
            MongoApiConnector.getInstance().Log("Credentials Validated");

        }

        public async void UpdateUser(string jsonUsr, string id)
        {
            //Console.WriteLine(jsonUsr);
            var user = new user_without_ID(JsonConvert.DeserializeObject<User>(jsonUsr));
            var jsonCont = JsonContent.Create(user);

            var usr = await client.PutAsync("http://localhost:8080/user/UpdateUser/" + id.ToString(),jsonCont);
            var answer = await usr.Content.ReadAsStringAsync();
            MongoApiConnector.getInstance().Log("Updated usr: "+jsonUsr);
            Console.WriteLine("UPDATE ANSWER: "+answer);
        }

        public async void CreateUser(string jsonUsr)
        {
            
            var jsonCont = JsonContent.Create(JsonConvert.DeserializeObject<User>(jsonUsr));
            var usr = await client.PostAsync("http://localhost:8080/user/AddUser",jsonCont);
            var answer = await usr.Content.ReadAsStringAsync();

            MongoApiConnector.getInstance().Log("CreatedUsr: " +jsonUsr);

            Console.WriteLine("ANSWER: " + answer);
        }
    }

        


}
