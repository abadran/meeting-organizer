﻿namespace Meeting_Organizer
{
    partial class InvitationDetails
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
            if (disposing && (components != null)) {
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
            this.closeButton = new System.Windows.Forms.Button();
            this.declineButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.timingBox = new System.Windows.Forms.GroupBox();
            this.dateTime = new System.Windows.Forms.TextBox();
            this.duration = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.durationLabel = new System.Windows.Forms.Label();
            this.startLabel = new System.Windows.Forms.Label();
            this.attendeeBox = new System.Windows.Forms.GroupBox();
            this.attendeesTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.fromTextBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.titleBox = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.reasonsBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.timingBox.SuspendLayout();
            this.attendeeBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.titleBox.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(79, 376);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "&Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // declineButton
            // 
            this.declineButton.Location = new System.Drawing.Point(471, 376);
            this.declineButton.Name = "declineButton";
            this.declineButton.Size = new System.Drawing.Size(75, 23);
            this.declineButton.TabIndex = 1;
            this.declineButton.Text = "&Decline";
            this.declineButton.UseVisualStyleBackColor = true;
            this.declineButton.Click += new System.EventHandler(this.declineButton_Click);
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(621, 376);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(75, 23);
            this.acceptButton.TabIndex = 2;
            this.acceptButton.Text = "&Accept";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // timingBox
            // 
            this.timingBox.Controls.Add(this.dateTime);
            this.timingBox.Controls.Add(this.duration);
            this.timingBox.Controls.Add(this.label3);
            this.timingBox.Controls.Add(this.durationLabel);
            this.timingBox.Controls.Add(this.startLabel);
            this.timingBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.timingBox.Location = new System.Drawing.Point(0, 99);
            this.timingBox.Name = "timingBox";
            this.timingBox.Size = new System.Drawing.Size(776, 61);
            this.timingBox.TabIndex = 4;
            this.timingBox.TabStop = false;
            // 
            // dateTime
            // 
            this.dateTime.BackColor = System.Drawing.SystemColors.Window;
            this.dateTime.Location = new System.Drawing.Point(66, 8);
            this.dateTime.Name = "dateTime";
            this.dateTime.ReadOnly = true;
            this.dateTime.Size = new System.Drawing.Size(199, 20);
            this.dateTime.TabIndex = 24;
            // 
            // duration
            // 
            this.duration.BackColor = System.Drawing.SystemColors.Window;
            this.duration.Location = new System.Drawing.Point(68, 33);
            this.duration.Name = "duration";
            this.duration.ReadOnly = true;
            this.duration.Size = new System.Drawing.Size(47, 20);
            this.duration.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "hours";
            // 
            // durationLabel
            // 
            this.durationLabel.AutoSize = true;
            this.durationLabel.Location = new System.Drawing.Point(10, 37);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(47, 13);
            this.durationLabel.TabIndex = 20;
            this.durationLabel.Text = "Duration";
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Location = new System.Drawing.Point(10, 12);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(55, 13);
            this.startLabel.TabIndex = 19;
            this.startLabel.Text = "Start Time";
            // 
            // attendeeBox
            // 
            this.attendeeBox.Controls.Add(this.attendeesTextBox);
            this.attendeeBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.attendeeBox.Location = new System.Drawing.Point(0, 160);
            this.attendeeBox.Name = "attendeeBox";
            this.attendeeBox.Size = new System.Drawing.Size(776, 65);
            this.attendeeBox.TabIndex = 5;
            this.attendeeBox.TabStop = false;
            this.attendeeBox.Text = "Invitees";
            // 
            // attendeesTextBox
            // 
            this.attendeesTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.attendeesTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attendeesTextBox.Location = new System.Drawing.Point(3, 16);
            this.attendeesTextBox.Multiline = true;
            this.attendeesTextBox.Name = "attendeesTextBox";
            this.attendeesTextBox.ReadOnly = true;
            this.attendeesTextBox.Size = new System.Drawing.Size(770, 46);
            this.attendeesTextBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.descriptionTextBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 225);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 78);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Description";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.descriptionTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionTextBox.Location = new System.Drawing.Point(3, 16);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.Size = new System.Drawing.Size(770, 59);
            this.descriptionTextBox.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.fromTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 24);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "From";
            // 
            // fromTextBox
            // 
            this.fromTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fromTextBox.Location = new System.Drawing.Point(63, 3);
            this.fromTextBox.Name = "fromTextBox";
            this.fromTextBox.ReadOnly = true;
            this.fromTextBox.Size = new System.Drawing.Size(199, 20);
            this.fromTextBox.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(770, 8);
            this.panel3.TabIndex = 6;
            // 
            // titleBox
            // 
            this.titleBox.Controls.Add(this.panel2);
            this.titleBox.Controls.Add(this.panel3);
            this.titleBox.Controls.Add(this.panel1);
            this.titleBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBox.Location = new System.Drawing.Point(0, 0);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(776, 99);
            this.titleBox.TabIndex = 3;
            this.titleBox.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.titleTextBox);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(770, 48);
            this.panel2.TabIndex = 11;
            // 
            // titleTextBox
            // 
            this.titleTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.titleTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.titleTextBox.Location = new System.Drawing.Point(63, 0);
            this.titleTextBox.Multiline = true;
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.ReadOnly = true;
            this.titleTextBox.Size = new System.Drawing.Size(707, 48);
            this.titleTextBox.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(63, 48);
            this.panel4.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Title";
            // 
            // reasonsBox
            // 
            this.reasonsBox.Location = new System.Drawing.Point(0, 17);
            this.reasonsBox.Multiline = true;
            this.reasonsBox.Name = "reasonsBox";
            this.reasonsBox.Size = new System.Drawing.Size(767, 38);
            this.reasonsBox.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.reasonsBox);
            this.groupBox2.Location = new System.Drawing.Point(3, 309);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(773, 61);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reasons";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter_1);
            // 
            // InvitationDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 411);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.attendeeBox);
            this.Controls.Add(this.timingBox);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.declineButton);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "InvitationDetails";
            this.Text = "Invitation Details";
            this.timingBox.ResumeLayout(false);
            this.timingBox.PerformLayout();
            this.attendeeBox.ResumeLayout(false);
            this.attendeeBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.titleBox.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button declineButton;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.GroupBox timingBox;
        private System.Windows.Forms.GroupBox attendeeBox;
        private System.Windows.Forms.TextBox duration;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label durationLabel;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.TextBox attendeesTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fromTextBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox titleBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox dateTime;
        private System.Windows.Forms.TextBox reasonsBox;
        private System.Windows.Forms.GroupBox groupBox2;

    }
}