namespace ProjektSK
{
    partial class Chat
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
            this.btn_send = new System.Windows.Forms.Button();
            this.txt_wiad = new System.Windows.Forms.TextBox();
            this.lst_wiad = new System.Windows.Forms.ListBox();
            this.btn_zapisz = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_port2 = new System.Windows.Forms.TextBox();
            this.txt_ip2 = new System.Windows.Forms.TextBox();
            this.lbl_port2 = new System.Windows.Forms.Label();
            this.lbl_ip2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_port1 = new System.Windows.Forms.TextBox();
            this.txt_ip1 = new System.Windows.Forms.TextBox();
            this.lbl_port = new System.Windows.Forms.Label();
            this.lbl_ip = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_send
            // 
            this.btn_send.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(107)))), ((int)(((byte)(31)))));
            this.btn_send.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_send.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_send.Location = new System.Drawing.Point(425, 487);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 17;
            this.btn_send.Text = "Wyślij";
            this.btn_send.UseVisualStyleBackColor = false;
            this.btn_send.Click += new System.EventHandler(this.Btn_send_Click_1);
            // 
            // txt_wiad
            // 
            this.txt_wiad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(107)))), ((int)(((byte)(31)))));
            this.txt_wiad.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_wiad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_wiad.Location = new System.Drawing.Point(25, 488);
            this.txt_wiad.Name = "txt_wiad";
            this.txt_wiad.Size = new System.Drawing.Size(396, 22);
            this.txt_wiad.TabIndex = 16;
            this.txt_wiad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_wiad_KeyDown_1);
            // 
            // lst_wiad
            // 
            this.lst_wiad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(107)))), ((int)(((byte)(31)))));
            this.lst_wiad.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lst_wiad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lst_wiad.FormattingEnabled = true;
            this.lst_wiad.ItemHeight = 14;
            this.lst_wiad.Location = new System.Drawing.Point(25, 211);
            this.lst_wiad.Name = "lst_wiad";
            this.lst_wiad.Size = new System.Drawing.Size(475, 256);
            this.lst_wiad.TabIndex = 15;
            // 
            // btn_zapisz
            // 
            this.btn_zapisz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(107)))), ((int)(((byte)(31)))));
            this.btn_zapisz.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_zapisz.ForeColor = System.Drawing.Color.White;
            this.btn_zapisz.Location = new System.Drawing.Point(425, 179);
            this.btn_zapisz.Name = "btn_zapisz";
            this.btn_zapisz.Size = new System.Drawing.Size(75, 23);
            this.btn_zapisz.TabIndex = 14;
            this.btn_zapisz.Text = "Połącz";
            this.btn_zapisz.UseVisualStyleBackColor = false;
            this.btn_zapisz.Click += new System.EventHandler(this.Btn_zapisz_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_port2);
            this.groupBox2.Controls.Add(this.txt_ip2);
            this.groupBox2.Controls.Add(this.lbl_port2);
            this.groupBox2.Controls.Add(this.lbl_ip2);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(267, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 125);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kolega";
            // 
            // txt_port2
            // 
            this.txt_port2.Location = new System.Drawing.Point(54, 50);
            this.txt_port2.Name = "txt_port2";
            this.txt_port2.Size = new System.Drawing.Size(100, 22);
            this.txt_port2.TabIndex = 5;
            // 
            // txt_ip2
            // 
            this.txt_ip2.Location = new System.Drawing.Point(54, 20);
            this.txt_ip2.Name = "txt_ip2";
            this.txt_ip2.Size = new System.Drawing.Size(100, 22);
            this.txt_ip2.TabIndex = 4;
            // 
            // lbl_port2
            // 
            this.lbl_port2.AutoSize = true;
            this.lbl_port2.Location = new System.Drawing.Point(6, 53);
            this.lbl_port2.Name = "lbl_port2";
            this.lbl_port2.Size = new System.Drawing.Size(35, 14);
            this.lbl_port2.TabIndex = 3;
            this.lbl_port2.Text = "Port";
            // 
            // lbl_ip2
            // 
            this.lbl_ip2.AutoSize = true;
            this.lbl_ip2.Location = new System.Drawing.Point(7, 20);
            this.lbl_ip2.Name = "lbl_ip2";
            this.lbl_ip2.Size = new System.Drawing.Size(21, 14);
            this.lbl_ip2.TabIndex = 2;
            this.lbl_ip2.Text = "IP";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_port1);
            this.groupBox1.Controls.Add(this.txt_ip1);
            this.groupBox1.Controls.Add(this.lbl_port);
            this.groupBox1.Controls.Add(this.lbl_ip);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(25, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 125);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ja";
            // 
            // txt_port1
            // 
            this.txt_port1.Location = new System.Drawing.Point(56, 53);
            this.txt_port1.Name = "txt_port1";
            this.txt_port1.Size = new System.Drawing.Size(100, 22);
            this.txt_port1.TabIndex = 3;
            // 
            // txt_ip1
            // 
            this.txt_ip1.Location = new System.Drawing.Point(56, 20);
            this.txt_ip1.Name = "txt_ip1";
            this.txt_ip1.Size = new System.Drawing.Size(100, 22);
            this.txt_ip1.TabIndex = 2;
            // 
            // lbl_port
            // 
            this.lbl_port.AutoSize = true;
            this.lbl_port.Location = new System.Drawing.Point(6, 53);
            this.lbl_port.Name = "lbl_port";
            this.lbl_port.Size = new System.Drawing.Size(35, 14);
            this.lbl_port.TabIndex = 1;
            this.lbl_port.Text = "Port";
            // 
            // lbl_ip
            // 
            this.lbl_ip.AutoSize = true;
            this.lbl_ip.Location = new System.Drawing.Point(7, 20);
            this.lbl_ip.Name = "lbl_ip";
            this.lbl_ip.Size = new System.Drawing.Size(21, 14);
            this.lbl_ip.TabIndex = 0;
            this.lbl_ip.Text = "IP";
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(525, 558);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.txt_wiad);
            this.Controls.Add(this.lst_wiad);
            this.Controls.Add(this.btn_zapisz);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "Chat";
            this.Text = "Chat";
            this.Load += new System.EventHandler(this.Chat_Load_1);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.TextBox txt_wiad;
        private System.Windows.Forms.ListBox lst_wiad;
        private System.Windows.Forms.Button btn_zapisz;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_port2;
        private System.Windows.Forms.TextBox txt_ip2;
        private System.Windows.Forms.Label lbl_port2;
        private System.Windows.Forms.Label lbl_ip2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_port1;
        private System.Windows.Forms.TextBox txt_ip1;
        private System.Windows.Forms.Label lbl_port;
        private System.Windows.Forms.Label lbl_ip;
    }
}