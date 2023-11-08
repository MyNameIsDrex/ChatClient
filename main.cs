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

namespace WinFormsApplication
{
    public partial class ChatClient : Form
    {
        private TcpClient client;
        private NetworkStream stream;
        private Thread receiveThread;

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
    }
}
