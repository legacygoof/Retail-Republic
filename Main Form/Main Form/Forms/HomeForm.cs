﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_Form.Forms
{
    public partial class HomeForm : Form
    {
        Add_Task createTask;
        List<string> Keywords;
        List<string> TaskInfo;
        public HomeForm()
        {
            InitializeComponent();
            createTask = new Add_Task();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (createTask.IsDisposed)
                createTask = new Add_Task();
            createTask.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
