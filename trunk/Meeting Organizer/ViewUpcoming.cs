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
    public partial class ViewUpcoming : Form
    {
        public User u;

        public DateTime dateTime;
        public Event[] UpcomingEvents; 
        public Event evt;
        private Database db = null;
        public ViewUpcoming()
        {
            InitializeComponent();
        }

          public ViewUpcoming(Database db):
            this()
        {
            this.db = db;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            EventDetails ed = new EventDetails(db, evt);
            ed.ShowDialog();
        }

        private void ViewUpcoming_Load(object sender, EventArgs e)
        {
            dateTime = DateTime.Now;
            UpcomingEvents = db.getUpcomingEvents(u, dateTime);


           // button1.Text = "1 " + UpcomingEvents.title;
            button2.Text = "2 "+DateTime.Now + " test";
            button3.Text = "3 "+DateTime.Now + "";
            button4.Text = "4 "+DateTime.Now + " good";
            button5.Text = "5 "+DateTime.Now + " good";
        }




    }
}
