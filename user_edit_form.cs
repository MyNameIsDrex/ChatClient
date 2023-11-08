using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WinFormsApplication.Program;
using System.Windows.Input;
using WinFormsApplication.Properties;


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

            Settings.Default.Username = username_textbox.Text;
            
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

        private void username_textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Hide();

                Settings.Default.Username = username_textbox.Text;
            }
        }
    }
}
