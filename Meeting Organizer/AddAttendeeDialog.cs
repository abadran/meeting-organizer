using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Meeting_Organizer
{
    public partial class AddAttendeeDialog : Form
    {
        public User u;
        
        private Database db = null;
        
        public AddAttendeeDialog()
        {
            InitializeComponent();
        }

        public User[] users;
        
        private void AddAttendeeDialog_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'meetingorganizerDataSet.users' table. You can move, or remove it, as needed.
/*            string connStr = "server=131.252.209.228;user=root;database=meetingorganizer;port=3306;password=123456;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                // Perform databse operations
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
            while (true)
            {
                string sql = "select login from user;";

                try
                {
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        listBox1.Items.Add(rdr[0]);
                    }
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            conn.Close();*/
//            db.getUserNamesSkipping(userLogin);
            db = new Database();
            users = db.getUsers();
            for (int i = 0; i < users.Length; i++)
            {
                if (users[i].Id != u.Id)
                {
                    listBox1.Items.Add(users[i].Login);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox2.Items.Count > 0)
            {
                listBox1.Items.Add(listBox2.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                listBox2.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            users = new User[listBox2.Items.Count];
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                users[i] = db.getUserWithLogin(listBox2.Items[i].ToString());
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
