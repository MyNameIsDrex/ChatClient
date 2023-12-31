﻿namespace WinFormsApplication
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
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.ClientPanel = new System.Windows.Forms.Panel();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.userip_label = new System.Windows.Forms.Label();
            this.UsernameEdit = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ServerPanel = new System.Windows.Forms.Panel();
            this.ServerPort_Input = new System.Windows.Forms.TextBox();
            this.ServerPort = new System.Windows.Forms.Label();
            this.ServerIP = new System.Windows.Forms.Label();
            this.ServerIP_Input = new System.Windows.Forms.TextBox();
            this.ServerDisconnect = new System.Windows.Forms.Button();
            this.ServerName = new System.Windows.Forms.Label();
            this.ServerConnect = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ChattingPanel = new System.Windows.Forms.Panel();
            this.MessageOutputBox = new System.Windows.Forms.RichTextBox();
            this.AttachFileButton = new System.Windows.Forms.Button();
            this.SendButton = new System.Windows.Forms.Button();
            this.Message_InputBox = new System.Windows.Forms.TextBox();
            this.FileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ErrorText = new System.Windows.Forms.Label();
            this.serverToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTopbar.SuspendLayout();
            this.ClientPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.ServerPanel.SuspendLayout();
            this.ChattingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usernameToolStripMenuItem});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(52, 26);
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
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(76, 26);
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
            this.connectToolStripMenuItem,
            this.serverToolStripMenuItem1});
            this.menuTopbar.Location = new System.Drawing.Point(0, 0);
            this.menuTopbar.Name = "menuTopbar";
            this.menuTopbar.Size = new System.Drawing.Size(913, 28);
            this.menuTopbar.TabIndex = 0;
            this.menuTopbar.Text = "menuStrip1";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serverToolStripMenuItem});
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(77, 26);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // serverToolStripMenuItem
            // 
            this.serverToolStripMenuItem.Name = "serverToolStripMenuItem";
            this.serverToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.serverToolStripMenuItem.Text = "Server";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(3, 3);
            this.UsernameLabel.Margin = new System.Windows.Forms.Padding(3);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(84, 16);
            this.UsernameLabel.TabIndex = 1;
            this.UsernameLabel.Text = "USERNAME";
            // 
            // ClientPanel
            // 
            this.ClientPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClientPanel.Controls.Add(this.UpdateButton);
            this.ClientPanel.Controls.Add(this.userip_label);
            this.ClientPanel.Controls.Add(this.UsernameEdit);
            this.ClientPanel.Controls.Add(this.UsernameLabel);
            this.ClientPanel.Location = new System.Drawing.Point(3, 3);
            this.ClientPanel.Name = "ClientPanel";
            this.ClientPanel.Size = new System.Drawing.Size(265, 112);
            this.ClientPanel.TabIndex = 2;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(84, 25);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 4;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // userip_label
            // 
            this.userip_label.AutoSize = true;
            this.userip_label.Location = new System.Drawing.Point(3, 71);
            this.userip_label.Margin = new System.Windows.Forms.Padding(3);
            this.userip_label.Name = "userip_label";
            this.userip_label.Size = new System.Drawing.Size(60, 16);
            this.userip_label.TabIndex = 3;
            this.userip_label.Text = "USER IP";
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
            this.flowLayoutPanel1.Controls.Add(this.ClientPanel);
            this.flowLayoutPanel1.Controls.Add(this.ServerPanel);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(19, 38);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(273, 239);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // ServerPanel
            // 
            this.ServerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ServerPanel.Controls.Add(this.ServerPort_Input);
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
            // ServerPort_Input
            // 
            this.ServerPort_Input.AllowDrop = true;
            this.ServerPort_Input.Location = new System.Drawing.Point(50, 50);
            this.ServerPort_Input.MaxLength = 5;
            this.ServerPort_Input.Name = "ServerPort_Input";
            this.ServerPort_Input.Size = new System.Drawing.Size(172, 22);
            this.ServerPort_Input.TabIndex = 8;
            this.ServerPort_Input.Text = "12345";
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
            this.ServerDisconnect.Click += new System.EventHandler(this.ServerDisconnect_Click);
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
            this.ServerConnect.Click += new System.EventHandler(this.ServerConnect_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitButton.Location = new System.Drawing.Point(803, 508);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ChattingPanel
            // 
            this.ChattingPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChattingPanel.AutoSize = true;
            this.ChattingPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ChattingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChattingPanel.Controls.Add(this.MessageOutputBox);
            this.ChattingPanel.Controls.Add(this.AttachFileButton);
            this.ChattingPanel.Controls.Add(this.SendButton);
            this.ChattingPanel.Controls.Add(this.Message_InputBox);
            this.ChattingPanel.Location = new System.Drawing.Point(343, 38);
            this.ChattingPanel.Name = "ChattingPanel";
            this.ChattingPanel.Size = new System.Drawing.Size(535, 464);
            this.ChattingPanel.TabIndex = 6;
            // 
            // MessageOutputBox
            // 
            this.MessageOutputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MessageOutputBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MessageOutputBox.Location = new System.Drawing.Point(19, 16);
            this.MessageOutputBox.Name = "MessageOutputBox";
            this.MessageOutputBox.ReadOnly = true;
            this.MessageOutputBox.Size = new System.Drawing.Size(500, 384);
            this.MessageOutputBox.TabIndex = 3;
            this.MessageOutputBox.Text = "";
            // 
            // AttachFileButton
            // 
            this.AttachFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AttachFileButton.Location = new System.Drawing.Point(19, 425);
            this.AttachFileButton.Name = "AttachFileButton";
            this.AttachFileButton.Size = new System.Drawing.Size(28, 23);
            this.AttachFileButton.TabIndex = 2;
            this.AttachFileButton.Text = "+";
            this.AttachFileButton.UseVisualStyleBackColor = true;
            this.AttachFileButton.Click += new System.EventHandler(this.AttachFileButton_Click);
            // 
            // SendButton
            // 
            this.SendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SendButton.Location = new System.Drawing.Point(444, 424);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(75, 23);
            this.SendButton.TabIndex = 1;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // Message_InputBox
            // 
            this.Message_InputBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Message_InputBox.Location = new System.Drawing.Point(53, 425);
            this.Message_InputBox.Name = "Message_InputBox";
            this.Message_InputBox.Size = new System.Drawing.Size(385, 22);
            this.Message_InputBox.TabIndex = 0;
            this.Message_InputBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MessageInput_KeyDown);
            // 
            // FileDialog1
            // 
            this.FileDialog1.Filter = "Images|*.png|*.jpg|*.jpeg";
            this.FileDialog1.InitialDirectory = "C:\\";
            // 
            // ErrorText
            // 
            this.ErrorText.AutoSize = true;
            this.ErrorText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorText.ForeColor = System.Drawing.Color.Red;
            this.ErrorText.Location = new System.Drawing.Point(27, 290);
            this.ErrorText.Name = "ErrorText";
            this.ErrorText.Size = new System.Drawing.Size(0, 16);
            this.ErrorText.TabIndex = 7;
            // 
            // serverToolStripMenuItem1
            // 
            this.serverToolStripMenuItem1.Name = "serverToolStripMenuItem1";
            this.serverToolStripMenuItem1.Size = new System.Drawing.Size(64, 24);
            this.serverToolStripMenuItem1.Text = "Server";
            this.serverToolStripMenuItem1.Click += new System.EventHandler(this.serverToolStripMenuItem1_Click);
            // 
            // ChatClient
            // 
            this.AcceptButton = this.SendButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.ExitButton;
            this.ClientSize = new System.Drawing.Size(913, 543);
            this.Controls.Add(this.ErrorText);
            this.Controls.Add(this.ChattingPanel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuTopbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuTopbar;
            this.Name = "ChatClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat Client";
            this.menuTopbar.ResumeLayout(false);
            this.menuTopbar.PerformLayout();
            this.ClientPanel.ResumeLayout(false);
            this.ClientPanel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ServerPanel.ResumeLayout(false);
            this.ServerPanel.PerformLayout();
            this.ChattingPanel.ResumeLayout(false);
            this.ChattingPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usernameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuTopbar;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nothingHereYetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serverToolStripMenuItem;
        private System.Windows.Forms.Panel ClientPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel ServerPanel;
        private System.Windows.Forms.Label ServerName;
        private System.Windows.Forms.Button ServerConnect;
        private System.Windows.Forms.Button ServerDisconnect;
        private System.Windows.Forms.TextBox ServerIP_Input;
        private System.Windows.Forms.Label ServerIP;
        private System.Windows.Forms.Label ServerPort;
        private System.Windows.Forms.TextBox ServerPort_Input;
        private System.Windows.Forms.Button UsernameEdit;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label userip_label;
        private System.Windows.Forms.Panel ChattingPanel;
        private System.Windows.Forms.TextBox Message_InputBox;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Button AttachFileButton;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.OpenFileDialog FileDialog1;
        private System.Windows.Forms.RichTextBox MessageOutputBox;
        public System.Windows.Forms.Label ErrorText;
        private System.Windows.Forms.ToolStripMenuItem serverToolStripMenuItem1;
    }
}

