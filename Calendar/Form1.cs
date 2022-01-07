using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Calendar
{

    public partial class Form1 : Form
    {
        private List<Task> data;
        private string userName;
        private string path;
        private bool isHide;
        private int times;
        private DateTime point;
        private bool bg;
        private RegistryKey rkApp;

        public Form1()
        {
            this.bg = false;
            string usr = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            string[] usrtmp = usr.Split('\\');

            if(usrtmp.Length>=2)
                this.userName =  usrtmp[usrtmp.Length-1];
            else
                this.userName = usr;

            this.path = "C:\\Documents and Settings\\" + this.userName + "\\Local Settings\\";

            

                InitializeComponent();




                data = new List<Task>();
                this.times = 0;
                this.point = DateTime.Now;
                this.ContextMenuStrip = this.contextMenuStrip1;
                this.isHide = false;
                this.notifyIcon1.Visible = true;
                this.readData();
                this.rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                if (this.rkApp.GetValue("Calendar Reminder 1.0") != null)
                {
                    this.checkBox1.Checked = true;
                }
                else
                    this.checkBox1.Checked = false;

                this.timer1.Tick += this.timer1_Tick;
                this.timer1.Start();
                this.bg = true;
                this.Click += this.Form1_Rightclick;
                this.Activated += this.Form1_Activated;
                this.Deactivate += this.Form1_Deactivated;
                this.Leave += this.Form1_Leave;*/

        }


.
        private void readData()
        {
            if (System.IO.File.Exists( this.path + this.userName + "_CalUserData.dat"))
            {
                string[] lines = System.IO.File.ReadAllLines( this.path + this.userName + "_CalUserData.dat");
                int c = lines.Length;
                for (int i = 0; i < c; i++)
                {
                    string[] tmp = lines[i].Split('|');

                    try
                    {
                        DateTime date = DateTime.Parse(tmp[0]);
                        string name = tmp[2];
                        bool done = true;
                        if (tmp[1] == "False")
                            done = false;
                        string content = null;
                        int l = tmp.Length;
                        if (l == 4)
                            content = tmp[3];
                        else
                        {
                            List<string> tmp2 = new List<string>();
                            for (int j = 2; j < l; j++)
                            {
                                tmp2.Add(tmp[j]);



                            }
                            content = string.Join("|", tmp2.ToArray());
                        }

                        Task t = new Task(date, name, content);
                        t.setDone(done);
                        this.data.Add(t);
                    }
                    catch { }
                    
                    /*if (this.bg == false)
                    {
                        this.backgroundWorker1.RunWorkerAsync(2000);
                        this.bg = true;
                    }*/
                }

                this.clearTimeList();

            }
        }

        
        private void hour_TextChanged(object sender, EventArgs e)
        {
            int gHour = this.getHour();
            if (gHour > 23 || gHour < 0)
                MessageBox.Show("INVALID. Hour must be between 0 - 23.", "ERROR!");
        }


        private void min_TextChanged(object sender, EventArgs e)
        {
            int gMin = this.getMin();
            if (gMin > 59 || gMin<0)
                MessageBox.Show("INVALID. Min must be between 0 - 59.", "ERROR!");
        }

        public int getMin()
        {
            int r = 0;
            string data = minute.Text.ToString();
            if (data != "")
                try
                {
                    r = int.Parse(data.ToString());
                }
                catch { }

            return r;
        }

        public int getHour()
        {
            int r = 0;
            string data = hour.Text.ToString();
            if (data != "")
                try
                {
                    r = int.Parse(data.ToString());
                }
                catch { }

            return r;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int h = this.getHour();
            int m = this.getMin();
            if (h >= 0 && h < 24 && m >= 0 && m < 60)
            {
                string date = this.calender.SelectionStart.Date.ToShortDateString().ToString() ;
                string anew = date + " " + h.ToString() + ":" + m.ToString() + ":00";
                anew = DateTime.Parse(anew).ToString();
                DateTime cdate = DateTime.Parse(anew);
                Task tmp0 = this.getTaskByExaclyTime(DateTime.Parse(anew));
                if ((tmp0==null)&&cdate.CompareTo(DateTime.Now)>=0)
                {
                    this.timeList.Items.Add(anew);
                    Task tmp = new Task(DateTime.Parse(anew), " ", " ");
                    this.data.Add(tmp);
                    this.clearTimeList();
                }
                else
                    MessageBox.Show("DATA EXISTED or YOUR DATE TIME IS EARLIER THAN CURRENT DATE TIME.", "ERROR!");
            }
            else
                MessageBox.Show("INVALID HOUR AND MIN. COULD NOT ADD TASK", "ERROR!");

        }


       
        

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            if (this.isHide == true)
            {
                this.isHide = false;
            }
            else
            {
                this.Activate();
            }
        }


        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.exit();
        }

        private void hideWindows_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.isHide = true;

        }

        private void showHide_Click(object sender, EventArgs e)
        {
            if (isHide == true)
            {
                isHide = false;
                this.Visible = true;
            }
            else
            {

                this.Visible = false;
                this.isHide = true;
            }
        }

        private void writeData()
        {
            List<string> lines = new List<string>();
            int n = this.data.Count;
            for (int i = 0; i < n; i++)
            {
                lines.Add(this.data[i].getDataLine());

            }

            System.IO.File.WriteAllLines( this.path  + this.userName + "_CalUserData.dat", lines.ToArray());

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.exit();
            
        }

        private void exit()
        {
            
            this.Close();
        }

        private void calender_DateChanged(object sender, DateRangeEventArgs e)
        {
            string data = this.calender.Handle.ToString();
            this.calender.SelectionStart = e.End;

            this.clearTimeList();
            
        }

        private void clearTimeList()
        {
            this.timeList.Items.Clear();
            List<Task> tmp = this.getTask(DateTime.Parse(this.calender.SelectionStart.ToString()));
            int c = tmp.Count;
            if (c == 0)
            {
                this.timeList.Items.Clear();
            }

            for (int i = 0; i < c; i++)
            {
                this.timeList.Items.Add(tmp[i].getFullTitle());
            }
            this.doneit.Enabled = false;
            this.remove.Enabled = false;
            this.taskName.Clear();
            this.content.Clear();
        }


        private List<Task> getTask(DateTime value)
        {
            DateTime date = DateTime.Parse(value.ToShortDateString());
            List<Task> result = new List<Task>();
            int n = this.data.Count;

            for (int i = 0; i < n; i++)
            {
                DateTime tmp = DateTime.Parse(this.data[i].getDate().ToShortDateString());

                
                if (tmp.CompareTo(date)==0)
                {
                    result.Add( this.data[i] );
                }
            }

            return result;
        }

        private Task getTaskByTime(DateTime value)
        {
            DateTime date = DateTime.Parse(value.ToShortDateString());
            Task result = null;
            int n = this.data.Count;

            for (int i = 0; i < n; i++)
            {
                DateTime tmp = DateTime.Parse(this.data[i].getDate().ToShortDateString());

                if (tmp.CompareTo(date) == 0)
                {
                    result = this.data[i];
                }
            }

            return result;
        }

        private Task getTaskByExaclyTime(DateTime value)
        {
            DateTime date = value;
            Task result = null;
            int n = this.data.Count;

            for (int i = 0; i < n; i++)
            {
                DateTime tmp = DateTime.Parse(this.data[i].getDate().ToString());

                if (tmp.CompareTo(date) == 0)
                {
                    result = this.data[i];
                }
            }

            return result;
        }

        private List<Task> getTask2(DateTime value)
        {
            DateTime date = value;
            List<Task> result = new List<Task>();
            int n = this.data.Count;

            for (int i = 0; i < n; i++)
            {
                DateTime tmp = this.data[i].getDate();

                if (tmp.CompareTo(date) == 0)
                {
                    
                    result.Add(this.data[i]);
                }
            }

            return result;
        }

        private Task getTask3(string value)
        {
            int n = this.data.Count;
            Task result = null;

            for (int i = 0; i < n; i++)
            {
                if (this.data[i].getFullTitle() == value)
                    return data[i];
            }

            return result;
        }



        private void complete_Click(object sender, EventArgs e)
        {
            string get = this.timeList.SelectedItem.ToString();
            string name = this.taskName.Text.ToString();
            string content = this.content.Text.ToString();
            Task tmp = getTaskByTime(DateTime.Parse(get));
            tmp.setName(name);
            tmp.setContent(content);
            Task tmp2 = this.getTask3(tmp.getFullTitle());
            if (tmp2 != null)
            {
                MessageBox.Show("Data's written!" , "MESSAGE");
                this.writeData();
                

                
            } 
            this.taskName.Enabled = false;
            this.content.Enabled = false;
            this.complete.Enabled = false;
            this.taskName.Clear();
            this.content.Clear();
            this.timeList.Items.Remove(get);
            this.timeList.Items.Add(tmp.getFullTitle());
            if (this.bg == false)
            {

                this.bg = true;
            }
            
        }
        


        private void timeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                List<Task> tmp = this.getTask2(DateTime.Parse(this.timeList.SelectedItem.ToString()));
                int c = tmp.Count;
                if (c==1)
                {
                    this.taskName.Enabled = true;
                    this.content.Enabled = true;
                    this.complete.Enabled = true;
                    this.remove.Enabled = true;
                }
            }
            catch
            {
                this.taskName.Clear();
                this.content.Clear();
                try
                {
                    Task tmp = this.getTask3(this.timeList.SelectedItem.ToString());
                    this.taskName.AppendText(tmp.getName());
                    this.content.AppendText(tmp.getContent());
                    if (tmp.isDone() == false)
                    {
                        this.doneit.Enabled = true;
                        
                    }
                    this.remove.Enabled = true;
                }
                catch
                {
                    this.remove.Enabled = true;
                }
            }

            
        }

        private void doneit_Click(object sender, EventArgs e)
        {
            Task tmp = this.getTask3(this.timeList.SelectedItem.ToString());
            tmp.setDone(true);
            this.doneit.Enabled = false;
            this.times = 0;
            this.writeData();
            
        }

        /*private System.ComponentModel.BackgroundWorker backgroundWorker1;

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            // Do not access the form's BackgroundWorker reference directly. 
            // Instead, use the reference provided by the sender parameter.
            BackgroundWorker bw = sender as BackgroundWorker;

            // Extract the argument. 
            int arg = (int)e.Argument;

            // Start the time-consuming operation.
            e.Result = TimeConsumingOperation(bw, arg);

            // If the operation was canceled by the user,  
            // set the DoWorkEventArgs.Cancel property to true. 
            if (bw.CancellationPending)
            {
                e.Cancel = true;
            }
        }*/

        private List<Task> getTaskInTime(DateTime date)
        {
            List<Task> result = new List<Task>();
            int n = this.data.Count;

            for (int i = 0; i < n; i++)
            {
                DateTime tmp = this.data[i].getDate();
                


                if ((tmp.CompareTo(date.AddSeconds(4)) <= 0 && this.data[i].isDone() == false
                        || this.data[i].isDone() == false && tmp.CompareTo(date) <= 0)
                    && result.IndexOf(this.data[i]) < 0)
                {
                    result.Add(this.data[i]);
                }
            }

            return result;
        }

        private void remove_Click(object sender, EventArgs e)
        {
            if (this.bg == true)
            {
                this.bg = false;
            }
            string m = this.timeList.SelectedItem.ToString();
            Task itm = this.getTask3(m);
            this.data.Remove(itm);
            this.clearTimeList();
            this.remove.Enabled = false;
            this.taskName.Enabled = false;
            this.content.Enabled = false;
            this.complete.Enabled = false;
            this.writeData();

        }

        private void clean_Click(object sender, EventArgs e)
        {
            this.cleanAllData();
        }

        private void cleanAllData()
        {
            int n = this.data.Count;
            if (n > 0)
            {

                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show("Are you sure to delete ALL YOUR DATA?", "QUESTION", buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {

                    if (System.IO.File.Exists(this.path + this.userName + "_CalUserData.dat"))
                    {
                        System.IO.File.Delete(this.path + this.userName + "_CalUserData.dat");
                    }
                    this.data.Clear();
                    this.clearTimeList();
                    MessageBox.Show("Done cleaning...", "Message");
                }
            }
            else
            {
                MessageBox.Show("You have nothing to delete!", "Message");

            }
        }

        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        { 


            if (this.checkBox1.Checked == true)
            {
                if (this.rkApp.GetValue("Calendar Reminder 1.0") == null)
                {
                    this.writeData();
                    this.rkApp.SetValue("Calendar Reminder 1.0", Application.ExecutablePath.ToString());
                }
            }
            else
            {
                if (this.rkApp.GetValue("Calendar Reminder 1.0") != null)
                {
                    this.rkApp.DeleteValue("Calendar Reminder 1.0", false);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AboutBox1 box = new AboutBox1();
            box.Show();
        }

        private void about_Click(object sender, EventArgs e)
        {
            AboutBox1 box = new AboutBox1();
            box.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            Random rand = new Random();
            string mess = "";


            List<Task> data2 = this.getTaskInTime(DateTime.Now);
            int n = data2.Count;
            bool check0 = false;

            if (this.times >= n*5)
            {
                if (this.point.AddSeconds(60).CompareTo(DateTime.Now) <= 0)
                {
                    this.times = 0;
                    this.point = DateTime.Now;
                    check0 = false;
                }
                else check0 = true;

            }

            for (int i = 0; i < n && check0 == false; i++)
            {

                DateTime tmp = data2[i].getDate();
                if (data2[i].isDone())
                {

                    continue;
                }


                if (tmp.CompareTo(DateTime.Now) <= 0 && this.times < n*5 && !data2[i].isDone()
                    && data2[i].getName() != " ")
                {
                    this.point = DateTime.Now;

                    mess = "YOU SHOULD DO A TASK!\n";
                    mess += data2[i].getFullTitle() + "\n";
                    mess += "CONTENT: \n" + data[i].getContent();

                    MessageBox.Show(mess, "DO A TASK");

                    this.times++;

                }
            }
        }

        private void cleanADat_Click(object sender, EventArgs e)
        {
            this.cleanAllData();
        }



    }
}
