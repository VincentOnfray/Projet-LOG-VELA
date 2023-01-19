using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_utilisateur_vela
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            MongoApiConnector.getInstance().Log("User Management App Oppened");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private Boolean isLoginValid(string login, string pw)
        {
            if (login == "root" && pw == "root") {
                //TODO: check DB credentials
                return true;
            }
            return false;    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MongoApiConnector.getInstance().Log((txbx_username.Text+" Successfuly Logged In Usr Mng App"));
            if (Login_manager.getInstance().checkCredentials(txbx_username.Text, txbx_password.Text)){ 
                //Load next form
                UsersListForm f = new UsersListForm(); 
                f.Show();
                this.Hide();
            } else
            {
                Invalid_Label.Visible = true;

            }
        }

        private void txbx_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbx_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
