namespace Calendar
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }



        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.calender = new System.Windows.Forms.MonthCalendar();
            this.timeList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.hour = new System.Windows.Forms.ComboBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showHide = new System.Windows.Forms.ToolStripMenuItem();
            this.about = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.minute = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.remove = new System.Windows.Forms.Button();
            this.doneit = new System.Windows.Forms.Button();
            this.complete = new System.Windows.Forms.Button();
            this.content = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.taskName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hideWindows = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.clean = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cleanADat = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            this.calender.AccessibleDescription = "calender";
            this.calender.AccessibleName = "calender";
            this.calender.Location = new System.Drawing.Point(23, 46);
            this.calender.Name = "calender";
            this.calender.TabIndex = 0;
            this.calender.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calender_DateChanged);
            this.timeList.AccessibleDescription = "timeList";
            this.timeList.AccessibleName = "timeList";
            this.timeList.FormattingEnabled = true;
            this.timeList.Location = new System.Drawing.Point(276, 85);
            this.timeList.Name = "timeList";
            this.timeList.Size = new System.Drawing.Size(179, 121);
            this.timeList.Sorted = true;
            this.timeList.TabIndex = 2;
            this.timeList.SelectedIndexChanged += new System.EventHandler(this.timeList_SelectedIndexChanged);
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Time:";
            this.hour.AccessibleDescription = "hour";
            this.hour.AccessibleName = "hour";
            this.hour.AutoCompleteCustomSource.AddRange(new string[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.hour.FormattingEnabled = true;
            this.hour.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.hour.Location = new System.Drawing.Point(276, 46);
            this.hour.Name = "hour";
            this.hour.Size = new System.Drawing.Size(47, 21);
            this.hour.TabIndex = 4;
            this.hour.TextChanged += new System.EventHandler(this.hour_TextChanged);
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Calendar 1.0";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showHide,
            this.cleanADat,
            this.about,
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 114);
            this.showHide.Name = "showHide";
            this.showHide.Size = new System.Drawing.Size(152, 22);
            this.showHide.Text = "Show/Hide";
            this.showHide.Click += new System.EventHandler(this.showHide_Click);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(152, 22);
            this.about.Text = "About";
            this.about.Click += new System.EventHandler(this.about_Click);
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem1.Text = "Exit";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(329, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "h";
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(388, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "m";
            this.minute.AccessibleDescription = "minute";
            this.minute.AccessibleName = "minute";
            this.minute.AutoCompleteCustomSource.AddRange(new string[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.minute.FormattingEnabled = true;
            this.minute.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.minute.Location = new System.Drawing.Point(343, 46);
            this.minute.Name = "minute";
            this.minute.Size = new System.Drawing.Size(39, 21);
            this.minute.TabIndex = 6;
            this.minute.TextChanged += new System.EventHandler(this.min_TextChanged);
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(408, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.minute);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.hour);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.timeList);
            this.groupBox1.Controls.Add(this.calender);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(25, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 223);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose date:";
            this.groupBox2.Controls.Add(this.remove);
            this.groupBox2.Controls.Add(this.doneit);
            this.groupBox2.Controls.Add(this.complete);
            this.groupBox2.Controls.Add(this.content);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.taskName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Location = new System.Drawing.Point(25, 251);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(471, 227);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add task";
            this.remove.Enabled = false;
            this.remove.Location = new System.Drawing.Point(127, 195);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(75, 23);
            this.remove.TabIndex = 13;
            this.remove.Text = "Remove";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            this.doneit.Enabled = false;
            this.doneit.Location = new System.Drawing.Point(208, 195);
            this.doneit.Name = "doneit";
            this.doneit.Size = new System.Drawing.Size(155, 23);
            this.doneit.TabIndex = 5;
            this.doneit.Text = "I have done it!";
            this.doneit.UseVisualStyleBackColor = true;
            this.doneit.Click += new System.EventHandler(this.doneit_Click);
            this.complete.Enabled = false;
            this.complete.Location = new System.Drawing.Point(371, 195);
            this.complete.Name = "complete";
            this.complete.Size = new System.Drawing.Size(75, 23);
            this.complete.TabIndex = 4;
            this.complete.Text = "Complete";
            this.complete.UseVisualStyleBackColor = true;
            this.complete.Click += new System.EventHandler(this.complete_Click);
            this.content.AccessibleDescription = "content";
            this.content.AccessibleName = "content";
            this.content.Enabled = false;
            this.content.Location = new System.Drawing.Point(41, 87);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(405, 100);
            this.content.TabIndex = 3;
            this.content.Text = "";
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Content";
            this.taskName.AccessibleDescription = "taskName";
            this.taskName.AccessibleName = "taskName";
            this.taskName.Enabled = false;
            this.taskName.Location = new System.Drawing.Point(116, 35);
            this.taskName.Name = "taskName";
            this.taskName.Size = new System.Drawing.Size(287, 20);
            this.taskName.TabIndex = 1;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Task name:";
            this.hideWindows.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.hideWindows.Location = new System.Drawing.Point(387, 528);
            this.hideWindows.Name = "hideWindows";
            this.hideWindows.Size = new System.Drawing.Size(109, 23);
            this.hideWindows.TabIndex = 11;
            this.hideWindows.Text = "Hide Windows";
            this.hideWindows.UseVisualStyleBackColor = true;
            this.hideWindows.Click += new System.EventHandler(this.hideWindows_Click);
            this.Exit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Exit.Location = new System.Drawing.Point(304, 528);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 12;
            this.Exit.Text = "Exit program";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            this.clean.Location = new System.Drawing.Point(188, 528);
            this.clean.Name = "clean";
            this.clean.Size = new System.Drawing.Size(100, 23);
            this.clean.TabIndex = 13;
            this.clean.Text = "Clean All Data";
            this.clean.UseVisualStyleBackColor = true;
            this.clean.Click += new System.EventHandler(this.clean_Click);
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.checkBox1.Location = new System.Drawing.Point(27, 496);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(318, 24);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "I allow this program to start with Windows";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.button2.Location = new System.Drawing.Point(25, 528);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "About";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            this.cleanADat.Name = "cleanADat";
            this.cleanADat.Size = new System.Drawing.Size(152, 22);
            this.cleanADat.Text = "Clean all data";
            this.cleanADat.Click += new System.EventHandler(this.cleanADat_Click);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 561);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.clean);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.hideWindows);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(540, 600);
            this.MinimumSize = new System.Drawing.Size(540, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calendar Reminder 1.0";
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.MonthCalendar calender;
        private System.Windows.Forms.ListBox timeList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox hour;
        public System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox minute;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button complete;
        private System.Windows.Forms.RichTextBox content;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox taskName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button hideWindows;
        private System.Windows.Forms.ToolStripMenuItem showHide;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button doneit;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button clean;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem about;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem cleanADat;
    }
}

