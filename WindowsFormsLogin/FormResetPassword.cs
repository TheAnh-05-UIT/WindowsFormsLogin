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
    public partial class FormResetPassword : Form
    {
        private string _email;

        public FormResetPassword(string email)
        {
            InitializeComponent();
            _email = email;
        }
        
        private void FormResetPassword_Load(object sender, EventArgs e)
        {
            lbl_ResetPassword.Text = _email;
        }
        private void btn_GuiMaOTP_Click(object sender, EventArgs e)
        {
            FormForgotPassword formForgot = new FormForgotPassword();
            string emailGetOTP = formForgot.getEmail();
            Console.WriteLine(emailGetOTP.Length);
        }

        private void txt_OTP_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
