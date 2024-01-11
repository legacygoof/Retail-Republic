using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Form
{
    public class CCInfo
    {
        private string ccNumber, ccExpMonth, ccExpYear, ccCSV;

        public string CCNumber
        {
            get { return ccNumber; }
            set { ccNumber = value; }
        }
        public string CCExpMonth
        {
            get { return ccExpMonth; }
            set { ccExpMonth = value; }
        }
        public string CCExpYear
        {
            get { return ccExpMonth; }
            set { ccExpYear = value; }
        }
        public string CCCsv
        {
            get { return ccCSV; }
            set { ccCSV = value; }
        }
    }
}
