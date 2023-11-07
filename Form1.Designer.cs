namespace WinFormsApplication
{
    partial class ChatClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usernameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nothingHereYetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTopbar = new System.Windows.Forms.MenuStrip();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DebugLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UsernameEdit = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ServerPanel = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ServerPort = new System.Windows.Forms.Label();
            this.ServerIP = new System.Windows.Forms.Label();
            this.ServerIP_Input = new System.Windows.Forms.TextBox();
            this.ServerDisconnect = new System.Windows.Forms.Button();
            this.ServerName = new System.Windows.Forms.Label();
            this.ServerConnect = new System.Windows.Forms.Button();
            this.menuTopbar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.ServerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usernameToolStripMenuItem});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.userToolStripMenuItem.Text = "User";
            this.userToolStripMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
            // 
            // usernameToolStripMenuItem
            // 
            this.usernameToolStripMenuItem.Name = "usernameToolStripMenuItem";
            this.usernameToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.usernameToolStripMenuItem.Text = "Username";
            this.usernameToolStripMenuItem.Click += new System.EventHandler(this.usernameToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nothingHereYetToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // nothingHereYetToolStripMenuItem
            // 
            this.nothingHereYetToolStripMenuItem.Name = "nothingHereYetToolStripMenuItem";
            this.nothingHereYetToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.nothingHereYetToolStripMenuItem.Text = "Nothing here yet";
            // 
            // menuTopbar
            // 
            this.menuTopbar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuTopbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.connectToolStripMenuItem});
            this.menuTopbar.Location = new System.Drawing.Point(0, 0);
            this.menuTopbar.Name = "menuTopbar";
            this.menuTopbar.Size = new System.Drawing.Size(1293, 30);
            this.menuTopbar.TabIndex = 0;
            this.menuTopbar.Text = "menuStrip1";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serverToolStripMenuItem});
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // serverToolStripMenuItem
            // 
            this.serverToolStripMenuItem.Name = "serverToolStripMenuItem";
            this.serverToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.serverToolStripMenuItem.Text = "Server";
            // 
            // DebugLabel
            // 
            this.DebugLabel.AutoSize = true;
            this.DebugLabel.Location = new System.Drawing.Point(3, 3);
            this.DebugLabel.Margin = new System.Windows.Forms.Padding(3);
            this.DebugLabel.Name = "DebugLabel";
            this.DebugLabel.Size = new System.Drawing.Size(84, 16);
            this.DebugLabel.TabIndex = 1;
            this.DebugLabel.Text = "USERNAME";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.UsernameEdit);
            this.panel1.Controls.Add(this.DebugLabel);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 112);
            this.panel1.TabIndex = 2;
            // 
            // UsernameEdit
            // 
            this.UsernameEdit.Location = new System.Drawing.Point(3, 25);
            this.UsernameEdit.Name = "UsernameEdit";
            this.UsernameEdit.Size = new System.Drawing.Size(75, 23);
            this.UsernameEdit.TabIndex = 2;
            this.UsernameEdit.Text = "Edit";
            this.UsernameEdit.UseVisualStyleBackColor = true;
            this.UsernameEdit.Click += new System.EventHandler(this.UsernameEdit_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.ServerPanel);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(19, 38);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(276, 239);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // ServerPanel
            // 
            this.ServerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ServerPanel.Controls.Add(this.textBox1);
            this.ServerPanel.Controls.Add(this.ServerPort);
            this.ServerPanel.Controls.Add(this.ServerIP);
            this.ServerPanel.Controls.Add(this.ServerIP_Input);
            this.ServerPanel.Controls.Add(this.ServerDisconnect);
            this.ServerPanel.Controls.Add(this.ServerName);
            this.ServerPanel.Controls.Add(this.ServerConnect);
            this.ServerPanel.Location = new System.Drawing.Point(3, 121);
            this.ServerPanel.Name = "ServerPanel";
            this.ServerPanel.Size = new System.Drawing.Size(265, 112);
            this.ServerPanel.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.AllowDrop = true;
            this.textBox1.Location = new System.Drawing.Point(50, 50);
            this.textBox1.MaxLength = 5;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 22);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "12345";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // ServerPort
            // 
            this.ServerPort.AutoSize = true;
            this.ServerPort.Location = new System.Drawing.Point(3, 53);
            this.ServerPort.Margin = new System.Windows.Forms.Padding(3);
            this.ServerPort.Name = "ServerPort";
            this.ServerPort.Size = new System.Drawing.Size(34, 16);
            this.ServerPort.TabIndex = 7;
            this.ServerPort.Text = "Port:";
            // 
            // ServerIP
            // 
            this.ServerIP.AutoSize = true;
            this.ServerIP.Location = new System.Drawing.Point(3, 25);
            this.ServerIP.Margin = new System.Windows.Forms.Padding(3);
            this.ServerIP.Name = "ServerIP";
            this.ServerIP.Size = new System.Drawing.Size(22, 16);
            this.ServerIP.TabIndex = 6;
            this.ServerIP.Text = "IP:";
            // 
            // ServerIP_Input
            // 
            this.ServerIP_Input.AllowDrop = true;
            this.ServerIP_Input.Location = new System.Drawing.Point(50, 22);
            this.ServerIP_Input.MaxLength = 15;
            this.ServerIP_Input.Name = "ServerIP_Input";
            this.ServerIP_Input.Size = new System.Drawing.Size(172, 22);
            this.ServerIP_Input.TabIndex = 5;
            this.ServerIP_Input.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.ServerIP_Input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ServerIP_Input_KeyPress);
            // 
            // ServerDisconnect
            // 
            this.ServerDisconnect.Location = new System.Drawing.Point(84, 84);
            this.ServerDisconnect.Name = "ServerDisconnect";
            this.ServerDisconnect.Size = new System.Drawing.Size(94, 23);
            this.ServerDisconnect.TabIndex = 4;
            this.ServerDisconnect.Text = "Disconnect";
            this.ServerDisconnect.UseVisualStyleBackColor = true;
            // 
            // ServerName
            // 
            this.ServerName.AutoSize = true;
            this.ServerName.Location = new System.Drawing.Point(3, 3);
            this.ServerName.Margin = new System.Windows.Forms.Padding(3);
            this.ServerName.Name = "ServerName";
            this.ServerName.Size = new System.Drawing.Size(105, 16);
            this.ServerName.TabIndex = 1;
            this.ServerName.Text = "SERVER NAME";
            // 
            // ServerConnect
            // 
            this.ServerConnect.Location = new System.Drawing.Point(3, 84);
            this.ServerConnect.Name = "ServerConnect";
            this.ServerConnect.Size = new System.Drawing.Size(75, 23);
            this.ServerConnect.TabIndex = 3;
            this.ServerConnect.Text = "Connect";
            this.ServerConnect.UseVisualStyleBackColor = true;
            // 
            // ChatClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 651);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuTopbar);
            this.MainMenuStrip = this.menuTopbar;
            this.Name = "ChatClient";
            this.Text = "Chat Client";
            this.Load += new System.EventHandler(this.ChatClient_Load);
            this.menuTopbar.ResumeLayout(false);
            this.menuTopbar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ServerPanel.ResumeLayout(false);
            this.ServerPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usernameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuTopbar;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.Label DebugLabel;
        private System.Windows.Forms.ToolStripMenuItem nothingHereYetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serverToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel ServerPanel;
        private System.Windows.Forms.Label ServerName;
        private System.Windows.Forms.Button ServerConnect;
        private System.Windows.Forms.Button ServerDisconnect;
        private System.Windows.Forms.TextBox ServerIP_Input;
        private System.Windows.Forms.Label ServerIP;
        private System.Windows.Forms.Label ServerPort;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button UsernameEdit;
    }
}

