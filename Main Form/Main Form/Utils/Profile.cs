using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Form
{
    class Profile
    {
        CCInfo CC;
        UserInformation uInfo;

        public Profile(CCInfo CC, UserInformation uInfo)
        {
            this.CC = CC;
            this.uInfo = uInfo;
        }

    }
}
