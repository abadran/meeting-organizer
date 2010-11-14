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
        public Event evt;
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

            UpcomingEvents = db.getUpcomingEvents(u, dateTime);
            evtButtons = new Button[5];
            evtButtons[0] = button1;
            evtButtons[1] = button2;
            evtButtons[2] = button3;
            evtButtons[3] = button4;
            evtButtons[4] = button5;

            for (int i = 0; i < 5; i++) // we only list 5 of the upcoming events
            {
                        evtButtons[i].Text = UpcomingEvents[i].Start+UpcomingEvents[i].Title;
            }

            //updateCalendar();
            //timer.Start();

        }

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
