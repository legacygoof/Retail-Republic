namespace Main_Form
{
    partial class Add_Task
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SiteBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SizeBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.KeywordBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CategoryBox = new System.Windows.Forms.ComboBox();
            this.ProfileBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TimeBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AmPmBox = new System.Windows.Forms.ComboBox();
            this.CreateTask = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SiteBox
            // 
            this.SiteBox.Location = new System.Drawing.Point(101, 38);
            this.SiteBox.Name = "SiteBox";
            this.SiteBox.Size = new System.Drawing.Size(145, 20);
            this.SiteBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Site:";
            // 
            // SizeBox
            // 
            this.SizeBox.FormattingEnabled = true;
            this.SizeBox.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large",
            "XL"});
            this.SizeBox.Location = new System.Drawing.Point(101, 64);
            this.SizeBox.Name = "SizeBox";
            this.SizeBox.Size = new System.Drawing.Size(145, 21);
            this.SizeBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Size:";
            // 
            // KeywordBox
            // 
            this.KeywordBox.Location = new System.Drawing.Point(101, 92);
            this.KeywordBox.Name = "KeywordBox";
            this.KeywordBox.Size = new System.Drawing.Size(145, 20);
            this.KeywordBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Keywords:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Category:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // CategoryBox
            // 
            this.CategoryBox.FormattingEnabled = true;
            this.CategoryBox.Items.AddRange(new object[] {
            "Jackets",
            "Shirts",
            "Tops/Sweaters",
            "Sweatshirts",
            "Pants",
            "Shorts",
            "T-Shirts",
            "Hats",
            "Bags",
            "Accessories",
            "Shoes",
            "Skate"});
            this.CategoryBox.Location = new System.Drawing.Point(101, 118);
            this.CategoryBox.Name = "CategoryBox";
            this.CategoryBox.Size = new System.Drawing.Size(145, 21);
            this.CategoryBox.TabIndex = 4;
            // 
            // ProfileBox
            // 
            this.ProfileBox.FormattingEnabled = true;
            this.ProfileBox.Location = new System.Drawing.Point(101, 145);
            this.ProfileBox.Name = "ProfileBox";
            this.ProfileBox.Size = new System.Drawing.Size(145, 21);
            this.ProfileBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Profile:";
            this.label5.Click += new System.EventHandler(this.label4_Click);
            // 
            // TimeBox
            // 
            this.TimeBox.Location = new System.Drawing.Point(101, 173);
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.Size = new System.Drawing.Size(79, 20);
            this.TimeBox.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Time:";
            this.label6.Click += new System.EventHandler(this.label4_Click);
            // 
            // AmPmBox
            // 
            this.AmPmBox.FormattingEnabled = true;
            this.AmPmBox.Items.AddRange(new object[] {
            "A.M.",
            "P.M."});
            this.AmPmBox.Location = new System.Drawing.Point(186, 172);
            this.AmPmBox.Name = "AmPmBox";
            this.AmPmBox.Size = new System.Drawing.Size(60, 21);
            this.AmPmBox.TabIndex = 7;
            // 
            // CreateTask
            // 
            this.CreateTask.Location = new System.Drawing.Point(12, 260);
            this.CreateTask.Name = "CreateTask";
            this.CreateTask.Size = new System.Drawing.Size(270, 56);
            this.CreateTask.TabIndex = 8;
            this.CreateTask.Text = "Add Task";
            this.CreateTask.UseVisualStyleBackColor = true;
            this.CreateTask.Click += new System.EventHandler(this.CreateTask_Click);
            // 
            // Add_Task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 328);
            this.Controls.Add(this.CreateTask);
            this.Controls.Add(this.AmPmBox);
            this.Controls.Add(this.TimeBox);
            this.Controls.Add(this.ProfileBox);
            this.Controls.Add(this.CategoryBox);
            this.Controls.Add(this.KeywordBox);
            this.Controls.Add(this.SizeBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SiteBox);
            this.Name = "Add_Task";
            this.Text = "Add Task";
            this.Load += new System.EventHandler(this.Add_Task_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SiteBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SizeBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox KeywordBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CategoryBox;
        private System.Windows.Forms.ComboBox ProfileBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TimeBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox AmPmBox;
        private System.Windows.Forms.Button CreateTask;
    }
}