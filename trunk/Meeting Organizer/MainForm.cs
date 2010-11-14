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
        private User user = null;
        private Timer timer = null;
        //private NotificationButton[] notificationButtons = null;
        //private ArrayList notificationButtons = null;
        private ArrayList notificationButtons = null;
        private ArrayList eventButtons = null;
        private DateTime currentDate = DateTime.Now;

        public MainForm()
        {
            InitializeComponent();
            db = new Database(this);
            timer = new Timer();
            timer.Interval = 5000;
            timer.Tick += new System.EventHandler(this.refreshInvitationsFor);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                    createInvitationsFor(user);
                    break;
                }
                else
                {
                    MessageBox.Show("Incorrect login or password, please retry", "Bad login", MessageBoxButtons.OK);
                }
            }
            statusLabel.Text = "Logged in as: " + user.Login;
            updateCalendar();
            displayDailyEvents(calendar.TodayDate);
            timer.Start();
        }

        private void refreshInvitationsFor(object sender, EventArgs e)
        {
            createInvitationsFor(user);
        }
        private void createInvitationsFor(User user)
        {
            Event[] events = db.getNotificationsForUser(user);

            lock (this) {
                // remove old notifications buttons.
                removeStaleNotificationButtons(events);
                createNewInvitationButtons(events);
            }
        }

        private void createNewInvitationButtons(Event[] events)
        {
            foreach (Event evt in events) {
                if (eventAlreadyHasButton(evt)) {
                    continue;
                }
                NotificationButton foo = new NotificationButton(new Invitation(user, db, evt));
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
                foo.Click += new System.EventHandler(this.notification_button_Clicked);
                foo.Visible = true;
            }
        }

        bool eventAlreadyHasButton(Event evt)
        {
            object found =  notificationButtons.ToArray().ToList().Find(
                delegate(object o)
                {
                    NotificationButton nb = (NotificationButton)o;
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
                foreach (NotificationButton nb in notificationButtons.ToArray()) {
                    notificationsBox.Controls.Remove(nb);
                    notificationButtons.Clear();
                }
            } else {
                foreach (NotificationButton nb in notificationButtons.ToArray()) {
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void MainForm_Shown(object sender, EventArgs e)
        {
        }


        private void newMeeting_Click(object sender, EventArgs e)
        {

        }



        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void scheduleMeetingButton_Click(object sender, EventArgs e)
        {
            NewMeetingDialog dlg = new NewMeetingDialog(db);
            dlg.u = user;
            DialogResult r = dlg.ShowDialog();
            if (r == DialogResult.OK) {
                updateCalendar();
                displayDailyEvents(calendar.SelectionStart.Date);
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void notification_button_Clicked(object sender, EventArgs e)
        {
            NotificationButton b = (NotificationButton)sender;
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

        private void makeNotificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotificationButton foo = new NotificationButton(new Invitation(user, db, null, null));
            foo.Visible = false;
            foo.Text = "Dynamically built button";
            foo.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            foo.Dock = DockStyle.Top;
            notificationsBox.Controls.Add(foo);
            foo.BackColor = System.Drawing.SystemColors.Info;
            foo.Height += foo.Height;
            foo.Click += new System.EventHandler(this.notification_button_Clicked);
            foo.Visible = true;
        }

        private void makeEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Event evt = new Event();
            evt.CreatorId = user.Id;
            evt.Title = "Let's see if this works";
            evt.Subject = "How about a reasonable subject";
            evt.Start = DateTime.Now;
            evt.Start = evt.Start.AddDays(30);
            evt.Duration = 2;
            User[] users = null;
            Array.Resize(ref users, (users == null ? 0 : users.Length) + 1);
            users[users.Length - 1] = db.getUserWithLogin("linda");
            Array.Resize(ref users, (users == null ? 0 : users.Length) + 1);
            users[users.Length - 1] = db.getUserWithLogin("kai");
            Invitation inv = new Invitation(user, db, evt, users);
            inv.writeToDB();
        }

        private void calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            // if the month has changed update the view.
            if ((currentDate.Month != e.Start.Month) || (currentDate.Year != e.Start.Year)) {
                DateTime[] busyDays = db.getDaysWithEventsForUserForMonth(user, e.Start.Date);
                calendar.BoldedDates = busyDays;
                currentDate = e.Start;
            }
            if (currentDate.Date != e.Start.Date) {
                displayDailyEvents(e.Start);
                currentDate = e.Start;
            }
        }

        private void updateCalendar()
        {
            calendar.BoldedDates = db.getDaysWithEventsForUserForMonth(user, calendar.TodayDate);
            currentDate = calendar.TodayDate;
        }

        internal void addBusyDay(DateTime dateTime)
        {
            DateTime[] busyDays = calendar.BoldedDates;
            Array.Resize(ref busyDays, ((busyDays == null) ? 0 : busyDays.Length) + 1);
            busyDays[busyDays.Length - 1] = dateTime;
            calendar.BoldedDates = busyDays;
        }

        internal void acceptInvitationFrom(NotificationButton nb)
        {
            lock (this) {
                nb.invitation.accept();
                notificationsBox.Controls.Remove(nb);
                notificationButtons.Remove(nb);
                if (nb.invitation.evt.Start.Date == calendar.SelectionStart.Date) {
                    displayDailyEvents(calendar.SelectionStart);
                }
            }
        }

        internal void declineInvitationFrom(NotificationButton nb)
        {
            lock (this) {
                nb.invitation.decline();
                notificationsBox.Controls.Remove(nb);
                notificationButtons.Remove(nb);
            }
        }

        private void calendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            displayDailyEvents(e.Start);
        }

        private void displayDailyEvents(DateTime e)
        {
            foreach (EventButton eb in eventButtons.ToArray()) {
                eventPanel.Controls.Remove(eb);
                eventButtons.Remove(eb);
            }

            Event[] dailyEvents = db.getDailyEventsForUserForDay(user, e);
            if (dailyEvents == null) {
                return;
            }
            foreach (Event evt in dailyEvents) {
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
