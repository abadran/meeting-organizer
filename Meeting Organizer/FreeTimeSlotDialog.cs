using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Meeting_Organizer
{
    public partial class FreeTimeSlotDialog : Form
    {
        public string meetingTitle;

        public string meetingDescription;

        public User[] users;

        public User u;

        public int duration;

        public DateTime date;

        public Database db = new Database();

        private int[][] avaliable;

        public User[] availableUsers;

        public int selected;

        private int[] number;
        
        public FreeTimeSlotDialog()
        {
            InitializeComponent();
        }

        private void FreeTimeSlotDialog_Load(object sender, EventArgs e)
        {
            Button[] myButton = new Button[14];
            Button[] selButton = new Button[14];

            myButton[0] = button5;
            myButton[1] = button7;
            myButton[2] = button9;
            myButton[3] = button11;
            myButton[4] = button13;
            myButton[5] = button15;
            myButton[6] = button17;
            myButton[7] = button19;
            myButton[8] = button21;
            myButton[9] = button23;
            myButton[10] = button25;
            myButton[11] = button27;
            myButton[12] = button29;
            myButton[13] = button31;

            selButton[0] = button6;
            selButton[1] = button8;
            selButton[2] = button10;
            selButton[3] = button12;
            selButton[4] = button14;
            selButton[5] = button16;
            selButton[6] = button18;
            selButton[7] = button20;
            selButton[8] = button22;
            selButton[9] = button24;
            selButton[10] = button26;
            selButton[11] = button28;
            selButton[12] = button30;
            selButton[13] = button32;

            RichTextBox[] textBox = new RichTextBox[8];
            RichTextBox[] numBox = new RichTextBox[8];

            textBox[0] = richTextBox1;
            textBox[1] = richTextBox3;
            textBox[2] = richTextBox5;
            textBox[3] = richTextBox7;
            textBox[4] = richTextBox9;
            textBox[5] = richTextBox11;
            textBox[6] = richTextBox13;
            textBox[7] = richTextBox15;

            numBox[0] = richTextBox2;
            numBox[1] = richTextBox4;
            numBox[2] = richTextBox6;
            numBox[3] = richTextBox8;
            numBox[4] = richTextBox10;
            numBox[5] = richTextBox12;
            numBox[6] = richTextBox14;
            numBox[7] = richTextBox16;

            selected = 0;

            number = new int[9 - duration];
            string[] people = new string[9 - duration];
            for (int i = 0; i < 9 - duration; i++)
            {
                number[i] = 0;
                people[i] = "";
            }
            int start = 9;
            int current;
            if (duration == 0)
            {
 
            }

            if (users != null)
            {
                User[] us = new User[users.Length];
                for (int i = 0; i < us.Length; i++)
                {
                    us[i] = users[i];
                }
                users = new User[us.Length + 1];
                for (int i = 0; i < us.Length; i++)
                {
                    users[i] = us[i];
                }
                users[us.Length] = u;
            }
            else
            {
                users = new User[1];
                users[0] = u;
            }

            if (duration > 0)
            {
                if (users != null)
                {
                    avaliable = new int[users.Length][];
                    for (int j = 0; j < users.Length; j++)
                    {
                        start = 9;
                        avaliable[j] = new int[9 - duration];
                        DateTime[] time = db.getTimeWithEventsForUserForMonthForDay(users[j], date);
                        int[] durations = db.getDurationWithEventsForUserForMonthForDay(users[j], date);
                        for (int i = 0; i < 9 - duration; i++)
                        {
                            avaliable[j][i] = 1;
                            for (int p = 0; p < time.Length; p++)
                            {
                                if (time[p].TimeOfDay.TotalHours + (double)durations[p] <= (double)(start + i))
                                {
                                    avaliable[j][i] = 1;
                                }
                                else if (time[p].TimeOfDay.TotalHours >= (double)(start + i + duration))
                                {
                                    avaliable[j][i] = 1;
                                }
                                else
                                {
                                    avaliable[j][i] = 0;
                                    break;
                                }
                            }

                            if (avaliable[j][i] == 1)
                            {
                                number[i]++;
                                people[i] = people[i] + users[j].Login + ";";
                            }
                        }
                    }
                }

                start = 9;

                for (int i = 0; i < 9 - duration; i++)
                {
                    current = start + i;
                    myButton[i].Text = current.ToString() + ":00 - " + (current + duration).ToString() + ":00";
                    if (users != null)
                    {
                        textBox[i].Text = people[i];
                        numBox[i].Text = "                " + number[i].ToString();
                    }
                }
                for (int i = 9 - duration; i < 14; i++)
                {
                    selButton[i].Text = "";
                    selButton[i].Enabled = false;
                    myButton[i].Enabled = false;
                }

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            selected = 1;
//            setAvailableUsers(1);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            selected = 2;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            selected = 3;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            selected = 4;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            selected = 5;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            selected = 6;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            selected = 7;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            selected = 8;
        }

        private void setAvailableUsers(int timeslot)
        {
            availableUsers = new User[number[timeslot - 1]];
            int j = 0;
            for (int i = 0; i < avaliable.Length; i++)
            {
                if (avaliable[i][timeslot - 1] == 1)
                {
                   availableUsers[j] = users[i];
                   j++;
                }
            }
        }
    }
}
