using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_Form
{
    public partial class Add_Task : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        List<string> keywords;


        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Add_Task()
        {
            InitializeComponent();
            keywords = new List<string>();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Add_Task_Load(object sender, EventArgs e)
        {

        }

        private void CreateTask_Click(object sender, EventArgs e)
        {
            string k = KeywordBox.Text;
            k = k.Replace(" ", string.Empty);
            string[] kw = k.Split(',');
            for(int i = 0; i < kw.Length; i++)
            {
                keywords.Add(kw[i]);
            }
            int h = 0;
            if (AmPmBox.SelectedIndex == 0)
                h = Convert.ToInt32(TimeBox.Text);
            else
                h = Convert.ToInt32(TimeBox.Text) + 12;
            TaskInfo ti = new TaskInfo(SiteBox.Text,SizeBox.Text,keywords,CategoryBox.Text,"red", new Profile(new CCInfo(), new UserInformation()), h);
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

        private void TimeBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
