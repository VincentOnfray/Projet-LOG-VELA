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
    public partial class SingleUserForm : Form
    {

        public SingleUserFormMode mode;
        public User currentUsr;
        public SingleUserForm(SingleUserFormMode sufm, User u)
        {
            mode = sufm;
            currentUsr = u;
            
            //Console.WriteLine(u.AsJson());
            InitializeComponent();

            if (mode == SingleUserFormMode.edit)
            {
                Txt_pw.Visible = false;
                Lbl_pw.Visible = false;
            }
            if (currentUsr != null) 
            {
                loadUsrData();

            }
            else
            {
                currentUsr = new User();
            }
            
            
            
        }

        private void loadUsrData()
        {
            Txt_Email.Text = currentUsr.email;
            Txt_Firstname.Text = currentUsr.firstname;
            Txt_Name.Text = currentUsr.name;
            Txt_Id.Text = currentUsr.idUser;
        }

        private void getUiInputData()
        {

            currentUsr.email = Txt_Email.Text ;
            currentUsr.firstname = Txt_Firstname.Text;
            currentUsr.name = Txt_Name.Text;
            currentUsr.idRole = "1";
            currentUsr.idUser_Parrainer = "0";

            if (mode == SingleUserFormMode.create) currentUsr.password = Txt_pw.Text;
            
            
        }
       

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            //Gather User info
            getUiInputData();
            string usrJson = currentUsr.AsJson();
            switch (mode)
            {
                case SingleUserFormMode.create:
                    Api_Manager.getInstance().CreateUser(usrJson);
                    break;
                case SingleUserFormMode.edit:
                    Api_Manager.getInstance().UpdateUser(usrJson, currentUsr.idUser);
                    break;
            }


            this.Close();
                
        }

        private void SingleUserForm_Load(object sender, EventArgs e)
        {

        }
    }

    public enum SingleUserFormMode { 
    create,edit
    }
}
