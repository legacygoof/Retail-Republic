using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_Form
{
    class TaskInfo
    {
        List<string> Keywords;
        string size;
        string color;
        string site;
        string category;
        Profile profile;
        DateTime Time;


        int hour;
        int diff;

        public TaskInfo(string st, string sz, List<string> k, string cat, string c, Profile p, int h)
        {
            Keywords = k;
            size = sz;
            color = c;
            category = cat;
            site = st;
            hour = h;
            profile = p;


            Time = DateTime.Now;

            if (h > Time.Hour)
                diff = h - Time.Hour;
            else
                diff = Time.Hour - h;
            Time = Time.AddHours((double)diff);

            string msgTest = "";
            foreach(string s in Keywords)
            {
                msgTest += s + "\n";
            }
            MessageBox.Show(msgTest);
            MessageBox.Show(Time.Hour.ToString());


            
        }
    }
}
