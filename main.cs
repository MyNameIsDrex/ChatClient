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
        private TcpClient client;
        private NetworkStream stream;
        private Thread receiveThread;

        public string msg;
        public ChatClient()
        {
            InitializeComponent();

            if(Settings.Default.Username == "")
            {
                Program.Username.generate_username();
            }

            UsernameLabel.Text = Settings.Default.Username;
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

        

        private void usernameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user_edit_form user_Edit_Form = new user_edit_form();
            user_Edit_Form.Show();
        }

        private void ChatClient_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

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

                NetworkStream stream = client.GetStream();
                
            }
            catch
            {

            }
        }

        

        private void MessageInput_KeyDown(object sender, KeyEventArgs e)
        {
            msg = Message_InputBox.Text;
            Message_InputBox.Clear();
        }

        // ExecuteClient() Method
        static void ExecuteClient()
        {

            try
            {

                // Establish the remote endpoint 
                // for the socket. This example 
                // uses port 11111 on the local 
                // computer.
                IPHostEntry ipHost = Dns.GetHostEntry(Dns.GetHostName());
                IPAddress ipAddr = ipHost.AddressList[0];
                IPEndPoint localEndPoint = new IPEndPoint(ipAddr, 11111);

                // Creation TCP/IP Socket using 
                // Socket Class Constructor
                Socket sender = new Socket(ipAddr.AddressFamily,
                           SocketType.Stream, ProtocolType.Tcp);
                
                try
                {

                    // Connect Socket to the remote 
                    // endpoint using method Connect()
                    sender.Connect(localEndPoint);

                    // We print EndPoint information 
                    // that we are connected
                    Console.WriteLine("Socket connected to -> {0} ",
                                  sender.RemoteEndPoint.ToString());

                    // Creation of message that
                    // we will send to Server
                    byte[] messageSent = Encoding.ASCII.GetBytes("HOW DO I PUT A VARIABLE HERE?!");
                    int byteSent = sender.Send(messageSent);

                    // Data buffer
                    byte[] messageReceived = new byte[1024];

                    // We receive the message using 
                    // the method Receive(). This 
                    // method returns number of bytes
                    // received, that we'll use to 
                    // convert them to string
                    int byteRecv = sender.Receive(messageReceived);
                    Console.WriteLine("Message from Server -> {0}",
                          Encoding.ASCII.GetString(messageReceived,
                                                     0, byteRecv));

                    // Close Socket using 
                    // the method Close()
                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();
                }

                // Manage of Socket's Exceptions
                catch (ArgumentNullException ane)
                {

                    Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
                }

                catch (SocketException se)
                {

                    Console.WriteLine("SocketException : {0}", se.ToString());
                }

                catch (Exception e)
                {
                    Console.WriteLine("Unexpected exception : {0}", e.ToString());
                }
            }

            catch (Exception e)
            {

                Console.WriteLine(e.ToString());
            }
        }
    }
}
    

