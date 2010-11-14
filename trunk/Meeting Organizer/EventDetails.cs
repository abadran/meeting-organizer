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
    public partial class EventDetails : Form
    {
        private Database db;
        private Event evt;

        public EventDetails()
        {
            InitializeComponent();
            this.AcceptButton = this.okButton;
        }

        public EventDetails(Database db, Event evt):
            this()
        {
            // TODO: Complete member initialization
            this.db = db;
            this.evt = evt;

            //User u = db.getUserWithId(evt.CreatorId);
            //string name = db.getUserWithId(evt.CreatorId).Name;
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

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
