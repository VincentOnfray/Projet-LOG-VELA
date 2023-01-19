using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_utilisateur_vela
{
    public class User
    {

        public string idUser { get; set; }
        public string name { get; set; }

        public string firstname { get; set; }

        public string password { get; set; }
        public string idRole { get; set; }
        public string email { get; set; }

        public string idUser_Parrainer { get; set; }

        public string AsJson()
        {
             var json = JsonConvert.SerializeObject(this);
            Console.WriteLine(json);
            return json;
        }
    }

}
