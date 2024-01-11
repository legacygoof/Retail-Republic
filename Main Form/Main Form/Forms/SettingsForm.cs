using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_Form.Forms
{
    public partial class SettingsForm : Form
    {
        List<Profile> profiles;
        public SettingsForm(List<Profile> pl)
        {
            InitializeComponent();
            profiles = pl;

            foreach (Profile p in profiles)
                listBox1.Items.Add(p.name);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CCInfo cci = new CCInfo { CCNumber = ccNumBox.Text, CCCsv = ccsNumBox.Text, CCExpMonth = expMonthBox.Text, CCExpYear = expYearBox.Text };
            UserInformation ui = new UserInformation { FName = firstNameBox.Text, LName = lastNameBox.Text, Email = emailBox.Text, Address = addressBox.Text, TelNumber = phoneNumBox.Text, ZipCode = zipcodeBox.Text };
            Profile p = new Profile("Checkout Test",cci, ui);
            profiles.Add(p);
            string json = JsonConvert.SerializeObject(profiles);
            File.WriteAllText("profiles.json", json);
            UpdateList();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {

        }

        private void UpdateList()
        {
            listBox1.Items.Clear();
            foreach (Profile p in profiles)
                listBox1.Items.Add(p.name);
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            Profile p = profiles[listBox1.SelectedIndex];
            ccNumBox.Text = p.CC.CCNumber;
            ccsNumBox.Text = p.CC.CCCsv;
            expMonthBox.Text = p.CC.CCExpMonth;
            expYearBox.Text = p.CC.CCExpYear;

            firstNameBox.Text = p.uInfo.FName;
            lastNameBox.Text = p.uInfo.LName;
            addressBox.Text = p.uInfo.Address;
            zipcodeBox.Text = p.uInfo.ZipCode;
            phoneNumBox.Text = p.uInfo.TelNumber;
            emailBox.Text = p.uInfo.Email;

        }
    }
}
