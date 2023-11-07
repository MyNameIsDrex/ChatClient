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
    public partial class user_edit_form : Form
    {
        public user_edit_form()
        {
            InitializeComponent();
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            Hide();
            Program.Username.username = username_textbox.Text;
            ChatClient.set_username.update_username_label();            
        }

        private void Cancel_Click(object sender, EventArgs e)
        {

            Hide();
        }

        public void setUser(string name)
        {
            InitializeComponent();
            username_textbox.Text = name;
        }
    }
}
