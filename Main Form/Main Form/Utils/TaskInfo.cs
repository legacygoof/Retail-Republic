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
        DateTime Time;


        int hour;

        public TaskInfo()
        {
            Time = DateTime.Now;
            //Time.Hour
            MessageBox.Show(Time.Hour.ToString());
            
        }
    }
}
