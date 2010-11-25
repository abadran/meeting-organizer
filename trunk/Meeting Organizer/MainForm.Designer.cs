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
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.globalContainer = new System.Windows.Forms.SplitContainer();
            this.eventPanel = new System.Windows.Forms.Panel();
            this.fourPanel = new System.Windows.Forms.Panel();
            this.fourLabel = new System.Windows.Forms.Label();
            this.threePanel = new System.Windows.Forms.Panel();
            this.threeLabel = new System.Windows.Forms.Label();
            this.twoPanel = new System.Windows.Forms.Panel();
            this.twoLabel = new System.Windows.Forms.Label();
            this.onePanel = new System.Windows.Forms.Panel();
            this.oneLabel = new System.Windows.Forms.Label();
            this.twelvePanel = new System.Windows.Forms.Panel();
            this.twelveLabel = new System.Windows.Forms.Label();
            this.elevenPanel = new System.Windows.Forms.Panel();
            this.elevenLabel = new System.Windows.Forms.Label();
            this.tenPanel = new System.Windows.Forms.Panel();
            this.tenLabel = new System.Windows.Forms.Label();
            this.ninePanel = new System.Windows.Forms.Panel();
            this.nineLabel = new System.Windows.Forms.Label();
            this.notificationsBox = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.viewUpcomingMeetingsButton = new System.Windows.Forms.Button();
            this.scheduleMeetingButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.menuStrip1.SuspendLayout();
            this.statusBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.globalContainer)).BeginInit();
            this.globalContainer.Panel1.SuspendLayout();
            this.globalContainer.Panel2.SuspendLayout();
            this.globalContainer.SuspendLayout();
            this.fourPanel.SuspendLayout();
            this.threePanel.SuspendLayout();
            this.twoPanel.SuspendLayout();
            this.onePanel.SuspendLayout();
            this.twelvePanel.SuspendLayout();
            this.elevenPanel.SuspendLayout();
            this.tenPanel.SuspendLayout();
            this.ninePanel.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(982, 24);
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
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusBar.Location = new System.Drawing.Point(0, 503);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(982, 22);
            this.statusBar.TabIndex = 3;
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
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
            this.globalContainer.Panel1.Controls.Add(this.eventPanel);
            this.globalContainer.Panel1.Controls.Add(this.fourPanel);
            this.globalContainer.Panel1.Controls.Add(this.threePanel);
            this.globalContainer.Panel1.Controls.Add(this.twoPanel);
            this.globalContainer.Panel1.Controls.Add(this.onePanel);
            this.globalContainer.Panel1.Controls.Add(this.twelvePanel);
            this.globalContainer.Panel1.Controls.Add(this.elevenPanel);
            this.globalContainer.Panel1.Controls.Add(this.tenPanel);
            this.globalContainer.Panel1.Controls.Add(this.ninePanel);
            // 
            // globalContainer.Panel2
            // 
            this.globalContainer.Panel2.Controls.Add(this.notificationsBox);
            this.globalContainer.Panel2.Controls.Add(this.panel3);
            this.globalContainer.Panel2.Controls.Add(this.panel1);
            this.globalContainer.Panel2.Controls.Add(this.calendar);
            this.globalContainer.Size = new System.Drawing.Size(982, 479);
            this.globalContainer.SplitterDistance = 747;
            this.globalContainer.TabIndex = 5;
            // 
            // eventPanel
            // 
            this.eventPanel.BackColor = System.Drawing.Color.Transparent;
            this.eventPanel.Location = new System.Drawing.Point(99, 0);
            this.eventPanel.Name = "eventPanel";
            this.eventPanel.Size = new System.Drawing.Size(646, 480);
            this.eventPanel.TabIndex = 52;
            // 
            // fourPanel
            // 
            this.fourPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fourPanel.Controls.Add(this.fourLabel);
            this.fourPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.fourPanel.Location = new System.Drawing.Point(0, 420);
            this.fourPanel.Name = "fourPanel";
            this.fourPanel.Size = new System.Drawing.Size(747, 60);
            this.fourPanel.TabIndex = 59;
            // 
            // fourLabel
            // 
            this.fourLabel.AutoSize = true;
            this.fourLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourLabel.Location = new System.Drawing.Point(16, 18);
            this.fourLabel.Name = "fourLabel";
            this.fourLabel.Size = new System.Drawing.Size(58, 25);
            this.fourLabel.TabIndex = 34;
            this.fourLabel.Text = "4:00";
            // 
            // threePanel
            // 
            this.threePanel.BackColor = System.Drawing.SystemColors.Window;
            this.threePanel.Controls.Add(this.threeLabel);
            this.threePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.threePanel.Location = new System.Drawing.Point(0, 360);
            this.threePanel.Name = "threePanel";
            this.threePanel.Size = new System.Drawing.Size(747, 60);
            this.threePanel.TabIndex = 58;
            // 
            // threeLabel
            // 
            this.threeLabel.AutoSize = true;
            this.threeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threeLabel.Location = new System.Drawing.Point(16, 18);
            this.threeLabel.Name = "threeLabel";
            this.threeLabel.Size = new System.Drawing.Size(58, 25);
            this.threeLabel.TabIndex = 33;
            this.threeLabel.Text = "3:00";
            // 
            // twoPanel
            // 
            this.twoPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.twoPanel.Controls.Add(this.twoLabel);
            this.twoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.twoPanel.Location = new System.Drawing.Point(0, 300);
            this.twoPanel.Name = "twoPanel";
            this.twoPanel.Size = new System.Drawing.Size(747, 60);
            this.twoPanel.TabIndex = 57;
            // 
            // twoLabel
            // 
            this.twoLabel.AutoSize = true;
            this.twoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twoLabel.Location = new System.Drawing.Point(16, 18);
            this.twoLabel.Name = "twoLabel";
            this.twoLabel.Size = new System.Drawing.Size(58, 25);
            this.twoLabel.TabIndex = 32;
            this.twoLabel.Text = "2:00";
            // 
            // onePanel
            // 
            this.onePanel.BackColor = System.Drawing.SystemColors.Window;
            this.onePanel.Controls.Add(this.oneLabel);
            this.onePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.onePanel.Location = new System.Drawing.Point(0, 240);
            this.onePanel.Name = "onePanel";
            this.onePanel.Size = new System.Drawing.Size(747, 60);
            this.onePanel.TabIndex = 56;
            // 
            // oneLabel
            // 
            this.oneLabel.AutoSize = true;
            this.oneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneLabel.Location = new System.Drawing.Point(16, 18);
            this.oneLabel.Name = "oneLabel";
            this.oneLabel.Size = new System.Drawing.Size(58, 25);
            this.oneLabel.TabIndex = 31;
            this.oneLabel.Text = "1:00";
            // 
            // twelvePanel
            // 
            this.twelvePanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.twelvePanel.Controls.Add(this.twelveLabel);
            this.twelvePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.twelvePanel.Location = new System.Drawing.Point(0, 180);
            this.twelvePanel.Name = "twelvePanel";
            this.twelvePanel.Size = new System.Drawing.Size(747, 60);
            this.twelvePanel.TabIndex = 55;
            // 
            // twelveLabel
            // 
            this.twelveLabel.AutoSize = true;
            this.twelveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twelveLabel.Location = new System.Drawing.Point(3, 18);
            this.twelveLabel.Name = "twelveLabel";
            this.twelveLabel.Size = new System.Drawing.Size(71, 25);
            this.twelveLabel.TabIndex = 30;
            this.twelveLabel.Text = "12:00";
            // 
            // elevenPanel
            // 
            this.elevenPanel.BackColor = System.Drawing.SystemColors.Window;
            this.elevenPanel.Controls.Add(this.elevenLabel);
            this.elevenPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.elevenPanel.Location = new System.Drawing.Point(0, 120);
            this.elevenPanel.Name = "elevenPanel";
            this.elevenPanel.Size = new System.Drawing.Size(747, 60);
            this.elevenPanel.TabIndex = 54;
            // 
            // elevenLabel
            // 
            this.elevenLabel.AutoSize = true;
            this.elevenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elevenLabel.Location = new System.Drawing.Point(3, 18);
            this.elevenLabel.Name = "elevenLabel";
            this.elevenLabel.Size = new System.Drawing.Size(71, 25);
            this.elevenLabel.TabIndex = 29;
            this.elevenLabel.Text = "11:00";
            // 
            // tenPanel
            // 
            this.tenPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tenPanel.Controls.Add(this.tenLabel);
            this.tenPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tenPanel.Location = new System.Drawing.Point(0, 60);
            this.tenPanel.Name = "tenPanel";
            this.tenPanel.Size = new System.Drawing.Size(747, 60);
            this.tenPanel.TabIndex = 53;
            // 
            // tenLabel
            // 
            this.tenLabel.AutoSize = true;
            this.tenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenLabel.Location = new System.Drawing.Point(3, 18);
            this.tenLabel.Name = "tenLabel";
            this.tenLabel.Size = new System.Drawing.Size(71, 25);
            this.tenLabel.TabIndex = 28;
            this.tenLabel.Text = "10:00";
            // 
            // ninePanel
            // 
            this.ninePanel.BackColor = System.Drawing.SystemColors.Window;
            this.ninePanel.Controls.Add(this.nineLabel);
            this.ninePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ninePanel.Location = new System.Drawing.Point(0, 0);
            this.ninePanel.Name = "ninePanel";
            this.ninePanel.Size = new System.Drawing.Size(747, 60);
            this.ninePanel.TabIndex = 44;
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
            // notificationsBox
            // 
            this.notificationsBox.BackColor = System.Drawing.SystemColors.Control;
            this.notificationsBox.Controls.Add(this.panel2);
            this.notificationsBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notificationsBox.Location = new System.Drawing.Point(0, 227);
            this.notificationsBox.Name = "notificationsBox";
            this.notificationsBox.Size = new System.Drawing.Size(231, 252);
            this.notificationsBox.TabIndex = 19;
            this.notificationsBox.TabStop = false;
            this.notificationsBox.Text = "Notifications";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 10);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.viewUpcomingMeetingsButton);
            this.panel3.Controls.Add(this.scheduleMeetingButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 172);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(231, 55);
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
            this.viewUpcomingMeetingsButton.Size = new System.Drawing.Size(231, 23);
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
            this.scheduleMeetingButton.Size = new System.Drawing.Size(231, 23);
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
            this.panel1.Size = new System.Drawing.Size(231, 10);
            this.panel1.TabIndex = 9;
            // 
            // calendar
            // 
            this.calendar.Dock = System.Windows.Forms.DockStyle.Top;
            this.calendar.Location = new System.Drawing.Point(0, 0);
            this.calendar.MaxSelectionCount = 1;
            this.calendar.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.calendar.Name = "calendar";
            this.calendar.TabIndex = 8;
            this.calendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendar_DateChanged);
            this.calendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calendar_DateSelected);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 525);
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
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.globalContainer.Panel1.ResumeLayout(false);
            this.globalContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.globalContainer)).EndInit();
            this.globalContainer.ResumeLayout(false);
            this.fourPanel.ResumeLayout(false);
            this.fourPanel.PerformLayout();
            this.threePanel.ResumeLayout(false);
            this.threePanel.PerformLayout();
            this.twoPanel.ResumeLayout(false);
            this.twoPanel.PerformLayout();
            this.onePanel.ResumeLayout(false);
            this.onePanel.PerformLayout();
            this.twelvePanel.ResumeLayout(false);
            this.twelvePanel.PerformLayout();
            this.elevenPanel.ResumeLayout(false);
            this.elevenPanel.PerformLayout();
            this.tenPanel.ResumeLayout(false);
            this.tenPanel.PerformLayout();
            this.ninePanel.ResumeLayout(false);
            this.ninePanel.PerformLayout();
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
        private System.Windows.Forms.MonthCalendar calendar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button viewUpcomingMeetingsButton;
        private System.Windows.Forms.Button scheduleMeetingButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox notificationsBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel ninePanel;
        private System.Windows.Forms.Label nineLabel;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Panel eventPanel;
        private System.Windows.Forms.Panel fourPanel;
        private System.Windows.Forms.Label fourLabel;
        private System.Windows.Forms.Panel threePanel;
        private System.Windows.Forms.Label threeLabel;
        private System.Windows.Forms.Panel twoPanel;
        private System.Windows.Forms.Label twoLabel;
        private System.Windows.Forms.Panel onePanel;
        private System.Windows.Forms.Label oneLabel;
        private System.Windows.Forms.Panel twelvePanel;
        private System.Windows.Forms.Label twelveLabel;
        private System.Windows.Forms.Panel elevenPanel;
        private System.Windows.Forms.Label elevenLabel;
        private System.Windows.Forms.Panel tenPanel;
        private System.Windows.Forms.Label tenLabel;
    }
}

