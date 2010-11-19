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
    public partial class NewMeetingDialog : Form
    {
        public NewMeetingDialog()
        {
            InitializeComponent();
        }

        public NewMeetingDialog(Database db):
            this()
        {
            this.db = db;
        }

        public string meetingTitle;

        public string meetingDescription;

        public User[] users;

        public User u;

        public int duration;

        public DateTime date;

        private Database db = null;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void addAttendeeButton_Click(object sender, EventArgs e)
        {
            AddAttendeeDialog dlg = new AddAttendeeDialog();
            dlg.u = u;
            DialogResult result = System.Windows.Forms.DialogResult.Cancel;
            result = dlg.ShowDialog();

            if (result != System.Windows.Forms.DialogResult.Cancel)
            {
                users = dlg.users;
                string user = "";
                for(int i=0;i<users.Length;i++)
                {
                    user = user + users[i].Login + ";";
                 }
                textBox2.Text = user;
            }
        }

        private void findAvailableTime_Clicked(object sender, EventArgs e)
        {
            DialogResult result = System.Windows.Forms.DialogResult.Cancel;
            
            meetingTitle = textBox1.Text;
            duration = int.Parse(numericUpDown1.Value.ToString());
            meetingDescription = richTextBox1.Text;
            date = dateTimePicker1.Value;

            FreeTimeSlotDialog fts = new FreeTimeSlotDialog();

            fts.meetingDescription = meetingDescription;
            fts.meetingTitle = meetingTitle;
            fts.date = date;
            fts.duration = duration;
            fts.users = users;

            result = fts.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                int current = 8 + fts.selected;
                date = date.AddHours(((double)0) - date.TimeOfDay.TotalHours + (double)current);
                string timeslot = current.ToString() + ":00 - " + (current + duration).ToString() + ":00";
                textBox3.Text = timeslot;
            }
        }

        private bool computeTimeSlot()
        {
            bool res;
            res = false;

            return res;
        }

        private void scheduleMeeting_Clicked(object sender, EventArgs e)
        {
            meetingDescription = richTextBox1.Text;

            Event evt = new Event();
            evt.CreatorId = u.Id;
            evt.Title = meetingTitle;
            evt.Subject = meetingDescription;
            evt.Start = date;
            evt.Duration = duration;

            Invitation inv = new Invitation(u, db, evt, users);
            inv.writeToDB();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {

        }
    }
}
