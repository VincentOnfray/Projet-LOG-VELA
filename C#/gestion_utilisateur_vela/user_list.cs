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

namespace gestion_utilisateur_vela
{
    public partial class user_list : Form
    {
        public class User
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        public user_list() {
            InitializeComponent();

            Db_Connect db = Db_Connect.getInstance();
            MySqlDataReader mdr = db.getUsers();
            mdr.Close();
            //Get data
            List<User> itemlist = new List<User>();
            itemlist.Add(new User() { Name = "John Doe", Age = 3 });
            itemlist.Add(new User() { Name = "Jane Doe", Age = 1 });
            itemlist.Add(new User() { Name = "Sammy Doe", Age = 2 });

            //Add them in list
            foreach (User u in itemlist)
            {

                ListViewItem lvi = new ListViewItem(u.Name);
                lvi.SubItems.Add(u.Age + "");
                //lvi.SubItems.Add(u.Name);
                ListView.Items.Add(lvi);
            }
            
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

        }
    }
}
