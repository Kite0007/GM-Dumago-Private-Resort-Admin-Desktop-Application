namespace GM_Dumago_Private_Resort_Admin_Desktop_Application
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            txtPassword = new TextBox();
            btnGoToSignUp = new Label();
            label1 = new Label();
            btnLogin = new Button();
            txtUsername = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(60, 65, 70);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.White;
            txtPassword.Location = new Point(619, 213);
            txtPassword.Name = "txtPassword";
            txtPassword.RightToLeft = RightToLeft.No;
            txtPassword.Size = new Size(232, 25);
            txtPassword.TabIndex = 37;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // btnGoToSignUp
            // 
            btnGoToSignUp.AutoSize = true;
            btnGoToSignUp.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGoToSignUp.ForeColor = Color.DarkBlue;
            btnGoToSignUp.Location = new Point(759, 350);
            btnGoToSignUp.Name = "btnGoToSignUp";
            btnGoToSignUp.Size = new Size(95, 15);
            btnGoToSignUp.TabIndex = 36;
            btnGoToSignUp.Text = "Create Account";
            btnGoToSignUp.Click += btnGoToSignUp_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(616, 350);
            label1.Name = "label1";
            label1.Size = new Size(134, 15);
            label1.TabIndex = 35;
            label1.Text = "Don't have an account?";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(20, 200, 120);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(619, 283);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(232, 37);
            btnLogin.TabIndex = 34;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += Loginbtn_Click;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(60, 65, 70);
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = Color.White;
            txtUsername.Location = new Point(619, 170);
            txtUsername.Name = "txtUsername";
            txtUsername.RightToLeft = RightToLeft.No;
            txtUsername.Size = new Size(232, 25);
            txtUsername.TabIndex = 33;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(219, 163);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(221, 174);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 32;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(488, 143);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 207);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(624, 216);
            label3.Name = "label3";
            label3.Size = new Size(224, 17);
            label3.TabIndex = 53;
            label3.Text = "Password                                        ";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(623, 173);
            label2.Name = "label2";
            label2.Size = new Size(223, 17);
            label2.TabIndex = 52;
            label2.Text = "Email@gmail.com                            \r\n";
            label2.Click += label2_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 65, 70);
            ClientSize = new Size(1070, 533);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(btnGoToSignUp);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Controls.Add(txtUsername);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtPassword;
        private Label btnGoToSignUp;
        private Label label1;
        private Button btnLogin;
        private TextBox txtUsername;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label label3;
        private Label label2;
    }
}
