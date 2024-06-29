using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlyvatlieuxaydung
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }
        databasetestDataContext db = new databasetestDataContext();
        private void bt_register_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(rusrname.Text) || string.IsNullOrEmpty(rpasswd.Text) || string.IsNullOrEmpty(cfpasswd.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(rpasswd.Text != cfpasswd.Text)
            {
                MessageBox.Show("Lỗi xác nhận mật khẩu","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var checkDuplicate = db.users.FirstOrDefault(u => u.email == rusrname.Text);

                if (checkDuplicate !=null)
                {
                    MessageBox.Show("Email này đã được đăng ký ","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    db.users.InsertOnSubmit(new user
                    {
                        email = rusrname.Text,
                        passwd = rpasswd.Text,
                    });
                    db.SubmitChanges();
                    DialogResult result = MessageBox.Show("Đăng ký thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bool check = (result == DialogResult.OK);
                    if (check)
                    {
                        new login().Show();
                        this.Hide();
                    }
                }
            }
        }
        private void bt_clear_Click(object sender, EventArgs e)
        {
            rusrname.Text = string.Empty;
            rpasswd.Text = string.Empty;
            cfpasswd.Text= string.Empty;
        }
        private void shwpasswd_CheckedChanged(object sender, EventArgs e)
        {
            var show =shwpasswd.Checked;
            if (show)
            {
                cfpasswd.PasswordChar = '\0';
                rpasswd.PasswordChar = '\0';
            }
            else
            {
                cfpasswd.PasswordChar = '*';
                rpasswd.PasswordChar = '*';
            }
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            new login().Show();
            this.Hide();
        }
    }
}
