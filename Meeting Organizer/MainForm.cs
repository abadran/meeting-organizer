using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Meeting_Organizer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutDialog dlg = new AboutDialog();
            dlg.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.users' table. You can move, or remove it, as needed.
            //this.usersTableAdapter.Fill(this.dataSet.users);
            string dir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            //MessageBox.Show("Data Source=" + dir + "\\Meeting Organizer.sdf", "Bad login", MessageBoxButtons.OK);
            LoginDialog loginDialog = new LoginDialog();
            DialogResult result = System.Windows.Forms.DialogResult.Cancel;
            string filePath =  "Data Source=" + dir + "Meeting Organizer.sdf";
            if (File.Exists("C:\\Users\\Ahmed\\Documents\\Visual Studio 2010\\Projects\\Meeting Organizer\\Meeting Organizer\\Meeting Organizer.sdf"))
            {
                filePath = "Data Source=C:\\Users\\Ahmed\\Documents\\Visual Studio 2010\\Projects\\Meeting Organizer\\Meeting Organizer\\Meeting Organizer.sdf";
            }
            else if (File.Exists(dir + "\\Meeting Organizer.sdf"))
            {
                filePath = "Data Source=" + dir + "\\Meeting Organizer.sdf";
            }
            MeetingOrganizer organizerDB = new MeetingOrganizer(filePath);
            while (true)
            {
                loginDialog.login = "";
                loginDialog.password = "";
                result = loginDialog.ShowDialog();
                if (result == System.Windows.Forms.DialogResult.Cancel)
                {
                    Application.Exit();
                }
                var users = from p in organizerDB.Users
                            where (p.Login == loginDialog.login) && (p.Password == loginDialog.password)
                            select p;
                if (users.Count() != 0)
                {
                    break;
                }
                else
                {
                    MessageBox.Show("Incorrect login or password, please retry", "Bad login", MessageBoxButtons.OK);
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void MainForm_Shown(object sender, EventArgs e)
        {
        }


        private void newMeeting_Click(object sender, EventArgs e)
        {

        }

        private void viewUpcoming_Click(object sender, EventArgs e)
        {

        }
    }
}
