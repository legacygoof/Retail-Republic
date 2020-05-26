using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Form
{
    public class Profile
    {
        public string name { get; set; }
        public CCInfo CC { get; set; }
        public UserInformation uInfo { get; set; }

        public Profile(string n, CCInfo CC, UserInformation uInfo)
        {
            this.name = n;
            this.CC = CC;
            this.uInfo = uInfo;
        }

    }
}
