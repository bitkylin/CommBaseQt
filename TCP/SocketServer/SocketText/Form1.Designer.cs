namespace SocketText
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstServerCommunicationText = new System.Windows.Forms.ListBox();
            this.lstControlText = new System.Windows.Forms.ListBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_send = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBoxSendMessage = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnStartServer = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.端口号 = new System.Windows.Forms.Label();
            this.IP地址 = new System.Windows.Forms.Label();
            this.IPADDress = new System.Windows.Forms.TextBox();
            this.Porttext = new System.Windows.Forms.TextBox();
            this.btnClearControlText = new System.Windows.Forms.Button();
            this.btnClearCommunicateText = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstServerCommunicationText);
            this.groupBox2.Location = new System.Drawing.Point(327, 21);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(511, 268);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "接收信息";
            // 
            // lstServerCommunicationText
            // 
            this.lstServerCommunicationText.FormattingEnabled = true;
            this.lstServerCommunicationText.HorizontalScrollbar = true;
            this.lstServerCommunicationText.ItemHeight = 15;
            this.lstServerCommunicationText.Location = new System.Drawing.Point(5, 22);
            this.lstServerCommunicationText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstServerCommunicationText.Name = "lstServerCommunicationText";
            this.lstServerCommunicationText.Size = new System.Drawing.Size(497, 229);
            this.lstServerCommunicationText.TabIndex = 0;
            // 
            // lstControlText
            // 
            this.lstControlText.FormattingEnabled = true;
            this.lstControlText.HorizontalScrollbar = true;
            this.lstControlText.ItemHeight = 15;
            this.lstControlText.Location = new System.Drawing.Point(7, 26);
            this.lstControlText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstControlText.Name = "lstControlText";
            this.lstControlText.Size = new System.Drawing.Size(485, 109);
            this.lstControlText.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lstControlText);
            this.groupBox6.Location = new System.Drawing.Point(337, 299);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Size = new System.Drawing.Size(500, 149);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "控制信息";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(205, 379);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 22);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_send
            // 
            this.btn_send.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_send.Location = new System.Drawing.Point(168, 65);
            this.btn_send.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(104, 32);
            this.btn_send.TabIndex = 1;
            this.btn_send.Text = "发送";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(7, 348);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(279, 27);
            this.textBox2.TabIndex = 0;
            // 
            // textBoxSendMessage
            // 
            this.textBoxSendMessage.Location = new System.Drawing.Point(7, 26);
            this.textBoxSendMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSendMessage.Name = "textBoxSendMessage";
            this.textBoxSendMessage.Size = new System.Drawing.Size(265, 27);
            this.textBoxSendMessage.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.btn_send);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.textBoxSendMessage);
            this.groupBox3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(5, 219);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(279, 104);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "发送信息";
            // 
            // btnStartServer
            // 
            this.btnStartServer.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStartServer.Location = new System.Drawing.Point(144, 121);
            this.btnStartServer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStartServer.Name = "btnStartServer";
            this.btnStartServer.Size = new System.Drawing.Size(104, 32);
            this.btnStartServer.TabIndex = 0;
            this.btnStartServer.Text = "监听";
            this.btnStartServer.UseVisualStyleBackColor = true;
            this.btnStartServer.Click += new System.EventHandler(this.btnStartServer_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.端口号);
            this.groupBox4.Controls.Add(this.IP地址);
            this.groupBox4.Controls.Add(this.IPADDress);
            this.groupBox4.Controls.Add(this.Porttext);
            this.groupBox4.Controls.Add(this.btnStartServer);
            this.groupBox4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox4.Location = new System.Drawing.Point(5, 22);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(279, 170);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "TCP连接";
            // 
            // 端口号
            // 
            this.端口号.AutoSize = true;
            this.端口号.Location = new System.Drawing.Point(23, 86);
            this.端口号.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.端口号.Name = "端口号";
            this.端口号.Size = new System.Drawing.Size(84, 20);
            this.端口号.TabIndex = 10;
            this.端口号.Text = "本地端口号";
            // 
            // IP地址
            // 
            this.IP地址.AutoSize = true;
            this.IP地址.Location = new System.Drawing.Point(24, 38);
            this.IP地址.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IP地址.Name = "IP地址";
            this.IP地址.Size = new System.Drawing.Size(82, 20);
            this.IP地址.TabIndex = 9;
            this.IP地址.Text = "本机IP地址";
            // 
            // IPADDress
            // 
            this.IPADDress.Location = new System.Drawing.Point(115, 34);
            this.IPADDress.Margin = new System.Windows.Forms.Padding(4);
            this.IPADDress.Name = "IPADDress";
            this.IPADDress.Size = new System.Drawing.Size(132, 27);
            this.IPADDress.TabIndex = 8;
            // 
            // Porttext
            // 
            this.Porttext.Location = new System.Drawing.Point(115, 82);
            this.Porttext.Margin = new System.Windows.Forms.Padding(4);
            this.Porttext.Name = "Porttext";
            this.Porttext.Size = new System.Drawing.Size(132, 27);
            this.Porttext.TabIndex = 2;
            // 
            // btnClearControlText
            // 
            this.btnClearControlText.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClearControlText.Location = new System.Drawing.Point(155, 26);
            this.btnClearControlText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClearControlText.Name = "btnClearControlText";
            this.btnClearControlText.Size = new System.Drawing.Size(117, 35);
            this.btnClearControlText.TabIndex = 1;
            this.btnClearControlText.Text = "清空控制信息";
            this.btnClearControlText.UseVisualStyleBackColor = true;
            this.btnClearControlText.Click += new System.EventHandler(this.btnClearControlText_Click);
            // 
            // btnClearCommunicateText
            // 
            this.btnClearCommunicateText.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClearCommunicateText.Location = new System.Drawing.Point(7, 26);
            this.btnClearCommunicateText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClearCommunicateText.Name = "btnClearCommunicateText";
            this.btnClearCommunicateText.Size = new System.Drawing.Size(117, 35);
            this.btnClearCommunicateText.TabIndex = 2;
            this.btnClearCommunicateText.Text = "清空接收信息";
            this.btnClearCommunicateText.UseVisualStyleBackColor = true;
            this.btnClearCommunicateText.Click += new System.EventHandler(this.btnClearCommunicateText_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.btnClearControlText);
            this.groupBox8.Controls.Add(this.btnClearCommunicateText);
            this.groupBox8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox8.Location = new System.Drawing.Point(5, 345);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox8.Size = new System.Drawing.Size(279, 69);
            this.groupBox8.TabIndex = 4;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "信息清空";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox8);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(29, 21);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(291, 426);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "功能区";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 461);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TCP服务端";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstServerCommunicationText;
        private System.Windows.Forms.ListBox lstControlText;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBoxSendMessage;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnStartServer;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnClearControlText;
        private System.Windows.Forms.Button btnClearCommunicateText;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox IPADDress;
        private System.Windows.Forms.TextBox Porttext;
        private System.Windows.Forms.Label IP地址;
        private System.Windows.Forms.Label 端口号;
    }
}

