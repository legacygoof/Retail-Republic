using System;
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
        List<TaskInfo> taskList;
        List<Profile> profileList;
        TableLayoutPanel taskPanel;
        Button runNow;
        Button StopNow;
        public HomeForm(List<TaskInfo> tl, List<Profile> pl)
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            DoubleBuffered = true;
            taskList = tl;
            profileList = pl;
            runNow = new Button { Text = "►", ForeColor = Color.White ,Anchor = AnchorStyles.Left, BackColor = Color.Green, Width = 20, Height = 20, Padding = new Padding { All = 0 } };
            StopNow = new Button { Text = "❚❚", ForeColor = Color.White ,Anchor = AnchorStyles.Left, BackColor = Color.Red, Width = 20, Height = 20, Padding = new Padding { All = 0 } };
            createTask = new Add_Task(taskList,profileList);
            createTask.Disposed += CreateTask_Disposed;
            updateTaskList();
        }

        private void CreateTask_Disposed(object sender, EventArgs e)
        {
            updateTaskList();
        }

        private void updateTaskList()
        {
            taskPanel = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            //MessageBox.Show(taskList.Count.ToString());
            tableLayoutPanel1.Controls.Clear();
            
            tableLayoutPanel1.RowCount = taskList.Count;
            tableLayoutPanel1.RowStyles.Clear();
            //tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            //tableLayoutPanel1.ColumnCount = 8;
            //tableLayoutPanel1.Refresh();
            int row = 0;
            foreach(TaskInfo ti in taskList)
             {
                string temp = "";
                foreach(string s in ti.Keywords)
                {
                    temp += s + " ";
                }
                
                tableLayoutPanel1.Controls.Add(new Label { Text = ti.site, ForeColor = Color.Yellow, Anchor = AnchorStyles.Left, AutoSize = true }, 0, row);
                tableLayoutPanel1.Controls.Add(new Label { Text = temp, ForeColor = Color.Yellow, Anchor = AnchorStyles.Left, AutoSize = true }, 1, row);
                tableLayoutPanel1.Controls.Add(new Label { Text = ti.size, ForeColor = Color.Yellow, Anchor = AnchorStyles.Left, AutoSize = true }, 2, row);

                tableLayoutPanel1.Controls.Add(new Label { Text = ti.profile.name, ForeColor = Color.Yellow, Anchor = AnchorStyles.Left, AutoSize = true }, 3, row);
                tableLayoutPanel1.Controls.Add(new Label { Text = "NONE", ForeColor = Color.Yellow, Anchor = AnchorStyles.Left, AutoSize = true }, 4, row);
                tableLayoutPanel1.Controls.Add(new Label { Text = "waiting", ForeColor = Color.Yellow, Anchor = AnchorStyles.Left, AutoSize = true }, 5, row);

                tableLayoutPanel1.Controls.Add(new Label { Text = ti.Time.ToShortTimeString(), ForeColor = Color.Yellow, Anchor = AnchorStyles.Left, AutoSize = true }, 6, row);
                //.Controls.Add(runNow, 7, row);
                //tableLayoutPanel1.Controls.Add(StopNow, 8, row);
                tableLayoutPanel1.Controls.Add(new Button { Text = "►", ForeColor = Color.White, Anchor = AnchorStyles.Left, BackColor = Color.Green, Width = 20, Height = 20, Padding = new Padding { All = 0 } }, 7, row);
                tableLayoutPanel1.Controls.Add(new Button { Text = "❚❚",ForeColor = Color.White, Anchor = AnchorStyles.Left, BackColor = Color.Red, Width = 20, Height = 20, Padding = new Padding { All = 0 } }, 8, row);
                row++;
                
                
            }
            //tableLayoutPanel1.Controls.Add(new Label { Text = "Type:", Anchor = AnchorStyles.Left, AutoSize = true }, 0, 0);
            //tableLayoutPanel1.Controls.Add(new ComboBox { Dock = DockStyle.Fill }, 1,0);
            tableLayoutPanel1.ResumeLayout();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (createTask.IsDisposed)
                createTask = new Add_Task(taskList, profileList);
            createTask.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
