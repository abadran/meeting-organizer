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
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.globalContainer = new System.Windows.Forms.SplitContainer();
            this.makeEvent = new System.Windows.Forms.Button();
            this.makeNotification = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.menuStrip1.Size = new System.Drawing.Size(1015, 24);
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
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
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
            this.statusBar.Location = new System.Drawing.Point(0, 555);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(1015, 22);
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
            this.globalContainer.Panel1.Controls.Add(this.makeEvent);
            this.globalContainer.Panel1.Controls.Add(this.makeNotification);
            this.globalContainer.Panel1.Controls.Add(this.textBox6);
            this.globalContainer.Panel1.Controls.Add(this.textBox7);
            this.globalContainer.Panel1.Controls.Add(this.textBox9);
            this.globalContainer.Panel1.Controls.Add(this.textBox10);
            this.globalContainer.Panel1.Controls.Add(this.textBox8);
            this.globalContainer.Panel1.Controls.Add(this.textBox5);
            this.globalContainer.Panel1.Controls.Add(this.textBox3);
            this.globalContainer.Panel1.Controls.Add(this.textBox2);
            this.globalContainer.Panel1.Controls.Add(this.textBox1);
            // 
            // globalContainer.Panel2
            // 
            this.globalContainer.Panel2.Controls.Add(this.notificationsBox);
            this.globalContainer.Panel2.Controls.Add(this.panel3);
            this.globalContainer.Panel2.Controls.Add(this.panel1);
            this.globalContainer.Panel2.Controls.Add(this.monthCalendar2);
            this.globalContainer.Size = new System.Drawing.Size(1015, 531);
            this.globalContainer.SplitterDistance = 781;
            this.globalContainer.TabIndex = 5;
            // 
            // makeEvent
            // 
            this.makeEvent.Location = new System.Drawing.Point(431, 445);
            this.makeEvent.Name = "makeEvent";
            this.makeEvent.Size = new System.Drawing.Size(189, 23);
            this.makeEvent.TabIndex = 13;
            this.makeEvent.Text = "test make event";
            this.makeEvent.UseVisualStyleBackColor = true;
            this.makeEvent.Click += new System.EventHandler(this.makeEvent_Click);
            // 
            // makeNotification
            // 
            this.makeNotification.Location = new System.Drawing.Point(185, 445);
            this.makeNotification.Name = "makeNotification";
            this.makeNotification.Size = new System.Drawing.Size(156, 23);
            this.makeNotification.TabIndex = 12;
            this.makeNotification.Text = "test make notification";
            this.makeNotification.UseVisualStyleBackColor = true;
            this.makeNotification.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox6.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(0, 336);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(781, 42);
            this.textBox6.TabIndex = 11;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.Info;
            this.textBox7.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox7.Enabled = false;
            this.textBox7.Location = new System.Drawing.Point(0, 294);
            this.textBox7.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(781, 42);
            this.textBox7.TabIndex = 10;
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox9.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox9.Enabled = false;
            this.textBox9.Location = new System.Drawing.Point(0, 252);
            this.textBox9.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(781, 42);
            this.textBox9.TabIndex = 9;
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.SystemColors.Info;
            this.textBox10.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox10.Enabled = false;
            this.textBox10.Location = new System.Drawing.Point(0, 210);
            this.textBox10.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(781, 42);
            this.textBox10.TabIndex = 8;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox8.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox8.Enabled = false;
            this.textBox8.Location = new System.Drawing.Point(0, 168);
            this.textBox8.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(781, 42);
            this.textBox8.TabIndex = 7;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Info;
            this.textBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(0, 126);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(781, 42);
            this.textBox5.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(0, 84);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(781, 42);
            this.textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Info;
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(0, 42);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(781, 42);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(781, 42);
            this.textBox1.TabIndex = 0;
            // 
            // notificationsBox
            // 
            this.notificationsBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.notificationsBox.Controls.Add(this.panel2);
            this.notificationsBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notificationsBox.Location = new System.Drawing.Point(0, 227);
            this.notificationsBox.Name = "notificationsBox";
            this.notificationsBox.Size = new System.Drawing.Size(230, 304);
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
            this.viewUpcomingMeetingsButton.UseVisualStyleBackColor = false;
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
            this.ClientSize = new System.Drawing.Size(1015, 577);
            this.Controls.Add(this.globalContainer);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meeting Organizer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.globalContainer.Panel1.ResumeLayout(false);
            this.globalContainer.Panel1.PerformLayout();
            this.globalContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.globalContainer)).EndInit();
            this.globalContainer.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button makeNotification;
        private System.Windows.Forms.Button makeEvent;
    }
}

