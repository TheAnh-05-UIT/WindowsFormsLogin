namespace WindowsFormsLogin
{
    partial class FormRegister
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
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_ConfirmPassword = new System.Windows.Forms.Label();
            this.lbl_SignIn = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.btn_Register = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.lbl_CheckEmail = new System.Windows.Forms.Label();
            this.lbl_CheckPassword = new System.Windows.Forms.Label();
            this.lbl_CheckCFpassword = new System.Windows.Forms.Label();
            this.chk_ShowPassword = new System.Windows.Forms.CheckBox();
            this.chk_ShowCFPassword = new System.Windows.Forms.CheckBox();
            this.lbl_CheckUser = new System.Windows.Forms.Label();
            this.lbl_CheckName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Name
            // 
            this.lbl_Name.Location = new System.Drawing.Point(98, 108);
            this.lbl_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(179, 42);
            this.lbl_Name.TabIndex = 1;
            this.lbl_Name.Text = "Name";
            this.lbl_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Email
            // 
            this.lbl_Email.Location = new System.Drawing.Point(98, 269);
            this.lbl_Email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(179, 42);
            this.lbl_Email.TabIndex = 7;
            this.lbl_Email.Text = "Email";
            this.lbl_Email.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Password
            // 
            this.lbl_Password.Location = new System.Drawing.Point(98, 355);
            this.lbl_Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(179, 42);
            this.lbl_Password.TabIndex = 10;
            this.lbl_Password.Text = "Password";
            this.lbl_Password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Password.Click += new System.EventHandler(this.lbl_Password_Click);
            // 
            // lbl_ConfirmPassword
            // 
            this.lbl_ConfirmPassword.Location = new System.Drawing.Point(98, 440);
            this.lbl_ConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ConfirmPassword.Name = "lbl_ConfirmPassword";
            this.lbl_ConfirmPassword.Size = new System.Drawing.Size(179, 42);
            this.lbl_ConfirmPassword.TabIndex = 14;
            this.lbl_ConfirmPassword.Text = "Confirm Password";
            this.lbl_ConfirmPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_ConfirmPassword.Click += new System.EventHandler(this.lbl_ConfirmPassword_Click);
            // 
            // lbl_SignIn
            // 
            this.lbl_SignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SignIn.Location = new System.Drawing.Point(312, 9);
            this.lbl_SignIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_SignIn.Name = "lbl_SignIn";
            this.lbl_SignIn.Size = new System.Drawing.Size(240, 53);
            this.lbl_SignIn.TabIndex = 0;
            this.lbl_SignIn.Text = "Sign In";
            this.lbl_SignIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(317, 114);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(452, 30);
            this.txt_Name.TabIndex = 2;
            this.txt_Name.TextChanged += new System.EventHandler(this.txt_Name_TextChanged);
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(317, 194);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(452, 30);
            this.txt_UserName.TabIndex = 5;
            this.txt_UserName.TextChanged += new System.EventHandler(this.txt_UserName_TextChanged);
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(317, 275);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(452, 30);
            this.txt_Email.TabIndex = 8;
            this.txt_Email.TextChanged += new System.EventHandler(this.txt_Email_TextChanged);
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(317, 361);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(339, 30);
            this.txt_Password.TabIndex = 11;
            this.txt_Password.TextChanged += new System.EventHandler(this.txt_Password_TextChanged);
            // 
            // txt_ConfirmPassword
            // 
            this.txt_ConfirmPassword.Location = new System.Drawing.Point(317, 446);
            this.txt_ConfirmPassword.Name = "txt_ConfirmPassword";
            this.txt_ConfirmPassword.Size = new System.Drawing.Size(339, 30);
            this.txt_ConfirmPassword.TabIndex = 15;
            this.txt_ConfirmPassword.TextChanged += new System.EventHandler(this.txt_ConfirmPassword_TextChanged);
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.Location = new System.Drawing.Point(98, 188);
            this.lbl_UserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(179, 42);
            this.lbl_UserName.TabIndex = 4;
            this.lbl_UserName.Text = "UserName";
            this.lbl_UserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_UserName.Click += new System.EventHandler(this.lbl_UserName_Click);
            // 
            // btn_Register
            // 
            this.btn_Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Register.Location = new System.Drawing.Point(317, 528);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(177, 61);
            this.btn_Register.TabIndex = 18;
            this.btn_Register.Text = "Register";
            this.btn_Register.UseVisualStyleBackColor = true;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(639, 538);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(130, 41);
            this.btn_Exit.TabIndex = 19;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            // 
            // lbl_CheckEmail
            // 
            this.lbl_CheckEmail.AutoSize = true;
            this.lbl_CheckEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CheckEmail.ForeColor = System.Drawing.Color.Red;
            this.lbl_CheckEmail.Location = new System.Drawing.Point(317, 308);
            this.lbl_CheckEmail.Name = "lbl_CheckEmail";
            this.lbl_CheckEmail.Size = new System.Drawing.Size(0, 20);
            this.lbl_CheckEmail.TabIndex = 9;
            this.lbl_CheckEmail.Visible = false;
            // 
            // lbl_CheckPassword
            // 
            this.lbl_CheckPassword.AutoSize = true;
            this.lbl_CheckPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CheckPassword.ForeColor = System.Drawing.Color.Red;
            this.lbl_CheckPassword.Location = new System.Drawing.Point(317, 394);
            this.lbl_CheckPassword.Name = "lbl_CheckPassword";
            this.lbl_CheckPassword.Size = new System.Drawing.Size(0, 20);
            this.lbl_CheckPassword.TabIndex = 13;
            this.lbl_CheckPassword.Visible = false;
            // 
            // lbl_CheckCFpassword
            // 
            this.lbl_CheckCFpassword.AutoSize = true;
            this.lbl_CheckCFpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CheckCFpassword.ForeColor = System.Drawing.Color.Red;
            this.lbl_CheckCFpassword.Location = new System.Drawing.Point(317, 479);
            this.lbl_CheckCFpassword.Name = "lbl_CheckCFpassword";
            this.lbl_CheckCFpassword.Size = new System.Drawing.Size(0, 20);
            this.lbl_CheckCFpassword.TabIndex = 17;
            this.lbl_CheckCFpassword.Visible = false;
            // 
            // chk_ShowPassword
            // 
            this.chk_ShowPassword.AutoSize = true;
            this.chk_ShowPassword.Location = new System.Drawing.Point(681, 361);
            this.chk_ShowPassword.Name = "chk_ShowPassword";
            this.chk_ShowPassword.Size = new System.Drawing.Size(88, 29);
            this.chk_ShowPassword.TabIndex = 12;
            this.chk_ShowPassword.Text = "Show";
            this.chk_ShowPassword.UseVisualStyleBackColor = true;
            this.chk_ShowPassword.CheckedChanged += new System.EventHandler(this.chk_ShowPassword_CheckedChanged);
            // 
            // chk_ShowCFPassword
            // 
            this.chk_ShowCFPassword.AutoSize = true;
            this.chk_ShowCFPassword.Location = new System.Drawing.Point(681, 446);
            this.chk_ShowCFPassword.Name = "chk_ShowCFPassword";
            this.chk_ShowCFPassword.Size = new System.Drawing.Size(88, 29);
            this.chk_ShowCFPassword.TabIndex = 16;
            this.chk_ShowCFPassword.Text = "Show";
            this.chk_ShowCFPassword.UseVisualStyleBackColor = true;
            this.chk_ShowCFPassword.CheckedChanged += new System.EventHandler(this.chk_ShowCFPassword_CheckedChanged);
            // 
            // lbl_CheckUser
            // 
            this.lbl_CheckUser.AutoSize = true;
            this.lbl_CheckUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CheckUser.ForeColor = System.Drawing.Color.Red;
            this.lbl_CheckUser.Location = new System.Drawing.Point(317, 227);
            this.lbl_CheckUser.Name = "lbl_CheckUser";
            this.lbl_CheckUser.Size = new System.Drawing.Size(0, 20);
            this.lbl_CheckUser.TabIndex = 6;
            this.lbl_CheckUser.Visible = false;
            // 
            // lbl_CheckName
            // 
            this.lbl_CheckName.AutoSize = true;
            this.lbl_CheckName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CheckName.ForeColor = System.Drawing.Color.Red;
            this.lbl_CheckName.Location = new System.Drawing.Point(317, 142);
            this.lbl_CheckName.Name = "lbl_CheckName";
            this.lbl_CheckName.Size = new System.Drawing.Size(0, 20);
            this.lbl_CheckName.TabIndex = 3;
            this.lbl_CheckName.Visible = false;
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 640);
            this.Controls.Add(this.lbl_CheckName);
            this.Controls.Add(this.lbl_CheckUser);
            this.Controls.Add(this.chk_ShowCFPassword);
            this.Controls.Add(this.chk_ShowPassword);
            this.Controls.Add(this.lbl_CheckCFpassword);
            this.Controls.Add(this.lbl_CheckPassword);
            this.Controls.Add(this.lbl_CheckEmail);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.lbl_UserName);
            this.Controls.Add(this.txt_ConfirmPassword);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_UserName);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.lbl_ConfirmPassword);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.lbl_SignIn);
            this.Controls.Add(this.lbl_Name);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRegister";
            this.Load += new System.EventHandler(this.FormRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_ConfirmPassword;
        private System.Windows.Forms.Label lbl_SignIn;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_ConfirmPassword;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label lbl_CheckEmail;
        private System.Windows.Forms.Label lbl_CheckPassword;
        private System.Windows.Forms.Label lbl_CheckCFpassword;
        private System.Windows.Forms.CheckBox chk_ShowPassword;
        private System.Windows.Forms.CheckBox chk_ShowCFPassword;
        private System.Windows.Forms.Label lbl_CheckUser;
        private System.Windows.Forms.Label lbl_CheckName;
    }
}

