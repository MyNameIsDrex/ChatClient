using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApplication
{
    public partial class ChatClient : Form
    {
        public ChatClient()
        {
            InitializeComponent();

            Program.Username.generate_username();
            DebugLabel.Text = Program.Username.username;
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
            
        }

        private void ChatClient_Load(object sender, EventArgs e)
        {

        }

        
    }
}
