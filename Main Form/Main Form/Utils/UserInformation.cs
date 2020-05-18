using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Form.Utils
{
    class UserInformation
    {
        private string fName, lName, email, telNumber, address, zipCode;

        public string FName
        {
            get { return fName; }
            set { fName = value; }
        }
        public string LName
        {
            get { return lName; }
            set { lName = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string TelNumber
        {
            get { return telNumber; }
            set { telNumber = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string ZipCode
        {
            get { return zipCode; }
            set { zipCode = value; }
        }
    }
}
