using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;



namespace gestion_utilisateur_vela
{
    public partial class UsersListForm : Form
    {
        
            private static UsersListForm Instance;

        public List<User> usrList;

            private dynamic jsonUsrArray;

            private int currSelectedUsrID = -1;
            
            public static UsersListForm getInstance()
            {

                return Instance;
            }

          

        public void updateUsrList(dynamic array)
        {
            usrList = new List<User>();
            foreach (dynamic usr in array)
            {
                //Console.WriteLine(JsonConvert.SerializeObject( array));
                //Get data
                usrList.Add(new User() { idUser = usr["idUser"], name = usr["name"],firstname =  usr["firstname"], email = usr["email"], password = usr["password"], idRole = usr["idRole"], idUser_Parrainer = usr["idUser_parrainer"] }) ;
            }
            
            var usrViewItems = new ListViewItem[array.Count];
            int i = 0;
            //Add them in list
            foreach (User u in usrList)
            { 
                var currItem = new ListViewItem(u.idUser);
                currItem.SubItems.Add(u.name);
                currItem.SubItems.Add(u.firstname);
                currItem.SubItems.Add(u.email);
                currItem.SubItems.Add(u.idRole);
                currItem.SubItems.Add(u.idUser_Parrainer);
                usrViewItems[i]=(currItem);
                i++;




            }
            ListView.Items.AddRange(usrViewItems);
        }

        public UsersListForm() {
            Instance = this;
            InitializeComponent();
            //Console.WriteLine("Hello");
            
            refreshList();
        }

        private void refreshList()
        {
            ListView.Items.Clear();
            Api_Manager db = Api_Manager.getInstance();
            db.getUsers();
        }

       

      


        private void ListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (ListView.SelectedItems.Count == 1)
            {
                
                currSelectedUsrID = Int32.Parse(ListView.SelectedItems[0].Text);
            }
            else currSelectedUsrID = -1;
            
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (currSelectedUsrID !=-1) //An actual ID is selected
            {
                Api_Manager.getInstance().deleteUser(currSelectedUsrID);
                string json = "";
                foreach (User u in usrList)
                {
                    if (Int32.Parse(u.idUser) == currSelectedUsrID)
                    {

                        json = u.AsJson();
                    }
                }

                MongoApiConnector.getInstance().Log("Deleted user: "+json);
                refreshList();
            }
        }

        private void Btn_edit_Click_1(object sender, EventArgs e)
        {

            if (currSelectedUsrID == -1) return;
            //Get selected ID
            var id = currSelectedUsrID;
            User selectedUsr = null;
            //Get Selected USER object
            foreach (User u in usrList)
            {
                if (Int32.Parse(u.idUser) == id)
                {
                    selectedUsr = u;
                    Console.WriteLine(u.AsJson());
                }
            }

            if (selectedUsr == null) return;
            //Create edit page and give it User
            SingleUserForm f = new SingleUserForm(SingleUserFormMode.edit,selectedUsr);
            f.Show();
        }

        private void Btn_Create_Click(object sender, EventArgs e)
        {
            //Create edit page and give it blank User
            SingleUserForm f = new SingleUserForm(SingleUserFormMode.create, null);
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            refreshList();
        }
    }
}
