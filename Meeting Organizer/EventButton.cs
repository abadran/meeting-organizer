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
    public partial class EventButton : System.Windows.Forms.Button
    {
        private Event evt;
        private MainForm mainForm;
        private Database db;

        public EventButton()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        public EventButton(Database db, Event evt, MainForm mainForm):
            this()
        {
            this.db = db;
            this.evt = evt;
            this.mainForm = mainForm;
            this.BackColor = Color.AliceBlue;
            this.Text = evt.Title;        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        public void buttonClicked(object sender, EventArgs e)
        {
            EventDetails ed = new EventDetails(mainForm.user, db, evt, mainForm);
            ed.ShowDialog();
        }
    }
}
