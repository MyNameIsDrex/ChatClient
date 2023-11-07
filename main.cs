using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
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
            UsernameLabel.Text = Program.Username.username;

            set_username.update_username_label();

            
        }

        public static class set_username
        {   
            public static void update_username_label()
            {
                UsernameLabel.Text = Program.Username.username;
            }



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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
