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
        public PaymentInformation()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            userInfo.FName = textBox1.Text;
            Console.WriteLine(userInfo.FName);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            userInfo.LName = textBox2.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            userInfo.FName = textBox3.Text;
            Console.WriteLine(userInfo.FName);
            userInfo.LName = textBox4.Text;
            Console.WriteLine(userInfo.LName);
            
           
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void PaymentInformation_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
