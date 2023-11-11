namespace WinFormsApplication
{
    partial class ServerForm
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
            this.server_name_label = new System.Windows.Forms.Label();
            this.data_panel = new System.Windows.Forms.Panel();
            this.port_input = new System.Windows.Forms.TextBox();
            this.port_label = new System.Windows.Forms.Label();
            this.server_name_input = new System.Windows.Forms.TextBox();
            this.update_servername = new System.Windows.Forms.Button();
            this.update_port = new System.Windows.Forms.Button();
            this.security_panel = new System.Windows.Forms.Panel();
            this.security_label = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.security_checklist = new System.Windows.Forms.CheckedListBox();
            this.apply_button = new System.Windows.Forms.Button();
            this.data_panel.SuspendLayout();
            this.security_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // server_name_label
            // 
            this.server_name_label.AutoSize = true;
            this.server_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.server_name_label.Location = new System.Drawing.Point(10, 10);
            this.server_name_label.Margin = new System.Windows.Forms.Padding(10);
            this.server_name_label.Name = "server_name_label";
            this.server_name_label.Size = new System.Drawing.Size(99, 16);
            this.server_name_label.TabIndex = 0;
            this.server_name_label.Text = "Server name:";
            // 
            // data_panel
            // 
            this.data_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.data_panel.Controls.Add(this.update_port);
            this.data_panel.Controls.Add(this.update_servername);
            this.data_panel.Controls.Add(this.port_input);
            this.data_panel.Controls.Add(this.port_label);
            this.data_panel.Controls.Add(this.server_name_input);
            this.data_panel.Controls.Add(this.server_name_label);
            this.data_panel.Location = new System.Drawing.Point(12, 12);
            this.data_panel.Name = "data_panel";
            this.data_panel.Size = new System.Drawing.Size(240, 426);
            this.data_panel.TabIndex = 1;
            // 
            // port_input
            // 
            this.port_input.AcceptsTab = true;
            this.port_input.AllowDrop = true;
            this.port_input.Location = new System.Drawing.Point(13, 109);
            this.port_input.MaxLength = 20;
            this.port_input.Name = "port_input";
            this.port_input.Size = new System.Drawing.Size(201, 22);
            this.port_input.TabIndex = 3;
            // 
            // port_label
            // 
            this.port_label.AutoSize = true;
            this.port_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.port_label.Location = new System.Drawing.Point(10, 93);
            this.port_label.Margin = new System.Windows.Forms.Padding(10);
            this.port_label.Name = "port_label";
            this.port_label.Size = new System.Drawing.Size(39, 16);
            this.port_label.TabIndex = 2;
            this.port_label.Text = "Port:";
            // 
            // server_name_input
            // 
            this.server_name_input.AcceptsTab = true;
            this.server_name_input.AllowDrop = true;
            this.server_name_input.Location = new System.Drawing.Point(13, 29);
            this.server_name_input.MaxLength = 20;
            this.server_name_input.Name = "server_name_input";
            this.server_name_input.Size = new System.Drawing.Size(201, 22);
            this.server_name_input.TabIndex = 1;
            // 
            // update_servername
            // 
            this.update_servername.Location = new System.Drawing.Point(139, 57);
            this.update_servername.Name = "update_servername";
            this.update_servername.Size = new System.Drawing.Size(75, 23);
            this.update_servername.TabIndex = 4;
            this.update_servername.Text = "Update";
            this.update_servername.UseVisualStyleBackColor = true;
            // 
            // update_port
            // 
            this.update_port.Location = new System.Drawing.Point(139, 137);
            this.update_port.Name = "update_port";
            this.update_port.Size = new System.Drawing.Size(75, 23);
            this.update_port.TabIndex = 5;
            this.update_port.Text = "Update";
            this.update_port.UseVisualStyleBackColor = true;
            // 
            // security_panel
            // 
            this.security_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.security_panel.Controls.Add(this.apply_button);
            this.security_panel.Controls.Add(this.security_checklist);
            this.security_panel.Controls.Add(this.listBox1);
            this.security_panel.Controls.Add(this.security_label);
            this.security_panel.Location = new System.Drawing.Point(283, 12);
            this.security_panel.Name = "security_panel";
            this.security_panel.Size = new System.Drawing.Size(181, 426);
            this.security_panel.TabIndex = 2;
            // 
            // security_label
            // 
            this.security_label.AutoSize = true;
            this.security_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.security_label.Location = new System.Drawing.Point(10, 11);
            this.security_label.Margin = new System.Windows.Forms.Padding(10);
            this.security_label.Name = "security_label";
            this.security_label.Size = new System.Drawing.Size(63, 16);
            this.security_label.TabIndex = 0;
            this.security_label.Text = "Security";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "WPA-2 (MPG-OP)",
            "WPA-2 (MPS2-OP)",
            "WPA-2 (MPS2)",
            "WPA-3 (MPG)",
            "WPA-3 (ROOT)",
            "WPA-3 (MPG - Verified)"});
            this.listBox1.Location = new System.Drawing.Point(13, 40);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 20);
            this.listBox1.TabIndex = 1;
            // 
            // security_checklist
            // 
            this.security_checklist.FormattingEnabled = true;
            this.security_checklist.Items.AddRange(new object[] {
            "Data Privacy",
            "Open Connection",
            "Pinging",
            "Images Allowed",
            "Message Filters",
            "Allow Links"});
            this.security_checklist.Location = new System.Drawing.Point(13, 93);
            this.security_checklist.Name = "security_checklist";
            this.security_checklist.Size = new System.Drawing.Size(135, 106);
            this.security_checklist.TabIndex = 6;
            // 
            // apply_button
            // 
            this.apply_button.Location = new System.Drawing.Point(92, 388);
            this.apply_button.Name = "apply_button";
            this.apply_button.Size = new System.Drawing.Size(75, 23);
            this.apply_button.TabIndex = 7;
            this.apply_button.Text = "Apply";
            this.apply_button.UseVisualStyleBackColor = true;
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.security_panel);
            this.Controls.Add(this.data_panel);
            this.Name = "ServerForm";
            this.Text = "ServerForm";
            this.data_panel.ResumeLayout(false);
            this.data_panel.PerformLayout();
            this.security_panel.ResumeLayout(false);
            this.security_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label server_name_label;
        private System.Windows.Forms.Panel data_panel;
        private System.Windows.Forms.TextBox server_name_input;
        private System.Windows.Forms.TextBox port_input;
        private System.Windows.Forms.Label port_label;
        private System.Windows.Forms.Button update_port;
        private System.Windows.Forms.Button update_servername;
        private System.Windows.Forms.Panel security_panel;
        private System.Windows.Forms.Label security_label;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckedListBox security_checklist;
        private System.Windows.Forms.Button apply_button;
    }
}