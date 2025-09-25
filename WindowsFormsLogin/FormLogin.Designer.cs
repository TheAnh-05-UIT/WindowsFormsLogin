namespace WindowsFormsLogin
{
    partial class FormLogin
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
            this.btn_Login = new System.Windows.Forms.Button();
            this.lbl_Login = new System.Windows.Forms.Label();
            this.lbl_UserNameLogin = new System.Windows.Forms.Label();
            this.lbl_PasswordLogin = new System.Windows.Forms.Label();
            this.txt_UserNameLogin = new System.Windows.Forms.TextBox();
            this.txt_PasswordLogin = new System.Windows.Forms.TextBox();
            this.lbl_NotAMem = new System.Windows.Forms.Label();
            this.lbl_SignUpNow = new System.Windows.Forms.Label();
            this.lklbl_SignUpNow = new System.Windows.Forms.LinkLabel();
            this.chk_ShowPassword = new System.Windows.Forms.CheckBox();
            this.lklbl_ForgotPassword = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btn_Login
            // 
            this.btn_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.Location = new System.Drawing.Point(309, 337);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(159, 53);
            this.btn_Login.TabIndex = 3;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // lbl_Login
            // 
            this.lbl_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login.Location = new System.Drawing.Point(304, 47);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(164, 68);
            this.lbl_Login.TabIndex = 4;
            this.lbl_Login.Text = "Login";
            this.lbl_Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_UserNameLogin
            // 
            this.lbl_UserNameLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserNameLogin.Location = new System.Drawing.Point(94, 140);
            this.lbl_UserNameLogin.Name = "lbl_UserNameLogin";
            this.lbl_UserNameLogin.Size = new System.Drawing.Size(173, 49);
            this.lbl_UserNameLogin.TabIndex = 5;
            this.lbl_UserNameLogin.Text = "UserName";
            this.lbl_UserNameLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_PasswordLogin
            // 
            this.lbl_PasswordLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PasswordLogin.Location = new System.Drawing.Point(94, 213);
            this.lbl_PasswordLogin.Name = "lbl_PasswordLogin";
            this.lbl_PasswordLogin.Size = new System.Drawing.Size(173, 49);
            this.lbl_PasswordLogin.TabIndex = 6;
            this.lbl_PasswordLogin.Text = "Password";
            this.lbl_PasswordLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_UserNameLogin
            // 
            this.txt_UserNameLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UserNameLogin.Location = new System.Drawing.Point(309, 154);
            this.txt_UserNameLogin.Name = "txt_UserNameLogin";
            this.txt_UserNameLogin.Size = new System.Drawing.Size(368, 26);
            this.txt_UserNameLogin.TabIndex = 7;
            this.txt_UserNameLogin.TextChanged += new System.EventHandler(this.txt_UserNameLogin_TextChanged);
            // 
            // txt_PasswordLogin
            // 
            this.txt_PasswordLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PasswordLogin.Location = new System.Drawing.Point(309, 227);
            this.txt_PasswordLogin.Name = "txt_PasswordLogin";
            this.txt_PasswordLogin.Size = new System.Drawing.Size(273, 26);
            this.txt_PasswordLogin.TabIndex = 8;
            this.txt_PasswordLogin.TextChanged += new System.EventHandler(this.txt_PasswordLogin_TextChanged);
            // 
            // lbl_NotAMem
            // 
            this.lbl_NotAMem.AutoSize = true;
            this.lbl_NotAMem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_NotAMem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NotAMem.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_NotAMem.Location = new System.Drawing.Point(305, 408);
            this.lbl_NotAMem.Name = "lbl_NotAMem";
            this.lbl_NotAMem.Size = new System.Drawing.Size(118, 20);
            this.lbl_NotAMem.TabIndex = 9;
            this.lbl_NotAMem.Text = "Not a member?";
            this.lbl_NotAMem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_NotAMem.Click += new System.EventHandler(this.lbl_NotAMem_Click);
            // 
            // lbl_SignUpNow
            // 
            this.lbl_SignUpNow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_SignUpNow.Location = new System.Drawing.Point(305, 439);
            this.lbl_SignUpNow.Name = "lbl_SignUpNow";
            this.lbl_SignUpNow.Size = new System.Drawing.Size(107, 32);
            this.lbl_SignUpNow.TabIndex = 10;
            this.lbl_SignUpNow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lklbl_SignUpNow
            // 
            this.lklbl_SignUpNow.AutoSize = true;
            this.lklbl_SignUpNow.Location = new System.Drawing.Point(305, 439);
            this.lklbl_SignUpNow.Name = "lklbl_SignUpNow";
            this.lklbl_SignUpNow.Size = new System.Drawing.Size(96, 20);
            this.lklbl_SignUpNow.TabIndex = 11;
            this.lklbl_SignUpNow.TabStop = true;
            this.lklbl_SignUpNow.Text = "Sign up now";
            this.lklbl_SignUpNow.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklbl_SignUpNow_LinkClicked);
            // 
            // chk_ShowPassword
            // 
            this.chk_ShowPassword.AutoSize = true;
            this.chk_ShowPassword.Location = new System.Drawing.Point(602, 229);
            this.chk_ShowPassword.Name = "chk_ShowPassword";
            this.chk_ShowPassword.Size = new System.Drawing.Size(75, 24);
            this.chk_ShowPassword.TabIndex = 12;
            this.chk_ShowPassword.Text = "Show";
            this.chk_ShowPassword.UseVisualStyleBackColor = true;
            this.chk_ShowPassword.CheckedChanged += new System.EventHandler(this.chk_ShowPassword_CheckedChanged);
            // 
            // lklbl_ForgotPassword
            // 
            this.lklbl_ForgotPassword.AutoSize = true;
            this.lklbl_ForgotPassword.Location = new System.Drawing.Point(539, 289);
            this.lklbl_ForgotPassword.Name = "lklbl_ForgotPassword";
            this.lklbl_ForgotPassword.Size = new System.Drawing.Size(138, 20);
            this.lklbl_ForgotPassword.TabIndex = 13;
            this.lklbl_ForgotPassword.TabStop = true;
            this.lklbl_ForgotPassword.Text = "Forgot Password?";
            this.lklbl_ForgotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklbl_ForgotPassword_LinkClicked);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 505);
            this.Controls.Add(this.lklbl_ForgotPassword);
            this.Controls.Add(this.chk_ShowPassword);
            this.Controls.Add(this.lklbl_SignUpNow);
            this.Controls.Add(this.lbl_SignUpNow);
            this.Controls.Add(this.lbl_NotAMem);
            this.Controls.Add(this.txt_PasswordLogin);
            this.Controls.Add(this.txt_UserNameLogin);
            this.Controls.Add(this.lbl_PasswordLogin);
            this.Controls.Add(this.lbl_UserNameLogin);
            this.Controls.Add(this.lbl_Login);
            this.Controls.Add(this.btn_Login);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.Label lbl_UserNameLogin;
        private System.Windows.Forms.Label lbl_PasswordLogin;
        private System.Windows.Forms.TextBox txt_UserNameLogin;
        private System.Windows.Forms.TextBox txt_PasswordLogin;
        private System.Windows.Forms.Label lbl_NotAMem;
        private System.Windows.Forms.Label lbl_SignUpNow;
        private System.Windows.Forms.LinkLabel lklbl_SignUpNow;
        private System.Windows.Forms.CheckBox chk_ShowPassword;
        private System.Windows.Forms.LinkLabel lklbl_ForgotPassword;
    }
}