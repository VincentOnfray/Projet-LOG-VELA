using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace gestion_utilisateur_vela
{
   

    class Db_Connect
    {
        private static Db_Connect Instance;

        public static Db_Connect getInstance() {
            if (Instance == null) {
                Instance = new Db_Connect(); 
            }

            return Instance;
        }


        private string Connstring = @"server=localhost;userid=root;password=vela;database=vela_db;port=3305";

        

        public MySqlDataReader getUsers() {

            MySqlDataReader mdr = execSql("SELECT * FROM user");
            while (mdr.Read())
            {
                Console.WriteLine(mdr.GetString(0));
            }
            return mdr;
        }

        public Boolean checkCredentials(string login, string pw)
        {
            return true;
        }

        private MySqlDataReader execSql(string sql)
        {
            MySqlConnection conn = new MySqlConnection(Connstring);
            conn.Open();
            MySqlCommand sqlcmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = sqlcmd.ExecuteReader();
            return reader;
        }


    }
}
