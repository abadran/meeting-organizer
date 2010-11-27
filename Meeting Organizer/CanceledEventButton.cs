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
    public partial class CanceledEventButton : System.Windows.Forms.Button
    {
        private User user { get; set; }
        private Database db { get; set; }
        public Event evt { get; set; }
        public CanceledEventButton()
        {
            InitializeComponent();
            //BackColor = Color.Red;
            BackColor = Color.Turquoise;
        }

        public CanceledEventButton(User user, Database db, Event evt):
            this()
        {
            this.user = user;
            this.db = db;
            this.evt = evt;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        private void buttonClicked(object sender, EventArgs e)
        {
            // show details of the canceled event.
            EventDetails ed = new EventDetails(user, db, evt, EventDisplayMode.Acknowledgeable);
            ed.ShowDialog();
        }
    }
}
