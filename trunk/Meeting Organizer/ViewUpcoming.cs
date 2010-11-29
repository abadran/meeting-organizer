using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace Meeting_Organizer
{
    public partial class ViewUpcoming : Form
    {
        public User u;

        public DateTime dateTime;
        public Event[] UpcomingEvents;
        private Database db = null;
        public Button[] evtButtons;


        public ViewUpcoming()
        {
            InitializeComponent();
        }

          public ViewUpcoming(Database db):
            this()
        {
            this.db = db;
        }

          private void OK_Click(object sender, EventArgs e)
          {
              this.Close();
          }



        private void ViewUpcoming_Load(object sender, EventArgs e)
        {
            //Event[] UpcomingEvents;
            int num = 5;
            dateTime = DateTime.Now;

            //fetch upcoming events from DB
            UpcomingEvents = db.getUpcomingEvents(u, dateTime);

            //list 5 buttons for latest 5 events
            evtButtons = new Button[5];
            evtButtons[0] = button1;
            evtButtons[1] = button2;
            evtButtons[2] = button3;
            evtButtons[3] = button4;
            evtButtons[4] = button5;

            // will need to make some buttons
            // invisible in case there are
            //  less than 5 events
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;

            //list 5 latest upcoming events OR the length
            // of UpcomingEvents (can have less than five 
            //  events)
            if (UpcomingEvents.Length < 5)
            {
                num = UpcomingEvents.Length;
                if (num == 0)
                {
                    evtButtons[0].Visible = true;
                    evtButtons[0].Text = "No meetings scheduled";
                    evtButtons[0].Enabled = false;
                }
            }

            for (int i = 0; i < num; i++) 
            {
                // print event time, title on buttons
                evtButtons[i].Visible = true; // make visible
                evtButtons[i].Text = "Title: " + UpcomingEvents[i].Title +"    "+ "Begin at: " + UpcomingEvents[i].Start+"   "+"Duration: " + UpcomingEvents[i].Duration+" hours";
            }

            //updateCalendar();
            //timer.Start();

        }


        // display event details when click on buttons
        private void button1_Click(object sender, EventArgs e)
        {
            EventDetails ed = new EventDetails(u, db, UpcomingEvents[0], EventDisplayMode.ReadOnly);
            ed.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EventDetails ed = new EventDetails(u, db, UpcomingEvents[1], EventDisplayMode.ReadOnly);
            ed.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EventDetails ed = new EventDetails(u, db, UpcomingEvents[2], EventDisplayMode.ReadOnly);
            ed.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EventDetails ed = new EventDetails(u, db, UpcomingEvents[3], EventDisplayMode.ReadOnly);
            ed.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EventDetails ed = new EventDetails(u, db, UpcomingEvents[4], EventDisplayMode.ReadOnly);
            ed.ShowDialog();
        }






    }
}
