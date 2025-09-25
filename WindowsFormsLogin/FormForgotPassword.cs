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
    public partial class FormForgotPassword : Form
    {
        public FormForgotPassword()
        {
            InitializeComponent();
        }

        private void lklbl_Login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Hide();
        }

        private void txt_EmailGetOTP_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_GetOTP_Click(object sender, EventArgs e)
        {
            using (var conn = Database.GetConnection()) 
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM users WHERE email = @email";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@email", txt_EmailGetOTP.Text);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        string email = txt_EmailGetOTP.Text;
                        FormResetPassword resetPassword = new FormResetPassword(email);
                        resetPassword.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show(
                            "Không tìm thấy Email hợp lệ. vui lòng nhập Email lúc đăng ký tài khoản!",
                            "Warning",
                            MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi" + ex.Message);
                }
            }
        }
        public string getEmail()
        {
            string email = txt_EmailGetOTP.Text;
            return email;
        }
    }
}
