using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsLogin
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {

        }

        private void lbl_ConfirmPassword_Click(object sender, EventArgs e)
        {

        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            using (var conn = Database.GetConnection())
            {
                try
                {
                    conn.Open();
                    // câu lệnh SQL thêm dữ liệu vào bảng
                    string query = "INSERT INTO users (username, password, email) VALUES (@user, @pass, @email)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@user", txt_UserName.Text);
                    cmd.Parameters.AddWithValue("@pass", txt_Password.Text); // Nên mã hoá mật khẩu
                    cmd.Parameters.AddWithValue("@email", txt_Email.Text);

                    if (lbl_CheckName.Visible == false &&
                       lbl_CheckUser.Visible == false &&
                       lbl_CheckEmail.Visible == false &&
                       lbl_CheckPassword.Visible == false &&
                       lbl_CheckCFpassword.Visible == false &&
                       txt_Name.Text.Length != 0 &&
                       txt_UserName.Text.Length != 0 &&
                       txt_Email.Text.Length != 0 &&
                       txt_Password.Text.Length != 0 &&
                       txt_ConfirmPassword.Text.Length != 0
                       )
                    {
                        cmd.ExecuteNonQuery(); // thực hiện câu lệnh SQL 
                        MessageBox.Show(
                        "Đăng ký thành công!",
                        "Confirm",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                        //this.Close(); // Đóng form đăng ký
                        FormLogin login = new FormLogin();
                        login.Show(); // mở form đăng ký dạng modal (chặn ngoài)
                        this.Hide();
                    }
                    else
                    {
                        if (lbl_CheckName.Visible == true || txt_Name.Text.Length == 0)
                        {
                            DialogResult result = MessageBox.Show(
                                "Kiểm tra lại Name!",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                        else if (lbl_CheckUser.Visible == true || txt_UserName.Text.Length == 0)
                        {
                            DialogResult result = MessageBox.Show(
                                "Kiểm tra lại UserName!",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                        else if (lbl_CheckEmail.Visible == true || txt_Email.Text.Length == 0)
                        {
                            DialogResult result = MessageBox.Show(
                                "Kiểm tra lại Email!",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                        else if(lbl_CheckPassword.Visible == true || txt_Password.Text.Length == 0)
                        {
                            DialogResult result = MessageBox.Show(
                                "Kiểm tra lại Password!",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                        else if (lbl_CheckCFpassword.Visible == true || txt_ConfirmPassword.Text.Length == 0)
                        {
                            DialogResult result = MessageBox.Show(
                                "Kiểm tra lại Confirm Password!",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void txt_Email_TextChanged(object sender, EventArgs e)
        {
            // regex cho email
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            string email = txt_Email.Text;
            //if(!Regex.IsMatch(email, pattern))
            //{
            //    lbl_CheckEmail.Text = "Email không hợp lệ!";
            //    lbl_CheckEmail.Visible = true;// hiển thị lên winform
            //}
            //else
            //{
            //    lbl_CheckEmail.Visible = false;
            //}
            using (var conn = Database.GetConnection()) 
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM users WHERE email = @email";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@email", txt_Email.Text);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows && Regex.IsMatch(email, pattern)) 
                    {
                        lbl_CheckEmail.Text = "Email đã tồn tại";
                        lbl_CheckEmail.Visible = true;
                    }
                    else if(!Regex.IsMatch(email, pattern))
                    {
                        lbl_CheckEmail.Text = "Định dạng Email không hợp lệ";
                        lbl_CheckEmail.Visible = true;
                    }
                    else
                    {
                        lbl_CheckEmail.Visible = false;
                    }
                }
                catch (Exception ex) 
                {
                    MessageBox.Show("Lỗi" + ex.Message );
                }
            }
        }

        private void txt_Password_TextChanged(object sender, EventArgs e)
        {
            if(chk_ShowPassword.Checked == false)
            {
                // ẩn các kí tự trong password
                txt_Password.UseSystemPasswordChar = true;
            }
            else
            {
                // hiển thị các kí tự trong password
                txt_Password.UseSystemPasswordChar = false;
            }
            //string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[A-Za-z\d@$!%*?&]{8,}$";
            string password = txt_Password.Text;
            if(!Regex.IsMatch(password, pattern))
            {
                lbl_CheckPassword.Font = new Font(
                    lbl_CheckPassword.Name,
                    8,
                    lbl_CheckPassword.Font.Style);
                lbl_CheckPassword.ForeColor = Color.Red;
                lbl_CheckPassword.Text = "Mật khẩu gồm có 8 kí tự, bao gồm chữ hoa, chữ thường và số";
                lbl_CheckPassword.Visible = true;
            }
            else
            {
                lbl_CheckPassword.Visible = false;
            }
        }

        private void lbl_Password_Click(object sender, EventArgs e)
        {

        }

        private void txt_ConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (chk_ShowCFPassword.Checked == false)
            {
                txt_ConfirmPassword.UseSystemPasswordChar = true;
            }    
            else
            {
                txt_ConfirmPassword.UseSystemPasswordChar = false;
            }    
            string password = txt_Password.Text;
            string confirm = txt_ConfirmPassword.Text;
            if (!confirm.Equals(password)) {
                lbl_CheckCFpassword.Text = "Mật khẩu không đúng, vui lòng nhập lại.";
                lbl_CheckCFpassword.Visible = true;
            }
            else
            {
                lbl_CheckCFpassword.Visible = false;
            }
        }

        private void chk_ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_ShowPassword.Checked)
            {
                txt_Password.UseSystemPasswordChar = false;// mở các kí tự password
            }
            else
            {
                txt_Password.UseSystemPasswordChar = true;// ẩn các kí tự password
            }
        }

        private void chk_ShowCFPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_ShowCFPassword.Checked)
            {
                txt_ConfirmPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txt_ConfirmPassword.UseSystemPasswordChar = true;
            }
        }

        private void txt_UserName_TextChanged(object sender, EventArgs e)
        {
            string Parttern = @"^[a-zA-Z0-9_]{5,20}$";
            string UserName = txt_UserName.Text;
            using (var conn = Database.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM users WHERE username=@user";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@user", txt_UserName.Text);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (Regex.IsMatch(UserName, Parttern) && reader.HasRows)
                    {
                        lbl_CheckUser.Text = "Xin lỗi, User đã được sử dụng. Vui lòng thử lại.";
                        lbl_CheckUser.Visible = true;
                    }
                    else if(!Regex.IsMatch(UserName, Parttern))
                    {
                        lbl_CheckUser.Text = "User có 5 - 20 kí tự bao gồm chữ hoa, chữ thường, số và kí tự gạch dưới \nkhông bao gồm khoảng trắng.";
                        lbl_CheckUser.Visible = true;
                    }
                    else
                    {
                        lbl_CheckUser.Visible=false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void lbl_UserName_Click(object sender, EventArgs e)
        {

        }

        private void txt_Name_TextChanged(object sender, EventArgs e)
        {
            if (txt_Name.Text.Length >= 5)
            {
                lbl_CheckName.Visible = false;
            }
            else 
            {
                lbl_CheckName.Text = "Name ít nhất 5 kí tự";
                lbl_CheckName.Visible = true;    
            }
        }
    }
}
