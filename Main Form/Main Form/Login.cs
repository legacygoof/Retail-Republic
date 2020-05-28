using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Main_Form
{
    public partial class Login : Form
    {
        public static string version = "1.0";
        public bool loggedin = false;
        private static bool version_checked = false;

        Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        Thread msgLoop;
        public Login()
        {
            InitializeComponent();
            BackgroundWorker backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += BackgroundWorker_DoWork;
            backgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
            backgroundWorker.RunWorkerAsync();
            msgLoop = new Thread(ServerMsgLoop);
            msgLoop.IsBackground = true;
            msgLoop.Start();
            Connect();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Login Field
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Password Field
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Key Field
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Login Button 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            loginFunction();
        }
        private void loginFunction()
        {
            if (client.Connected)
            {
                byte[] arr = PacketWriter.sendString(Convert.ToString(0+ " " + textBox1.Text + " " + textBox2.Text));
                client.Send(arr);
            }
        }
        public void ServerMsgLoop()
        {
            while (true)
            {
                if (client.Connected)
                {
                    byte[] buffer = new byte[1024];
                    int rec = client.Receive(buffer);
                    byte[] data = new byte[rec];

                    Array.Copy(buffer, data, rec);
                    string msg = Encoding.ASCII.GetString(data);
                    string[] msgArgs = msg.Split(' ');
                    string text = "";
                    for (int i = 1; i < msgArgs.Length; i++)
                        text += msgArgs[i] + " ";
                    if (version_checked == false)
                    {
                        if (msgArgs[0] == ErrorCodes.Version_Success.ToString())
                        {
                            version_checked = true;
                        }
                        else if (msgArgs[0] == ErrorCodes.Error.ToString())
                        {
                            MessageBox.Show("PLEASE UPDATE YOUR CLIENT, YOUR USING AN OUTDATED VERSION CURRENT VERSION IS " + msgArgs[1]);
                            Application.Exit();
                        }
                    }
                    if (loggedin == false)
                    {
                        if (msgArgs[0] == ErrorCodes.Login_Success.ToString())
                        {
                            loggedin = true;
                            //Retail_Republic rr = new Retail_Republic();
                            //rr.Show();
                            Application.Run(new Retail_Republic());
                        }
                        else
                        {
                            //MessageBox.Show(msgArgs[0]);
                        }
                    }
                    if (msgArgs[0] == ProcessCodes.Kick.ToString())
                    {
                        MessageBox.Show("Kicked: " + text);
                        Application.Exit();
                    }
                    else if (msgArgs[0] == ProcessCodes.Ban.ToString())
                    {
                        MessageBox.Show("BANNED: " + text);
                        Application.Exit();
                    }
                    else if (msgArgs[0] == ProcessCodes.Reboot.ToString())
                    {
                        MessageBox.Show("Reboot: " + text);
                        Application.Exit();
                    }
                    else if (msgArgs[0] == ProcessCodes.Message.ToString())
                    {
                        MessageBox.Show("Message: " + text);
                    }

                    Thread.Sleep(2);
                }
            }
        }
        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Logged In");
            //Main_Form form = new Main_Form();
            //form.Show();
            //this.Hide();
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (loggedin == false)
            {

            }
        }
        private void Connect()
        {

            //right now testing is being done on local host 
            //we'll use a while loop until a connection is made, might want to add a counter later
            while (!client.Connected)
            {
                //using a try and catch so if we get an error the program doesnt just crash
                //and we can close the program with reasoning behind it
                try
                {
                    //we'll change the ip to an md5 encryption so login server doesnt get ddosed
                    client.Connect(IPAddress.Parse("73.73.34.126"), 1234);//IPAddress.Loopback, 1234);
                    return;
                }
                //here we catch an error and can do whatever we want to it, we'll probs close the program for security
                catch (SocketException ex)
                {
                    DialogResult dialogResult = MessageBox.Show("Unable to connect to server, check your connection\nPress retry to try again or cancel to exit", "Unable To Connect", MessageBoxButtons.RetryCancel);
                    if (dialogResult == DialogResult.Cancel)
                    {
                        break;
                    }

                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
