namespace GM_Dumago_Private_Resort_Admin_Desktop_Application
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            txtConfirmPassword = new TextBox();
            txtNewPassword = new TextBox();
            btnGoToLogin = new Label();
            label1 = new Label();
            btnCreateAccount = new Button();
            txtNewUsername = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            lblUsername = new Label();
            lblPassword = new Label();
            lblConfirmPassword = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BackColor = Color.FromArgb(60, 65, 70);
            txtConfirmPassword.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmPassword.ForeColor = Color.White;
            txtConfirmPassword.Location = new Point(619, 244);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.RightToLeft = RightToLeft.No;
            txtConfirmPassword.Size = new Size(232, 25);
            txtConfirmPassword.TabIndex = 46;
            txtConfirmPassword.UseSystemPasswordChar = true;
            txtConfirmPassword.TextChanged += txtConfirmPassword_TextChanged;
            // 
            // txtNewPassword
            // 
            txtNewPassword.BackColor = Color.FromArgb(60, 65, 70);
            txtNewPassword.BorderStyle = BorderStyle.FixedSingle;
            txtNewPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNewPassword.ForeColor = Color.White;
            txtNewPassword.Location = new Point(619, 203);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.RightToLeft = RightToLeft.No;
            txtNewPassword.Size = new Size(232, 25);
            txtNewPassword.TabIndex = 45;
            txtNewPassword.UseSystemPasswordChar = true;
            txtNewPassword.TextChanged += txtNewPassword_TextChanged;
            // 
            // btnGoToLogin
            // 
            btnGoToLogin.AutoSize = true;
            btnGoToLogin.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGoToLogin.ForeColor = Color.DarkBlue;
            btnGoToLogin.Location = new Point(765, 375);
            btnGoToLogin.Name = "btnGoToLogin";
            btnGoToLogin.Size = new Size(68, 15);
            btnGoToLogin.TabIndex = 44;
            btnGoToLogin.Text = "Login Here";
            btnGoToLogin.Click += btnGoToLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(619, 375);
            label1.Name = "label1";
            label1.Size = new Size(146, 15);
            label1.TabIndex = 43;
            label1.Text = "Already have an account?";
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.BackColor = Color.FromArgb(20, 200, 120);
            btnCreateAccount.FlatAppearance.BorderSize = 0;
            btnCreateAccount.FlatStyle = FlatStyle.Flat;
            btnCreateAccount.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateAccount.ForeColor = Color.White;
            btnCreateAccount.Location = new Point(619, 308);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(232, 37);
            btnCreateAccount.TabIndex = 42;
            btnCreateAccount.Text = "CREATE ACCOUNT";
            btnCreateAccount.UseVisualStyleBackColor = false;
            btnCreateAccount.Click += btnCreateAccount_Click;
            // 
            // txtNewUsername
            // 
            txtNewUsername.BackColor = Color.FromArgb(60, 65, 70);
            txtNewUsername.BorderStyle = BorderStyle.FixedSingle;
            txtNewUsername.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNewUsername.ForeColor = Color.White;
            txtNewUsername.Location = new Point(619, 160);
            txtNewUsername.Name = "txtNewUsername";
            txtNewUsername.RightToLeft = RightToLeft.No;
            txtNewUsername.Size = new Size(232, 25);
            txtNewUsername.TabIndex = 41;
            txtNewUsername.TextChanged += txtNewUsername_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(219, 163);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(221, 174);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 40;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(488, 143);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 207);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 39;
            pictureBox1.TabStop = false;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 9.75F);
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(624, 163);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(223, 17);
            lblUsername.TabIndex = 47;
            lblUsername.Text = "Username                                       ";
            lblUsername.Click += lblUsername_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 9.75F);
            lblPassword.ForeColor = Color.White;
            lblPassword.Location = new Point(624, 206);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(224, 17);
            lblPassword.TabIndex = 48;
            lblPassword.Text = "Password                                        ";
            lblPassword.Click += lblPassword_Click;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Segoe UI", 9.75F);
            lblConfirmPassword.ForeColor = Color.White;
            lblConfirmPassword.Location = new Point(624, 247);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(222, 17);
            lblConfirmPassword.TabIndex = 49;
            lblConfirmPassword.Text = "Confirm Password                           ";
            lblConfirmPassword.Click += lblConfirmPassword_Click;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 65, 70);
            ClientSize = new Size(1070, 533);
            Controls.Add(lblConfirmPassword);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtNewPassword);
            Controls.Add(btnGoToLogin);
            Controls.Add(label1);
            Controls.Add(btnCreateAccount);
            Controls.Add(txtNewUsername);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SignUpForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += SignUpForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtConfirmPassword;
        private TextBox txtNewPassword;
        private Label btnGoToLogin;
        private Label label1;
        private Button btnCreateAccount;
        private TextBox txtNewUsername;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label lblUsername;
        private Label lblPassword;
        private Label lblConfirmPassword;
    }
}