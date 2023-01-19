using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_utilisateur_vela
{
    class Login_manager
    {
        private static Login_manager Instance;
        
        public static Login_manager getInstance()
        {
            if (Instance == null)
            {
                Instance = new Login_manager();
            }

            return Instance;
        }



        public Boolean checkCredentials(string mail, string pw )
        {
            return Api_Manager.getInstance().checkCredentials(mail, pw);
            
        }
    }
}
