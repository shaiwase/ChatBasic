namespace server_ui
{
    partial class ServerGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerGUI));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxMsgLog = new System.Windows.Forms.TextBox();
            this.btn_SendPrivateChat = new System.Windows.Forms.Button();
            this.btn_broadcast = new System.Windows.Forms.Button();
            this.btn_disconnect = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 34);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(154, 394);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usernames";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "IP Addresses - Time of connection";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(163, 34);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(235, 394);
            this.listBox2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(469, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Chat log";
            // 
            // txtBoxMsgLog
            // 
            this.txtBoxMsgLog.Location = new System.Drawing.Point(404, 34);
            this.txtBoxMsgLog.Multiline = true;
            this.txtBoxMsgLog.Name = "txtBoxMsgLog";
            this.txtBoxMsgLog.ReadOnly = true;
            this.txtBoxMsgLog.Size = new System.Drawing.Size(339, 394);
            this.txtBoxMsgLog.TabIndex = 6;
            this.txtBoxMsgLog.Text = "Chat log";
            // 
            // btn_SendPrivateChat
            // 
            this.btn_SendPrivateChat.Location = new System.Drawing.Point(32, 434);
            this.btn_SendPrivateChat.Name = "btn_SendPrivateChat";
            this.btn_SendPrivateChat.Size = new System.Drawing.Size(259, 23);
            this.btn_SendPrivateChat.TabIndex = 7;
            this.btn_SendPrivateChat.Text = "Send private chat";
            this.btn_SendPrivateChat.UseVisualStyleBackColor = true;
            this.btn_SendPrivateChat.Click += new System.EventHandler(this.btn_SendPrivateChat_Click);
            // 
            // btn_broadcast
            // 
            this.btn_broadcast.Location = new System.Drawing.Point(32, 463);
            this.btn_broadcast.Name = "btn_broadcast";
            this.btn_broadcast.Size = new System.Drawing.Size(259, 23);
            this.btn_broadcast.TabIndex = 8;
            this.btn_broadcast.Text = "Broadcast";
            this.btn_broadcast.UseVisualStyleBackColor = true;
            this.btn_broadcast.Click += new System.EventHandler(this.btn_broadcast_Click);
            // 
            // btn_disconnect
            // 
            this.btn_disconnect.Location = new System.Drawing.Point(32, 492);
            this.btn_disconnect.Name = "btn_disconnect";
            this.btn_disconnect.Size = new System.Drawing.Size(259, 23);
            this.btn_disconnect.TabIndex = 9;
            this.btn_disconnect.Text = "Disconnect client";
            this.btn_disconnect.UseVisualStyleBackColor = true;
            this.btn_disconnect.Click += new System.EventHandler(this.btn_disconnect_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(326, 463);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(339, 52);
            this.textBox2.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(449, 443);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Message";
            // 
            // ServerGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(755, 513);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btn_disconnect);
            this.Controls.Add(this.btn_broadcast);
            this.Controls.Add(this.btn_SendPrivateChat);
            this.Controls.Add(this.txtBoxMsgLog);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "ServerGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat Server";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ServerGUI_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxMsgLog;
        private System.Windows.Forms.Button btn_SendPrivateChat;
        private System.Windows.Forms.Button btn_broadcast;
        private System.Windows.Forms.Button btn_disconnect;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
    }
}