using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Main_Form.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Runtime.InteropServices;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using System.Threading;

namespace Main_Form
{
    public partial class Retail_Republic : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        //Global Lists
        List<TaskInfo> taskList;
        List<Profile> profileList;

        KeyWords keys = new KeyWords();
        CheckOut check = new CheckOut();
        Button ActiveButton; 
        Form ActiveForm = null;
        public Retail_Republic()
        {
            initializeList();
            InitializeComponent();
            taskList = new List<TaskInfo>();
            ActiveButton = button1;
            ChangeForm(new Main_Form.Forms.HomeForm(taskList, profileList),new  object());
        }

        private void Main_From_Load(object sender, EventArgs e)
        {
            //readJsonData();
            //initializeList();
            
        }

        private void initializeList()
        {
            
            string s = File.ReadAllText("profiles.json");
            profileList = JsonConvert.DeserializeObject<List<Profile>>(s);


        }

        public void readJsonData()
        {
            
            //profileList = new List<Profile>();
            //profileList.Add(new Profile("Profile 1",new CCInfo { CCNumber = "234324324", CCExpYear = "3453", CCCsv = "324", CCExpMonth = "22" }, new UserInformation { Address = "222", Email = "asf@asf.com", FName = "Ryan", LName = "dill", TelNumber = "2213213123", ZipCode = "24242" }));
            //profileList.Add(new Profile("Profile 2" ,new CCInfo { CCNumber = "234324324", CCExpYear = "3453", CCCsv = "324", CCExpMonth = "22" }, new UserInformation { Address = "222", Email = "asf@asf.com", FName = "Ryan", LName = "dill", TelNumber = "2213213123", ZipCode = "24242" }));
            //string json = JsonConvert.SerializeObject(profileList);
            //File.WriteAllText("profiles.json", json);
            //string s = File.ReadAllText("profiles.json");
            //profileList = JsonConvert.DeserializeObject<List<Profile>>(s);
            //test[] t = JsonConvert.DeserializeObject<test[]>(s);
            MessageBox.Show(profileList[1].name);
            
            //profileList.Clear();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //keys.KeyWord1 = textBox1.Text;
            //keys.KeyWord2 = textBox2.Text;
            check.EnterInformation();

        }

        private void ActivateButton(Button b)
        {      
            switch(b.Text.ToLower())
            {
                case "button1": button1.ForeColor = Color.FromArgb(1, 12, 176, 0); break;
                case "button2": button2.ForeColor = Color.FromArgb(1, 12, 176, 0); break;
            }
            switch (ActiveButton.Text.ToLower())
            {
                case "button1": button1.ForeColor = Color.FromArgb(1, 0, 0, 0); break;
                case "button2": button2.ForeColor = Color.FromArgb(1, 0, 0 , 0); break;
            }
            ActiveButton = b;

        }

        private void ChangeForm(Form ChildForm, object sender)
        {
            if(ActiveForm != null)
            {
                ActiveForm.Close();
            }
            ActiveForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            this.FormPanel.Controls.Add(ChildForm);
            this.FormPanel.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();

        }

        #region Hover Buttons
        /// <summary>
        /// Home Button Hover
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(1,12, 176, 0);
            
        }
        
        /// <summary>
        /// Exit App Hover Action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources.images;
        }

        

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = null;
        }
        /// <summary>
        /// Settings Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(1, 12, 176, 0);
        }
        #endregion
        #region Form Button Clicks
        /// <summary>
        /// Setting Button Clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            ChangeForm(new Main_Form.Forms.SettingsForm(profileList), sender);
            ActivateButton(button2);
            
        }

        /// <summary>
        /// Home Button Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_1(object sender, EventArgs e)
        {
            ChangeForm(new Main_Form.Forms.HomeForm(taskList,profileList), sender);
            ActivateButton(button1);
        }

        /// <summary>
        /// Close App
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        private void FormPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Retail_Republic_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
