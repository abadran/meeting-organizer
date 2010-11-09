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
        private Database db;
        public MainForm()
        {
            InitializeComponent();
            db = new Database();
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
            LoginDialog loginDialog = new LoginDialog();
            //Database db = new Database();
            DialogResult result = DialogResult.Cancel;
            while (true)
            {
                loginDialog.login = "";
                loginDialog.password = "";
                result = loginDialog.ShowDialog();
                if (result == System.Windows.Forms.DialogResult.Cancel)
                {
                    Application.Exit();
                }
                if (db.getUserWithLoginAndPassword(loginDialog.login, loginDialog.password) != null) {
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

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void scheduleMeetingButton_Click(object sender, EventArgs e)
        {
            User foo = new User();
            foo.Name = "Test Login";
            foo.Login = DateTime.Now.ToString();
            foo.Password = "password";
            db.CreateNewUser(foo);

            NewMeetingDialog dlg = new NewMeetingDialog();
            dlg.ShowDialog();

        }
    }
}
