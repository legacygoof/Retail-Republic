using Main_Form.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_Form
{
    public partial class PaymentInformation : Form
    {
        UserInformation userInfo = new UserInformation();
        CCInfo ccInfo = new CCInfo();
        public PaymentInformation()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)// Card Number
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e) //CCV
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)//First Name
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            userInfo.FName = textBox3.Text;
            userInfo.LName = textBox4.Text;
            userInfo.Email = textBox7.Text;
            userInfo.Address = textBox8.Text;
            userInfo.ZipCode = textBox9.Text;
            ccInfo.CCNumber = textBox2.Text;
            ccInfo.CCExpMonth = textBox6.Text;
            ccInfo.CCExpYear = textBox5.Text;
            ccInfo.CCCsv = textBox1.Text; 
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)//Last Name
        {

        }

        private void PaymentInformation_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e) //Email
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e) //Exp Year
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e) //Exp Month
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)//Address
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e) //zipcode
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
