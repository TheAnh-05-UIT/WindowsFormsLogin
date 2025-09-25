namespace WindowsFormsLogin
{
    partial class FormResetPassword
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
            this.lbl_ResetPassword = new System.Windows.Forms.Label();
            this.lbl_ConfirmNewPassword = new System.Windows.Forms.Label();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.txt_OTP = new System.Windows.Forms.TextBox();
            this.txt_NewPassword = new System.Windows.Forms.TextBox();
            this.txt_ConfirmNewPassword = new System.Windows.Forms.TextBox();
            this.lbl_inputOTP = new System.Windows.Forms.Label();
            this.lbl_NewPassword = new System.Windows.Forms.Label();
            this.chk_ShowNewPassword = new System.Windows.Forms.CheckBox();
            this.chk_ShowConfirmPassword = new System.Windows.Forms.CheckBox();
            this.btn_GuiMaOTP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_ResetPassword
            // 
            this.lbl_ResetPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_ResetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ResetPassword.Location = new System.Drawing.Point(0, 0);
            this.lbl_ResetPassword.Name = "lbl_ResetPassword";
            this.lbl_ResetPassword.Size = new System.Drawing.Size(800, 78);
            this.lbl_ResetPassword.TabIndex = 1;
            this.lbl_ResetPassword.Text = "Reset Password";
            this.lbl_ResetPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ConfirmNewPassword
            // 
            this.lbl_ConfirmNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ConfirmNewPassword.Location = new System.Drawing.Point(50, 250);
            this.lbl_ConfirmNewPassword.Name = "lbl_ConfirmNewPassword";
            this.lbl_ConfirmNewPassword.Size = new System.Drawing.Size(210, 51);
            this.lbl_ConfirmNewPassword.TabIndex = 3;
            this.lbl_ConfirmNewPassword.Text = "Confirm Password";
            this.lbl_ConfirmNewPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Reset
            // 
            this.btn_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.Location = new System.Drawing.Point(308, 355);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(169, 55);
            this.btn_Reset.TabIndex = 4;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            // 
            // txt_OTP
            // 
            this.txt_OTP.Location = new System.Drawing.Point(308, 127);
            this.txt_OTP.Name = "txt_OTP";
            this.txt_OTP.Size = new System.Drawing.Size(282, 26);
            this.txt_OTP.TabIndex = 5;
            this.txt_OTP.TextChanged += new System.EventHandler(this.txt_OTP_TextChanged);
            // 
            // txt_NewPassword
            // 
            this.txt_NewPassword.Location = new System.Drawing.Point(308, 196);
            this.txt_NewPassword.Name = "txt_NewPassword";
            this.txt_NewPassword.Size = new System.Drawing.Size(282, 26);
            this.txt_NewPassword.TabIndex = 6;
            // 
            // txt_ConfirmNewPassword
            // 
            this.txt_ConfirmNewPassword.Location = new System.Drawing.Point(308, 265);
            this.txt_ConfirmNewPassword.Name = "txt_ConfirmNewPassword";
            this.txt_ConfirmNewPassword.Size = new System.Drawing.Size(282, 26);
            this.txt_ConfirmNewPassword.TabIndex = 7;
            // 
            // lbl_inputOTP
            // 
            this.lbl_inputOTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inputOTP.Location = new System.Drawing.Point(50, 115);
            this.lbl_inputOTP.Name = "lbl_inputOTP";
            this.lbl_inputOTP.Size = new System.Drawing.Size(210, 51);
            this.lbl_inputOTP.TabIndex = 0;
            this.lbl_inputOTP.Text = "OTP";
            this.lbl_inputOTP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_NewPassword
            // 
            this.lbl_NewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NewPassword.Location = new System.Drawing.Point(50, 181);
            this.lbl_NewPassword.Name = "lbl_NewPassword";
            this.lbl_NewPassword.Size = new System.Drawing.Size(210, 51);
            this.lbl_NewPassword.TabIndex = 2;
            this.lbl_NewPassword.Text = "New Password";
            this.lbl_NewPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chk_ShowNewPassword
            // 
            this.chk_ShowNewPassword.AutoSize = true;
            this.chk_ShowNewPassword.Location = new System.Drawing.Point(617, 196);
            this.chk_ShowNewPassword.Name = "chk_ShowNewPassword";
            this.chk_ShowNewPassword.Size = new System.Drawing.Size(75, 24);
            this.chk_ShowNewPassword.TabIndex = 8;
            this.chk_ShowNewPassword.Text = "Show";
            this.chk_ShowNewPassword.UseVisualStyleBackColor = true;
            // 
            // chk_ShowConfirmPassword
            // 
            this.chk_ShowConfirmPassword.AutoSize = true;
            this.chk_ShowConfirmPassword.Location = new System.Drawing.Point(617, 265);
            this.chk_ShowConfirmPassword.Name = "chk_ShowConfirmPassword";
            this.chk_ShowConfirmPassword.Size = new System.Drawing.Size(75, 24);
            this.chk_ShowConfirmPassword.TabIndex = 9;
            this.chk_ShowConfirmPassword.Text = "Show";
            this.chk_ShowConfirmPassword.UseVisualStyleBackColor = true;
            // 
            // btn_GuiMaOTP
            // 
            this.btn_GuiMaOTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GuiMaOTP.Location = new System.Drawing.Point(617, 122);
            this.btn_GuiMaOTP.Name = "btn_GuiMaOTP";
            this.btn_GuiMaOTP.Size = new System.Drawing.Size(102, 39);
            this.btn_GuiMaOTP.TabIndex = 10;
            this.btn_GuiMaOTP.Text = "Gửi Mã";
            this.btn_GuiMaOTP.UseVisualStyleBackColor = true;
            this.btn_GuiMaOTP.Click += new System.EventHandler(this.btn_GuiMaOTP_Click);
            // 
            // FormResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_GuiMaOTP);
            this.Controls.Add(this.chk_ShowConfirmPassword);
            this.Controls.Add(this.chk_ShowNewPassword);
            this.Controls.Add(this.txt_ConfirmNewPassword);
            this.Controls.Add(this.txt_NewPassword);
            this.Controls.Add(this.txt_OTP);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.lbl_ConfirmNewPassword);
            this.Controls.Add(this.lbl_NewPassword);
            this.Controls.Add(this.lbl_ResetPassword);
            this.Controls.Add(this.lbl_inputOTP);
            this.Name = "FormResetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormResetPassword";
            this.Load += new System.EventHandler(this.FormResetPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_ResetPassword;
        private System.Windows.Forms.Label lbl_ConfirmNewPassword;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.TextBox txt_OTP;
        private System.Windows.Forms.TextBox txt_NewPassword;
        private System.Windows.Forms.TextBox txt_ConfirmNewPassword;
        private System.Windows.Forms.Label lbl_inputOTP;
        private System.Windows.Forms.Label lbl_NewPassword;
        private System.Windows.Forms.CheckBox chk_ShowNewPassword;
        private System.Windows.Forms.CheckBox chk_ShowConfirmPassword;
        private System.Windows.Forms.Button btn_GuiMaOTP;
    }
}