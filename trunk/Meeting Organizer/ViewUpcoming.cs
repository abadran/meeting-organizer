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


            //list 5 latest upcoming events
            for (int i = 0; i < 5; i++) 
            {
                // print event time, title on buttons
                evtButtons[i].Text = "Title: " + UpcomingEvents[i].Title +"    "+ "Begin at: " + UpcomingEvents[i].Start+"   "+"Duration: " + UpcomingEvents[i].Duration+" hours";
            }

            //updateCalendar();
            //timer.Start();

        }


        // display event details when click on buttons
        private void button1_Click(object sender, EventArgs e)
        {
            EventDetails ed = new EventDetails(db, UpcomingEvents[0]);
            ed.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EventDetails ed = new EventDetails(db, UpcomingEvents[1]);
            ed.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EventDetails ed = new EventDetails(db, UpcomingEvents[2]);
            ed.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EventDetails ed = new EventDetails(db, UpcomingEvents[3]);
            ed.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EventDetails ed = new EventDetails(db, UpcomingEvents[4]);
            ed.ShowDialog();
        }






    }
}
