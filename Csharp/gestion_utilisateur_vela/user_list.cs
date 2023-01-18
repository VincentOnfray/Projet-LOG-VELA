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
    public partial class user_list : Form
    {
        
            private static user_list Instance;

            private dynamic jsonUsrArray;

            private int currentSelectedID = -1;
            
            public static user_list getInstance()
            {

                return Instance;
            }

            public class User
        {

            public string ID { get; set; }
            public string name { get; set; }

            public string firstname { get; set; }

            public string password { get; set; }
            public string idRole { get; set; }
            public string email { get; set; }

            public string idUserParrainer { get; set; }
        }


        public void updateUsrList(dynamic array)
        {
            List<User> itemlist = new List<User>();
            foreach (dynamic usr in array)
            {
                //Console.WriteLine(JsonConvert.SerializeObject( array));
                //Get data
                itemlist.Add(new User() { ID = usr["idUser"], name = usr["name"],firstname =  usr["firstname"], email = usr["email"], password = usr["password"], idRole = usr["idRole"], idUserParrainer = usr["idUser_parrainer"] }) ;
            }
            
            var usrViewItems = new ListViewItem[array.Count];
            int i = 0;
            //Add them in list
            foreach (User u in itemlist)
            { 
                var currItem = new ListViewItem(u.ID);
                currItem.SubItems.Add(u.name);
                currItem.SubItems.Add(u.firstname);
                currItem.SubItems.Add(u.email);
                currItem.SubItems.Add(u.idRole);
                currItem.SubItems.Add(u.idUserParrainer);
                usrViewItems[i]=(currItem);
                i++;




            }
            ListView.Items.AddRange(usrViewItems);
        }

        public user_list() {
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

        private void user_list_Load(Object sender, EventArgs e)
        {
           
        }

      


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
           
        }

        private void ListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListView.SelectedItems.Count == 1)
            {
                currentSelectedID = Int32.Parse(ListView.SelectedItems[0].Text);
            }
            else currentSelectedID = -1;
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (currentSelectedID !=-1) //An actual ID is selected
            {
                Api_Manager.getInstance().deleteUser(currentSelectedID);
                refreshList();
            }
        }
    }
}
