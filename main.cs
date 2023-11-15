using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Collections.Specialized;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApplication.Properties;
using System.Net;
using System.CodeDom;
using WinFormsApplication;

namespace WinFormsApplication
{
    //https://www.geeksforgeeks.org/socket-programming-in-c-sharp/

    public partial class ChatClient : Form
    {
        //Network variables
        private TcpClient client;
        private NetworkStream stream;
        private Thread receiveThread;
        
        private string hostname = Dns.GetHostName();

        public ChatClient()
        {
            InitializeComponent();

            if(Settings.Default.Username == "")
            {
                Program.Username.generate_username();
            }

            UsernameLabel.Text = Settings.Default.Username;
            userip_label.Text = GetLocalIPAddress();
        }

        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void serverToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ServerForm serverForm = new ServerForm();
            serverForm.Show();
        }

        private void usernameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user_edit_form user_Edit_Form = new user_edit_form();
            user_Edit_Form.Show();
        }

        private void UsernameEdit_Click(object sender, EventArgs e)
        {
            user_edit_form user_Edit_Form = new user_edit_form();
            user_Edit_Form.Show();
        }

        private void ServerIP_Input_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            UsernameLabel.Text = Settings.Default.Username;
            Settings.Default.Save();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AttachFileButton_Click(object sender, EventArgs e)
        {
            FileDialog1.ShowDialog();
        }

        private void ServerConnect_Click(object sender, EventArgs e)
        {
            client = new TcpClient();
            try
            {
                client.Connect(ServerIP_Input.Text, Convert.ToInt32(ServerPort_Input.Text));

                stream = client.GetStream();
                //stream = client.GetStream();

                receiveThread = new Thread(ReceiveMessages);
                receiveThread.Start();

                ServerConnect.Enabled = false;

                ErrorText.Visible = false;
            }
            catch
            {
                ErrorText.Text = "Connection Error!";
                ErrorText.Visible = true;
            }
        }

        private void ReceiveMessages()
        {
            while (true)
            {
                byte[] buffer = new byte[1024];
                int bytesRead = stream.Read(buffer, 0, buffer.Length);
                if (bytesRead == 0)
                break;

                string message = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                AddMessageToTextBox(message);
            }

            MessageOutputBox.AppendText("Server Disconnected...");
            Disconnect();
        }

        private void AddMessageToTextBox(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => AddMessageToTextBox(message)));
                MessageOutputBox.AppendText(Settings.Default.Username + ": " + message + Environment.NewLine);
            }
            else
            {
                MessageOutputBox.AppendText(Settings.Default.Username + ": " + message + Environment.NewLine);
            }
        }

        private void MessageInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string message = Message_InputBox.Text;
                byte[] data = Encoding.ASCII.GetBytes(message);
                stream.Write(data, 0, data.Length);

                Message_InputBox.Clear();
            }
        }

        private void Disconnect()
        {
            if (client != null)
            {
                //receiveThread.Abort(this);
                //stream.Close();
                //client.Close();
            }

            ServerConnect.Enabled = true;
        }

        private void ServerDisconnect_Click(object sender, EventArgs e)
        {
            Disconnect();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            string message = Message_InputBox.Text;
            byte[] data = Encoding.ASCII.GetBytes(message);
            stream.Write(data, 0, data.Length);

            Message_InputBox.Clear();
        }

    }
}