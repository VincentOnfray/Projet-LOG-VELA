using System;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using MySql.Data.MySqlClient;


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
            user_list.getInstance().updateUsrList(usrsJsonArray);
            
        }

        public async void deleteUser(int id)
        {
            var usrs = await client.DeleteAsync("http://localhost:8080/user/DeleteUser/"+id.ToString());
            var usrsJson = await usrs.Content.ReadAsStringAsync();
            Console.WriteLine(usrsJson);
        }

        public Boolean checkCredentials(string login, string pw)
        {
            //TODO: an actual login check
            if(login.Length>5 && pw.Length > 5)return true;
            return false;
        }

        


    }
}
