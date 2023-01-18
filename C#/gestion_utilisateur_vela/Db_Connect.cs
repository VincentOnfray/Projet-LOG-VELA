using System;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using MySql.Data.MySqlClient;


namespace gestion_utilisateur_vela
{
   

    class Db_Connect
    {
        private static Db_Connect Instance;
        static HttpClient client = new HttpClient();
        public static Db_Connect getInstance() {
            if (Instance == null) {
                Instance = new Db_Connect(); 
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
            var usrs = await client.GetAsync("http://localhost:8080/user/DeleteUser/"+(id.ToString()));
        }

        public Boolean checkCredentials(string login, string pw)
        {
            return true;
        }

        


    }
}
