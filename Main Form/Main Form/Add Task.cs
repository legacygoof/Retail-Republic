using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_Form
{
    public partial class Add_Task : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        List<string> keywords;

        //Global Lists
        List<TaskInfo> taskList;
        List<Profile> profileList;


        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Add_Task(List<TaskInfo> taskList, List<Profile> profiles)
        {
            InitializeComponent();
            keywords = new List<string>();
            this.profileList = profiles;
            this.taskList = taskList;

            foreach (Profile p in profileList)
                ProfileBox.Items.Add(p.name);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Add_Task_Load(object sender, EventArgs e)
        {
            //TaskInfo Task = new TaskInfo();
            TimeBox.Hide();
            SizeBox.SelectedIndex = 0;
            AmPmBox.SelectedIndex = 0;
            ProfileBox.SelectedIndex = 0;
            //TimeBox.Text = "1";
            maskedTextBox1.Text = "10:00";
            CategoryBox.SelectedIndex = 0;
        }

        private void CreateTask_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(maskedTextBox1.Text);
            string k = KeywordBox.Text;
            k = k.Replace(" ", string.Empty);
            string[] kw = k.Split(',');
            for (int i = 0; i < kw.Length; i++)
            {
                keywords.Add(kw[i]);
            }
            int h = 0;
            //if (AmPmBox.SelectedIndex == 0)
            //    h = Convert.ToInt32(TimeBox.Text);
            //else
            //    h = Convert.ToInt32(TimeBox.Text) + 12;
            TaskInfo ti = new TaskInfo(SiteBox.Text, SizeBox.Text, keywords, CategoryBox.Text, ColorBox.Text, profileList[ProfileBox.SelectedIndex], maskedTextBox1.Text, AmPmBox.SelectedIndex);// new Profile(new CCInfo(), new UserInformation()), h);
            taskList.Add(ti);
            keywords.Clear();
           // CheckOut co = new CheckOut();
            //Thread test;
            //est = new Thread(Test);
            //test.Start();
            

        }
        private void Test()
        {
            while(DateTime.Now.Hour != 16)
            {
                Thread.Sleep(2000);
            }
            Thread.Sleep(5000);
            //if(DateTime.Now.Minute == 1)
                //MessageBox.Show("called");
            CheckOut co = new CheckOut();
            co.EnterInformation(SiteBox.Text, KeywordBox.Text, ColorBox.Text);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        bool backpress = false;
        private void TimeBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                backpress = true;
            }
            else
                backpress = false;
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TimeBox_TextChanged(object sender, EventArgs e)
        {
            if (TimeBox.Text.Length == 2 && backpress == false)
            {
                TimeBox.Text += ":";
                backpress = false;
            }
            TimeBox.SelectionStart = TimeBox.Text.Length;
            TimeBox.SelectionLength = 0;
            if (TimeBox.Text.Length > 5)
                SendKeys.Send("{BACKSPACE}");
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }
    }
}
