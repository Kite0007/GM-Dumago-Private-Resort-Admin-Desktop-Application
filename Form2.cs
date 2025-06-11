using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GM_Dumago_Private_Resort_Admin_Desktop_Application
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            string username = txtNewUsername.Text.Trim();
            string password = txtNewPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("The passwords do not match. Please try again.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            GoToLogin();
        }

        private void btnGoToLogin_Click(object sender, EventArgs e)
        {
            GoToLogin();
        }

        private void GoToLogin()
        {
            LoginForm login = new LoginForm();
           
            login.FormClosed += (s, args) => this.Close();
            login.Show();
            this.Hide();
        }

        private void txtNewUsername_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
        }
    }
}