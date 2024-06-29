using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlyvatlieuxaydung
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        databasetestDataContext db = new databasetestDataContext();
        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }
        private void bt_exit_Click(object sender, EventArgs e)
        {
          this.Dispose();
        }

        private void bt_clear_Click(object sender, EventArgs e)
        {
            txtusername.Text = string.Empty;
            txtpasswd.Text = string.Empty;


        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtusername.Text) || string.IsNullOrEmpty(txtpasswd.Text))
            {
                MessageBox.Show("Vui lòng nhập email hoặc mật khẩu", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                var authen = db.users.FirstOrDefault(u => u.email == txtusername.Text && u.passwd == txtpasswd.Text);
                if (authen != null)
                {
                    // hien thi dash board
                    MessageBox.Show("","",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Mật khẩu hoặc tài khoản không chính xác","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            

            
        }
        private void labelregister_Click(object sender, EventArgs e)
        {
            new DangKy().Show();
            this.Hide();
        }

        private void shwpasswd1_CheckedChanged(object sender, EventArgs e)
        {
            var show = shwpasswd1.Checked;
            if (show)
            {
                txtpasswd.PasswordChar = '\0';
            }
            else
            {
                txtpasswd.PasswordChar = '*';
            }
        }
    }
}
