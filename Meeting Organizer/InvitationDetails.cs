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
        private GroupBox gb = null;
        private NotificationButton nb = null;
        public InvitationDetails()
        {
            InitializeComponent();
        }
        public InvitationDetails(Event e, Database db_, GroupBox panel, NotificationButton b):
            this()
        {
            evt = e;
            db = db_;
            gb = panel;
            nb = b;

            fromTextBox.Text = db.getUserWithId(e.CreatorId).Name;
            titleTextBox.Text = e.Title;
            descriptionTextBox.Text = e.Subject;
            string invitees = null;
            foreach (User user in db.getInviteesForEvent(e)) {
                invitees += user.Name + "; ";
            }
            attendeesTextBox.Text = invitees;
            duration.Text = e.Duration.ToString();
            dateTime.Text = e.Start.ToString();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            gb.Controls.Remove(nb);
            this.Close();
        }

        private void declineButton_Click(object sender, EventArgs e)
        {
            gb.Controls.Remove(nb);
            this.Close();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
