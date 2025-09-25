using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsLogin
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            using (var conn = Database.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM users WHERE username=@user AND password=@pass";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@user", txt_UserNameLogin.Text);
                    cmd.Parameters.AddWithValue("@pass", txt_PasswordLogin.Text);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        MessageBox.Show("Đăng nhập thành công!",
                            "Confirm",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        // mở form chính
                        FormMain main = new FormMain();
                        main.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Sai tài khoản hoặc mật khẩu!",
                            "Warning",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void lklbl_SignUpNow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegister register = new FormRegister();
            register.Show();
            this.Hide();
            //FormLogin login = new FormLogin();
            //login.Close();
        }

        private void lbl_NotAMem_Click(object sender, EventArgs e)
        {

        }

        private void txt_UserNameLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void chk_ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_ShowPassword.Checked) { 
                txt_PasswordLogin.UseSystemPasswordChar = false;
            }
            else
            {
                txt_PasswordLogin.UseSystemPasswordChar= true;
            }
        }

        private void txt_PasswordLogin_TextChanged(object sender, EventArgs e)
        {
            if (chk_ShowPassword.Checked == false) {
                txt_PasswordLogin.UseSystemPasswordChar = true;
            }
            else
            {
                txt_PasswordLogin.UseSystemPasswordChar= false;
            }
        }

        private void lklbl_ForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormForgotPassword forgotPassword = new FormForgotPassword();
            forgotPassword.Show();
            this.Hide();
        }
    }
}
