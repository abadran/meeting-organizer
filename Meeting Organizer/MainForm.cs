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
        private Database db = null;
        private User user = null;

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
                if ((user = db.getUserWithLoginAndPassword(loginDialog.login, loginDialog.password)) != null) {
                    createInvitationsFor(user);
                    break;
                }
                else
                {
                    MessageBox.Show("Incorrect login or password, please retry", "Bad login", MessageBoxButtons.OK);
                }
            }

        }

        private void createInvitationsFor(User user)
        {
            Notifications n = db.getNotificationsForUser(user);
            for (int i = 0; i < n.numberOfNotifications; ++i) {
                NotificationButton foo = new NotificationButton(n.getEvent(i), db);
                foo.Visible = false;
                foo.Text = "Invitation from: " + db.getUserWithId(n.getEvent(i).CreatorId).Name + "\n" +
                n.getEvent(i).Title;
                foo.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                foo.Dock = DockStyle.Top;
                notificationsBox.Controls.Add(foo);
                foo.BackColor = System.Drawing.SystemColors.Info;
                foo.Height += foo.Height;
                foo.Click += new System.EventHandler(this.notification_button_Clicked);
                foo.Visible = true;
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
            db.createNewUser(foo);

            NewMeetingDialog dlg = new NewMeetingDialog();
            dlg.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void notification_button_Clicked(object sender, EventArgs e)
        {
            NotificationButton b = (NotificationButton)sender;
            //b.Visible = false;
            //notificationsBox.Controls.Remove(b);
            InvitationDetails id = new InvitationDetails(b.evt, db);
            id.Show();
            //MessageBox.Show("Button pressed", "hello", MessageBoxButtons.OK);
        }

        private void button3_Click(object sender, EventArgs e)
        {
                NotificationButton foo = new NotificationButton(null, db);
                foo.Visible = false;
                foo.Text = "Dynamically built button";
                foo.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                foo.Dock = DockStyle.Top;
                notificationsBox.Controls.Add(foo);
                foo.BackColor = System.Drawing.SystemColors.Info;
                foo.Height += foo.Height;
                foo.Click += new System.EventHandler(this.notification_button_Clicked);
                foo.Visible = true;
        }

        private void makeEvent_Click(object sender, EventArgs e)
        {
            Event evt = new Event();
            evt.CreatorId = user.Id;
            evt.Title = "Some silly title";
            evt.Subject = "Some weird subject";
            evt.Start = DateTime.Now;
            evt.Duration = 2;
            User[] users = null;
            Array.Resize(ref users, (users == null ? 0 : users.Length) + 1);
            users[users.Length - 1] = db.getUserWithLogin("ahmed");
            db.createInvitation(new Invitation(evt, users));
        }
    }
}
