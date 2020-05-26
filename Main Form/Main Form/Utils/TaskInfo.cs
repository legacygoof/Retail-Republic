using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_Form
{
    public class TaskInfo
    {
        public List<string> Keywords;
        public string size;
        public string color;
        public string site;
        public string category;
        public Profile profile;
        public DateTime Time;


        public int hour;
        int minute;
        public int diff;
        public TaskInfo()
        {

        }

        public TaskInfo(string st, string sz, List<string> k, string cat, string c, Profile p, string time, int ampm)
        {
            Keywords = new List<string>();
            foreach(string s in k)
            {
                Keywords.Add(s);
            }
            string[] newTime = time.Split(':');
            size = sz;
            color = c;
            category = cat;
            site = st;
            hour = Convert.ToInt32(newTime[0]);
            minute = Convert.ToInt32(newTime[1]);

            profile = p;
            //color = "Black";
            //site = "";



            Time = DateTime.Now;
            if (ampm > 0)
                hour += 12;
            if (hour > Time.Hour)
                diff = hour - Time.Hour;
            else
                diff = Time.Hour - hour;
            Time = Time.AddHours((double)diff);
            if(minute > Time.Minute)
                diff = minute - Time.Minute;
            else
                diff = Time.Minute - minute;

            Time = Time.AddMinutes((double)diff);
            

            string msgTest = "";
            foreach(string s in Keywords)
            {
                msgTest += s + "\n";
            }
           // MessageBox.Show(msgTest);
            //MessageBox.Show(Time.Hour.ToString());
            //MessageBox.Show(Time.Minute.ToString());


            
        }
    }
}
