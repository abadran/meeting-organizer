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
    public partial class InvitationDetails : Form
    {
        private Event evt = null;
        private Database db = null;
        private InvitationNotificationButton nb = null;
        private MainForm mainForm = null;
        public InvitationDetails()
        {
            InitializeComponent();
        }
        public InvitationDetails(Database db_, MainForm mf, InvitationNotificationButton b):
            this()
        {
            evt = b.invitation.evt;
            db = db_;
            mainForm = mf;
            nb = b;

            fromTextBox.Text = db.getUserWithId(evt.CreatorId).Name;
            titleTextBox.Text = evt.Title;
            descriptionTextBox.Text = evt.Subject;
            string invitees = null;
            foreach (User user in db.getInviteesForEvent(evt)) {
                invitees += user.Name + "; ";
            }
            attendeesTextBox.Text = invitees;
            duration.Text = evt.Duration.ToString();
            dateTime.Text = evt.Start.ToString();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            mainForm.acceptInvitationFrom(nb);
//            nb.invitation.accept();
//            gb.Controls.Remove(nb);
            this.Close();
        }

        private void declineButton_Click(object sender, EventArgs e)
        {
            mainForm.declineInvitationFrom(nb);
//            nb.invitation.decline();
//            gb.Controls.Remove(nb);
            this.Close();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
