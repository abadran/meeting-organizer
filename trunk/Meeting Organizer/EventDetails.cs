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
        private User currentUser;
        private MainForm mainForm = null;

        public EventDetails()
        {
            InitializeComponent();
            this.AcceptButton = this.closeButton;
        }

        public EventDetails(User currentUser, Database db, Event evt, MainForm mf = null):
            this()
        {
            // TODO: Complete member initialization
            this.currentUser = currentUser;
            this.db = db;
            this.evt = evt;
            this.mainForm = mf;

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
            if ((currentUser.Id == evt.CreatorId) && (mainForm != null)){
                deleteButton.Visible = true;
            } else {
                deleteButton.Visible = false;
                closeButton.Left = deleteButton.Left + 260;
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            /* do all the necessary actions to erase this event */
            db.deleteEvent(evt);
            //mainForm.updateCalendarBoldedDates();
            this.Close();
        }

    }
}
