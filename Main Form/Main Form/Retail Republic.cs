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



namespace Main_Form
{
    public partial class Retail_Republic : Form
    {
        KeyWords keys = new KeyWords();
        CheckOut check = new CheckOut();
        Button ActiveButton; 
        Form ActiveForm = null;
        public Retail_Republic()
        {
            InitializeComponent();
            ActiveButton = button1;
            ChangeForm(new Main_Form.Forms.HomeForm(),new  object());
        }

        private void Main_From_Load(object sender, EventArgs e)
        {

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
            ChangeForm(new PaymentInformation(), sender);
            ActivateButton(button2);
            
        }

        /// <summary>
        /// Home Button Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_1(object sender, EventArgs e)
        {
            ChangeForm(new Main_Form.Forms.HomeForm(), sender);
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
    }
}
