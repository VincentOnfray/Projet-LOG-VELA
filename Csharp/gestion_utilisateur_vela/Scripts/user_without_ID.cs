
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_utilisateur_vela.Scripts
{
    class user_without_ID
    {
        public user_without_ID(User u)
        {
            name = u.name;
            firstname = u.firstname;
            password = u.password;
            idRole = u.idRole;
            email = u.email;
            idUser_Parrainer = u.idUser_Parrainer;

        }


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
