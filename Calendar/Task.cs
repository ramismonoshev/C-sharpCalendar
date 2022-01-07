using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calendar
{
    class Task
    {
        private DateTime date;
        private string taskName;
        private string content;
        private bool done;

        public Task()
        {
            date = DateTime.Now;
            taskName = " ";
            content = " ";
            done = false;
        }

        public Task(DateTime date, string name, string content)
        {
            this.setDate(date);
            this.setName(name);
            this.setContent(content);
            this.done = false;
        }

        public string getDataLine()
        {
            string result = this.date.ToString();
            result += "|";
            result += this.done.ToString();
            result += "|";
            result += this.taskName;
            result += "|";
            result += this.content;

            return result;

        }

        public bool isDone()
        {
            return this.done;
        }

        public string getFullTitle()
        {
            string r = this.date.ToString();
            if(this.taskName!=" ")
                r +=  " - " + this.taskName;
            return r;

        }

        public void setDone(bool input)
        {
            this.done = input;
        }

        public void setDate(DateTime input)
        {
            this.date = input;
        }

        public void setName(string input)
        {
            this.taskName = input;
        }

        public void setContent(string input)
        {
            this.content = input;
        }

        public DateTime getDate()
        {
            return this.date;
        }

        public string getName()
        {
            return this.taskName;
        }

        public string getContent()
        {
            return this.content;
        }
    }
}
