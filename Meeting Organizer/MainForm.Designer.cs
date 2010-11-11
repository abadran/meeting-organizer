namespace Meeting_Organizer
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeNotificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.globalContainer = new System.Windows.Forms.SplitContainer();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.nineLabel = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.notificationsBox = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.viewUpcomingMeetingsButton = new System.Windows.Forms.Button();
            this.scheduleMeetingButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.globalContainer)).BeginInit();
            this.globalContainer.Panel1.SuspendLayout();
            this.globalContainer.Panel2.SuspendLayout();
            this.globalContainer.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.notificationsBox.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(980, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.quitToolStripMenuItem.Text = "&Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeNotificationToolStripMenuItem,
            this.makeEventToolStripMenuItem});
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.testToolStripMenuItem.Text = "Test";
            // 
            // makeNotificationToolStripMenuItem
            // 
            this.makeNotificationToolStripMenuItem.Name = "makeNotificationToolStripMenuItem";
            this.makeNotificationToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.makeNotificationToolStripMenuItem.Text = "Make Notification";
            this.makeNotificationToolStripMenuItem.Click += new System.EventHandler(this.makeNotificationToolStripMenuItem_Click);
            // 
            // makeEventToolStripMenuItem
            // 
            this.makeEventToolStripMenuItem.Name = "makeEventToolStripMenuItem";
            this.makeEventToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.makeEventToolStripMenuItem.Text = "Make Event";
            this.makeEventToolStripMenuItem.Click += new System.EventHandler(this.makeEventToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusBar
            // 
            this.statusBar.Location = new System.Drawing.Point(0, 511);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(980, 22);
            this.statusBar.TabIndex = 3;
            this.statusBar.Text = "statusStrip1";
            // 
            // globalContainer
            // 
            this.globalContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.globalContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.globalContainer.Location = new System.Drawing.Point(0, 24);
            this.globalContainer.Name = "globalContainer";
            // 
            // globalContainer.Panel1
            // 
            this.globalContainer.Panel1.BackColor = System.Drawing.SystemColors.Window;
            this.globalContainer.Panel1.Controls.Add(this.panel8);
            this.globalContainer.Panel1.Controls.Add(this.panel9);
            this.globalContainer.Panel1.Controls.Add(this.panel10);
            this.globalContainer.Panel1.Controls.Add(this.panel11);
            this.globalContainer.Panel1.Controls.Add(this.panel5);
            this.globalContainer.Panel1.Controls.Add(this.panel7);
            this.globalContainer.Panel1.Controls.Add(this.panel4);
            this.globalContainer.Panel1.Controls.Add(this.panel6);
            // 
            // globalContainer.Panel2
            // 
            this.globalContainer.Panel2.Controls.Add(this.notificationsBox);
            this.globalContainer.Panel2.Controls.Add(this.panel3);
            this.globalContainer.Panel2.Controls.Add(this.panel1);
            this.globalContainer.Panel2.Controls.Add(this.monthCalendar2);
            this.globalContainer.Size = new System.Drawing.Size(980, 487);
            this.globalContainer.SplitterDistance = 746;
            this.globalContainer.TabIndex = 5;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel8.Controls.Add(this.label7);
            this.panel8.Controls.Add(this.button5);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 427);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(746, 61);
            this.panel8.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 25);
            this.label7.TabIndex = 34;
            this.label7.Text = "4:00";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.AliceBlue;
            this.button5.Location = new System.Drawing.Point(82, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(656, 53);
            this.button5.TabIndex = 26;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.Window;
            this.panel9.Controls.Add(this.label6);
            this.panel9.Controls.Add(this.button6);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 366);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(746, 61);
            this.panel9.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 25);
            this.label6.TabIndex = 33;
            this.label6.Text = "3:00";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.AliceBlue;
            this.button6.Location = new System.Drawing.Point(82, 6);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(656, 70);
            this.button6.TabIndex = 26;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel10.Controls.Add(this.label5);
            this.panel10.Controls.Add(this.button7);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 305);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(746, 61);
            this.panel10.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 25);
            this.label5.TabIndex = 32;
            this.label5.Text = "2:00";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.AliceBlue;
            this.button7.Location = new System.Drawing.Point(82, 23);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(656, 53);
            this.button7.TabIndex = 26;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.SystemColors.Window;
            this.panel11.Controls.Add(this.label4);
            this.panel11.Controls.Add(this.button8);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 244);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(746, 61);
            this.panel11.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 25);
            this.label4.TabIndex = 31;
            this.label4.Text = "1:00";
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.AliceBlue;
            this.button8.Location = new System.Drawing.Point(82, 6);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(656, 70);
            this.button8.TabIndex = 26;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.button2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 183);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(746, 61);
            this.panel5.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 25);
            this.label3.TabIndex = 30;
            this.label3.Text = "12:00";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.AliceBlue;
            this.button2.Location = new System.Drawing.Point(82, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(656, 53);
            this.button2.TabIndex = 26;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.Window;
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.button4);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 122);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(746, 61);
            this.panel7.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 29;
            this.label2.Text = "11:00";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.AliceBlue;
            this.button4.Location = new System.Drawing.Point(82, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(656, 70);
            this.button4.TabIndex = 26;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 61);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(746, 61);
            this.panel4.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "10:00";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AliceBlue;
            this.button1.Location = new System.Drawing.Point(82, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(656, 53);
            this.button1.TabIndex = 26;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Window;
            this.panel6.Controls.Add(this.nineLabel);
            this.panel6.Controls.Add(this.button3);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(746, 61);
            this.panel6.TabIndex = 44;
            // 
            // nineLabel
            // 
            this.nineLabel.AutoSize = true;
            this.nineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nineLabel.Location = new System.Drawing.Point(16, 18);
            this.nineLabel.Name = "nineLabel";
            this.nineLabel.Size = new System.Drawing.Size(58, 25);
            this.nineLabel.TabIndex = 27;
            this.nineLabel.Text = "9:00";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.AliceBlue;
            this.button3.Location = new System.Drawing.Point(82, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(656, 70);
            this.button3.TabIndex = 26;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // notificationsBox
            // 
            this.notificationsBox.BackColor = System.Drawing.SystemColors.Control;
            this.notificationsBox.Controls.Add(this.panel2);
            this.notificationsBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notificationsBox.Location = new System.Drawing.Point(0, 227);
            this.notificationsBox.Name = "notificationsBox";
            this.notificationsBox.Size = new System.Drawing.Size(230, 260);
            this.notificationsBox.TabIndex = 19;
            this.notificationsBox.TabStop = false;
            this.notificationsBox.Text = "Notifications";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(224, 10);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.viewUpcomingMeetingsButton);
            this.panel3.Controls.Add(this.scheduleMeetingButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 172);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(230, 55);
            this.panel3.TabIndex = 18;
            // 
            // viewUpcomingMeetingsButton
            // 
            this.viewUpcomingMeetingsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.viewUpcomingMeetingsButton.BackColor = System.Drawing.SystemColors.Control;
            this.viewUpcomingMeetingsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.viewUpcomingMeetingsButton.Location = new System.Drawing.Point(0, 23);
            this.viewUpcomingMeetingsButton.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.viewUpcomingMeetingsButton.Name = "viewUpcomingMeetingsButton";
            this.viewUpcomingMeetingsButton.Size = new System.Drawing.Size(230, 23);
            this.viewUpcomingMeetingsButton.TabIndex = 19;
            this.viewUpcomingMeetingsButton.Text = "View Upcoming meetings";
            this.viewUpcomingMeetingsButton.UseVisualStyleBackColor = true;
            this.viewUpcomingMeetingsButton.Click += new System.EventHandler(this.viewUpcomingMeetingsButton_Click);
            // 
            // scheduleMeetingButton
            // 
            this.scheduleMeetingButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.scheduleMeetingButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.scheduleMeetingButton.Location = new System.Drawing.Point(0, 0);
            this.scheduleMeetingButton.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.scheduleMeetingButton.Name = "scheduleMeetingButton";
            this.scheduleMeetingButton.Size = new System.Drawing.Size(230, 23);
            this.scheduleMeetingButton.TabIndex = 18;
            this.scheduleMeetingButton.Text = "Schedule Meeting";
            this.scheduleMeetingButton.UseVisualStyleBackColor = true;
            this.scheduleMeetingButton.Click += new System.EventHandler(this.scheduleMeetingButton_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 162);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 10);
            this.panel1.TabIndex = 9;
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Dock = System.Windows.Forms.DockStyle.Top;
            this.monthCalendar2.Location = new System.Drawing.Point(0, 0);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 533);
            this.Controls.Add(this.globalContainer);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meeting Organizer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.globalContainer.Panel1.ResumeLayout(false);
            this.globalContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.globalContainer)).EndInit();
            this.globalContainer.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.notificationsBox.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.SplitContainer globalContainer;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button viewUpcomingMeetingsButton;
        private System.Windows.Forms.Button scheduleMeetingButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox notificationsBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeNotificationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeEventToolStripMenuItem;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nineLabel;
    }
}

