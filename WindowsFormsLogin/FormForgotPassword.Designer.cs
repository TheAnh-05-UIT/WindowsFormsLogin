namespace WindowsFormsLogin
{
    partial class FormForgotPassword
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
            this.lbl_ForgotPassword = new System.Windows.Forms.Label();
            this.lbl_EmailGetOTP = new System.Windows.Forms.Label();
            this.btn_GetOTP = new System.Windows.Forms.Button();
            this.txt_EmailGetOTP = new System.Windows.Forms.TextBox();
            this.lklbl_Login = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lbl_ForgotPassword
            // 
            this.lbl_ForgotPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_ForgotPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ForgotPassword.Location = new System.Drawing.Point(0, 0);
            this.lbl_ForgotPassword.Name = "lbl_ForgotPassword";
            this.lbl_ForgotPassword.Size = new System.Drawing.Size(800, 110);
            this.lbl_ForgotPassword.TabIndex = 0;
            this.lbl_ForgotPassword.Text = "Forgot Password";
            this.lbl_ForgotPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_EmailGetOTP
            // 
            this.lbl_EmailGetOTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EmailGetOTP.Location = new System.Drawing.Point(99, 151);
            this.lbl_EmailGetOTP.Name = "lbl_EmailGetOTP";
            this.lbl_EmailGetOTP.Size = new System.Drawing.Size(122, 44);
            this.lbl_EmailGetOTP.TabIndex = 1;
            this.lbl_EmailGetOTP.Text = "Email";
            this.lbl_EmailGetOTP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_GetOTP
            // 
            this.btn_GetOTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GetOTP.Location = new System.Drawing.Point(251, 310);
            this.btn_GetOTP.Name = "btn_GetOTP";
            this.btn_GetOTP.Size = new System.Drawing.Size(168, 57);
            this.btn_GetOTP.TabIndex = 2;
            this.btn_GetOTP.Text = "Get OTP";
            this.btn_GetOTP.UseVisualStyleBackColor = true;
            this.btn_GetOTP.Click += new System.EventHandler(this.btn_GetOTP_Click);
            // 
            // txt_EmailGetOTP
            // 
            this.txt_EmailGetOTP.Location = new System.Drawing.Point(251, 163);
            this.txt_EmailGetOTP.Name = "txt_EmailGetOTP";
            this.txt_EmailGetOTP.Size = new System.Drawing.Size(370, 26);
            this.txt_EmailGetOTP.TabIndex = 3;
            this.txt_EmailGetOTP.TextChanged += new System.EventHandler(this.txt_EmailGetOTP_TextChanged);
            // 
            // lklbl_Login
            // 
            this.lklbl_Login.AutoSize = true;
            this.lklbl_Login.Location = new System.Drawing.Point(564, 232);
            this.lklbl_Login.Name = "lklbl_Login";
            this.lklbl_Login.Size = new System.Drawing.Size(57, 20);
            this.lklbl_Login.TabIndex = 4;
            this.lklbl_Login.TabStop = true;
            this.lklbl_Login.Text = "Login?";
            this.lklbl_Login.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklbl_Login_LinkClicked);
            // 
            // FormForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lklbl_Login);
            this.Controls.Add(this.txt_EmailGetOTP);
            this.Controls.Add(this.btn_GetOTP);
            this.Controls.Add(this.lbl_EmailGetOTP);
            this.Controls.Add(this.lbl_ForgotPassword);
            this.Name = "FormForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormForgotPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ForgotPassword;
        private System.Windows.Forms.Label lbl_EmailGetOTP;
        private System.Windows.Forms.Button btn_GetOTP;
        private System.Windows.Forms.TextBox txt_EmailGetOTP;
        private System.Windows.Forms.LinkLabel lklbl_Login;
    }
}