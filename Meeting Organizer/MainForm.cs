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
    public partial class MainForm : Form
    {
        private Database db = null;
        //private User user = null;
        private Timer timer = null;
        //private NotificationButton[] notificationButtons = null;
        //private ArrayList notificationButtons = null;
        private ArrayList notificationButtons = null;
        private ArrayList eventButtons = null;
        private DateTime currentDate = DateTime.Now;

        public User user { get; set; }
        public MainForm()
        {
            InitializeComponent();
            user = null;
            db = new Database(this);
            timer = new Timer();
            //timer.Interval = 5000;
            timer.Interval = 2000;
            timer.Tick += new System.EventHandler(this.updateView);
            //notifications = new Notifications(null);
            notificationButtons = new ArrayList();
            eventButtons = new ArrayList();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutDialog dlg = new AboutDialog();
            dlg.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoginDialog loginDialog = new LoginDialog();
            //Database db = new Database();
            DialogResult result = DialogResult.Cancel;
            while (true)
            {
                loginDialog.login = "";
                loginDialog.password = "";
                result = loginDialog.ShowDialog();
                if (result == System.Windows.Forms.DialogResult.Cancel)
                {
                    Application.Exit();
                    return;
                }
                if ((user = db.getUserWithLoginAndPassword(loginDialog.login, loginDialog.password)) != null) {
                    //createInvitationsFor(user);
                    //updateView(this, null);
                    break;
                }
                else
                {
                    MessageBox.Show("Incorrect login or password, please retry", "Bad login", MessageBoxButtons.OK);
                }
            }
            statusLabel.Text = "Logged in as: " + user.Login;
            calendar.SelectionStart = DateTime.Now;
            updateView(this, null);
            timer.Start();
        }

        private void updateView(object sender, EventArgs e)
        {
            updateViewForDate(calendar.SelectionStart.Date);
        }

        private void updateViewForDate(DateTime dateTime)
        {
            lock (this) {
                createInvitationsFor(user);
                updateCalendarBoldedDates(dateTime);
                displayDailyEvents(dateTime);
            }
        }
        private void createInvitationsFor(User user)
        {
            Event[] events = db.getNotificationsForUser(user);
            // remove old notifications buttons.
            removeStaleNotificationButtons(events);
            createNewInvitationButtons(events);
        }

        private void createNewInvitationButtons(Event[] events)
        {
            foreach (Event evt in events) {
                if (eventAlreadyHasButton(evt)) {
                    continue;
                }
                InvitationNotificationButton foo = new InvitationNotificationButton(new Invitation(user, db, evt));
                //Array.Resize(ref notificationButtons, ((notificationButtons == null) ? 0 : notificationButtons.Length) + 1);
                //notificationButtons[notificationButtons.Length - 1] = foo;
                notificationButtons.Add(foo);
                foo.Visible = false;
                foo.Text = "Invitation from: " + db.getUserWithId(evt.CreatorId).Name + "\n" +
                evt.Title;
                foo.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                foo.Dock = DockStyle.Top;
                notificationsBox.Controls.Add(foo);
                foo.BackColor = System.Drawing.SystemColors.Info;
                foo.Height += foo.Height;
                foo.Click += new System.EventHandler(this.invitationNotificationButtonClicked);
                foo.Visible = true;
            }
        }

        bool eventAlreadyHasButton(Event evt)
        {
            object found =  notificationButtons.ToArray().ToList().Find(
                delegate(object o)
                {
                    InvitationNotificationButton nb = (InvitationNotificationButton)o;
                    return nb.invitation.evt.Id == evt.Id;
                }
                );
            return (found != null);
        }

        void removeStaleNotificationButtons(Event[] events)
        {
            if (notificationButtons.Count == 0) {
                return;
            }

            if (events == null) {
                foreach (InvitationNotificationButton nb in notificationButtons.ToArray()) {
                    notificationsBox.Controls.Remove(nb);
                    notificationButtons.Clear();
                }
            } else {
                foreach (InvitationNotificationButton nb in notificationButtons.ToArray()) {
                    Event found = events.ToList().Find(
                    delegate (Event evt) {
                        return evt.Id == nb.invitation.evt.Id;
                    }
                    );
                    // if we don't find the old event in the new list of events
                    // then remove it.
                    if (found == null) {
                        notificationsBox.Controls.Remove(nb);
                        notificationButtons.Remove(nb);
                    }
                }
            }
        }

        private void scheduleMeetingButton_Click(object sender, EventArgs e)
        {
            NewMeetingDialog dlg = new NewMeetingDialog(db);
            dlg.u = user;
            DialogResult r = dlg.ShowDialog();
            if (r == DialogResult.OK) {
                updateViewForDate(calendar.SelectionStart.Date);
            }
        }

        private void invitationNotificationButtonClicked(object sender, EventArgs e)
        {
            InvitationNotificationButton b = (InvitationNotificationButton)sender;
            //b.Visible = false;
            //notificationsBox.Controls.Remove(b);
            InvitationDetails id = new InvitationDetails(db, this, b);
            id.Show();
            //MessageBox.Show("Button pressed", "hello", MessageBoxButtons.OK);
        }

        private void viewUpcomingMeetingsButton_Click(object sender, EventArgs e)
        {
            ///continue

            ViewUpcoming dlg = new ViewUpcoming(db);
            dlg.u = user;
            dlg.ShowDialog();
        }

        private void calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime[] busyDays = db.getDaysWithEventsForUserForMonth(user, e.Start.Date);
            if (!calendar.BoldedDates.SequenceEqual(busyDays)) {
                updateViewForDate(e.Start.Date);
                //calendar.BoldedDates = busyDays;
                //currentDate = e.Start;
            }
            //if (currentDate.Date != e.Start.Date) {
            //    displayDailyEvents(e.Start);
            //    currentDate = e.Start;
            //}
        }
        private void calendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            updateViewForDate(e.Start);
            //displayDailyEvents(e.Start);
        }

        public void updateCalendarBoldedDates(DateTime dateTime)
        {
            //calendar.BoldedDates = db.getDaysWithEventsForUserForMonth(user, calendar.SelectionStart.Date);
            DateTime[] busyDays = db.getDaysWithEventsForUserForMonth(user, dateTime);
            if (!calendar.BoldedDates.SequenceEqual(busyDays)) {
                calendar.BoldedDates = busyDays;
                currentDate = calendar.SelectionStart.Date;
                //currentDate = calendar.TodayDate;
            }
        }

        internal void acceptInvitationFrom(InvitationNotificationButton nb)
        {
            nb.invitation.accept();
            updateViewForDate(calendar.SelectionStart.Date);
            //lock (this) {

                //notificationsBox.Controls.Remove(nb);
                //notificationButtons.Remove(nb);
                //if (nb.invitation.evt.Start.Date == calendar.SelectionStart.Date) {
                //    displayDailyEvents(calendar.SelectionStart);
                //}
            //}
        }

        internal void declineInvitationFrom(InvitationNotificationButton nb)
        {
            nb.invitation.decline();
            updateViewForDate(calendar.SelectionStart.Date);
            //lock (this) {
            //    notificationsBox.Controls.Remove(nb);
            //    notificationButtons.Remove(nb);
            //}
        }


        private void displayDailyEvents(DateTime e)
        {
            Event[] dailyEvents = db.getDailyEventsForUserForDay(user, e);
            if (dailyEvents == null) {

                // remove all old events.
                foreach (EventButton eb in eventButtons.ToArray()) {
                    eventPanel.Controls.Remove(eb);
                    eventButtons.Remove(eb);
                }

                return;
            }


            // remove stale event buttons.
            List<Event> de = dailyEvents.ToList();
            foreach (EventButton eb in eventButtons.ToArray()){
                object found = de.Find(
                    delegate(Event evt)
                    {
                        return eb.evt.Id == evt.Id;
                    }
                );

                if (found == null) {
                    eventPanel.Controls.Remove(eb);
                    eventButtons.Remove(eb);
                }
            }


            // find out what new events are not already displayed.
            List<Object> ebList = eventButtons.ToArray().ToList();
            foreach (Event evt in dailyEvents) {
                // remove old event buttons that don't exist anymore.
                object found = ebList.Find(
                    delegate(object o)
                    {
                        EventButton eb = (EventButton)o;
                        return eb.evt.Id == evt.Id;
                    }
                    );
                if (found == null) {
                    EventButton eb = new EventButton(db, evt, this);
                    //eb.Visible = false;
                    eb.Click += new System.EventHandler(eb.buttonClicked);
                    eventButtons.Add(eb);
                    eb.Location = new Point(5, ((evt.Start.Hour - 9) * 60) + 5);
                    eb.Width = 640;
                    eb.Height = (evt.Duration * 60) - 10;
                    eventPanel.Controls.Add(eb);
                }
            }

        }

    }
}
