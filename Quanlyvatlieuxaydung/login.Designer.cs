namespace Quanlyvatlieuxaydung
{
    partial class login
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
            this.labelregister = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.shwpasswd1 = new System.Windows.Forms.CheckBox();
            this.bt_clear = new System.Windows.Forms.Button();
            this.txtpasswd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_login = new System.Windows.Forms.Button();
            this.bt_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelregister
            // 
            this.labelregister.AutoSize = true;
            this.labelregister.BackColor = System.Drawing.Color.White;
            this.labelregister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelregister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.labelregister.Location = new System.Drawing.Point(184, 580);
            this.labelregister.Name = "labelregister";
            this.labelregister.Size = new System.Drawing.Size(93, 28);
            this.labelregister.TabIndex = 21;
            this.labelregister.Text = "Đăng ký";
            this.labelregister.Click += new System.EventHandler(this.labelregister_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label5.Location = new System.Drawing.Point(141, 541);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 28);
            this.label5.TabIndex = 22;
            this.label5.Text = "Chưa có tài khoản?";
            // 
            // shwpasswd1
            // 
            this.shwpasswd1.AutoSize = true;
            this.shwpasswd1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.shwpasswd1.Location = new System.Drawing.Point(241, 393);
            this.shwpasswd1.Name = "shwpasswd1";
            this.shwpasswd1.Size = new System.Drawing.Size(183, 32);
            this.shwpasswd1.TabIndex = 3;
            this.shwpasswd1.Text = "Hiện mật khẩu";
            this.shwpasswd1.UseVisualStyleBackColor = true;
            this.shwpasswd1.CheckedChanged += new System.EventHandler(this.shwpasswd1_CheckedChanged);
            // 
            // bt_clear
            // 
            this.bt_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.bt_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_clear.ForeColor = System.Drawing.Color.White;
            this.bt_clear.Location = new System.Drawing.Point(241, 451);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(143, 60);
            this.bt_clear.TabIndex = 5;
            this.bt_clear.Text = "Làm trống";
            this.bt_clear.UseVisualStyleBackColor = false;
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click);
            // 
            // txtpasswd
            // 
            this.txtpasswd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtpasswd.ForeColor = System.Drawing.Color.Black;
            this.txtpasswd.Location = new System.Drawing.Point(72, 328);
            this.txtpasswd.Multiline = true;
            this.txtpasswd.Name = "txtpasswd";
            this.txtpasswd.PasswordChar = '*';
            this.txtpasswd.Size = new System.Drawing.Size(216, 28);
            this.txtpasswd.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label3.Location = new System.Drawing.Point(67, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 28);
            this.label3.TabIndex = 16;
            this.label3.Text = "Mật khẩu";
            // 
            // txtusername
            // 
            this.txtusername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtusername.ForeColor = System.Drawing.Color.Black;
            this.txtusername.Location = new System.Drawing.Point(72, 219);
            this.txtusername.Multiline = true;
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(216, 28);
            this.txtusername.TabIndex = 1;
            this.txtusername.TextChanged += new System.EventHandler(this.txtusername_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label2.Location = new System.Drawing.Point(67, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 28);
            this.label2.TabIndex = 13;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(116, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 45);
            this.label1.TabIndex = 11;
            this.label1.Text = "Đăng nhập";
            // 
            // bt_login
            // 
            this.bt_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.bt_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_login.ForeColor = System.Drawing.Color.White;
            this.bt_login.Location = new System.Drawing.Point(72, 451);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(143, 60);
            this.bt_login.TabIndex = 4;
            this.bt_login.Text = "Đăng nhập";
            this.bt_login.UseVisualStyleBackColor = false;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // bt_exit
            // 
            this.bt_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_exit.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.bt_exit.Location = new System.Drawing.Point(384, -10);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(40, 40);
            this.bt_exit.TabIndex = 23;
            this.bt_exit.Text = "x";
            this.bt_exit.UseVisualStyleBackColor = true;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(428, 648);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.labelregister);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.shwpasswd1);
            this.Controls.Add(this.bt_clear);
            this.Controls.Add(this.bt_login);
            this.Controls.Add(this.txtpasswd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelregister;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox shwpasswd1;
        private System.Windows.Forms.Button bt_clear;
        private System.Windows.Forms.TextBox txtpasswd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_login;
        private System.Windows.Forms.Button bt_exit;
    }
}