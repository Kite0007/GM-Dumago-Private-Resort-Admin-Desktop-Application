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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Please enter a username.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter a password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }


            if (username == "root" && password == "root")
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DashboardForm dashboard = new DashboardForm();
                dashboard.FormClosed += (s, args) => this.Close(); 
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGoToSignUp_Click(object sender, EventArgs e)
        {
            SignUpForm signup = new SignUpForm();
            signup.FormClosed += (s, args) => this.Close();
            signup.Show();
            this.Hide();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
        }
    }
}