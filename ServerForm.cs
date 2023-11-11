using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using WinFormsApplication.Properties;


namespace WinFormsApplication
{
    public partial class ServerForm : Form
    {
        private TcpListener server;
        private List<TcpClient> clients = new List<TcpClient>();
        private Thread listenerThread;

        public ServerForm()
        {
            
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            StartButton.Enabled = false;
            StopButton.Enabled = true;


            listenerThread = new Thread(ListenForClients);
            listenerThread.Start();

            LogMessage("Server started on port 12345");
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            StopButton.Enabled = false;
            StartButton.Enabled = true;

            listenerThread.Abort();
            server.Stop();

            LogMessage("Server stopped");
        }

        private void ListenForClients()
        {
            server = new TcpListener(IPAddress.Any, 12345);
            server.Start();

            while (true)
            {
                try
                {
                    TcpClient client = server.AcceptTcpClient();
                    clients.Add(client);

                    UpdateClientList();
                    LogMessage($"Client connected: {((IPEndPoint)client.Client.RemoteEndPoint).Address}");

                    Thread clientThread = new Thread(() => HandleClient(client));
                    clientThread.Start();
                }
                catch (ThreadAbortException)
                {
                    // Thread was aborted intentionally.
                    break;
                }
                catch (Exception ex)
                {
                    LogMessage($"Error accepting client: {ex.Message}");
                }
            }
        }

        private void HandleClient(TcpClient client)
        {
            // Your client handling logic goes here
            // You can use the AddMessageToLog method to log messages from client threads
        }

        private void UpdateClientList()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(UpdateClientList));
            }
            else
            {
                ClientsListBox.Items.Clear();
                foreach (TcpClient c in clients)
                {
                    ClientsListBox.Items.Add(((IPEndPoint)c.Client.RemoteEndPoint).Address.ToString());
                }
            }
        }

        public void LogMessage(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => LogMessage(message)));
            }
            else
            {
                LogRichTextBox.AppendText($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {message}\n");
            }
        }
    }
}