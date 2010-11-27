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
        private User user;
        private EventDisplayMode displayMode = EventDisplayMode.ReadOnly;

        public EventDetails()
        {
            InitializeComponent();
            this.AcceptButton = this.closeButton;
        }

        public EventDetails(User currentUser, Database db, Event evt, EventDisplayMode dm):
            this()
        {
            // TODO: Complete member initialization
            this.user = currentUser;
            this.db = db;
            this.evt = evt;
            this.displayMode = dm;


            //User u = db.getUserWithId(evt.CreatorId);
            //string name = db.getUserWithId(evt.CreatorId).Name;
            fromTextBox.Text = db.getUserWithId(evt.CreatorId).Name;
            titleTextBox.Text = evt.Title;
            descriptionTextBox.Text = evt.Subject;
            //string invitees = null;
            //foreach (User usr in db.getInviteesForEvent(evt)) {
            //    invitees += usr.Name + "; ";
            //}
            //attendeesTextBox.Text = invitees;
            attendeesTextBox.Text = db.getInviteesAndResponsesForEvent(evt);
            duration.Text = evt.Duration.ToString();
            dateTime.Text = evt.Start.ToString();
            if ((currentUser.Id == evt.CreatorId) && (displayMode == EventDisplayMode.Deletable)){
                deleteOrAckButton.Visible = true;
            } else if (displayMode == EventDisplayMode.Acknowledgeable) {
                deleteOrAckButton.Text = "Acknowledge";
                deleteOrAckButton.Visible = true;
            } else {
                deleteOrAckButton.Visible = false;
                closeButton.Left = deleteOrAckButton.Left + 260;
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteOrAckButton_Clicked(object sender, EventArgs e)
        {
            /* do all the necessary actions to erase this event */
            if (displayMode == EventDisplayMode.Deletable) {
                db.deleteEvent(evt);
                this.Close();
            } else if (displayMode == EventDisplayMode.Acknowledgeable) {
                db.acknowledgeEventCancelation(user, evt);
                this.Close();
            } else {
                // this is an error the button should be hidden when the display mode is read only!
            }
        }

    }
}
