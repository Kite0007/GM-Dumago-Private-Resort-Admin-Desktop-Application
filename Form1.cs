using System;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using MongoDB.Driver;
using MongoDB.Bson;

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

            try
            {
                var adminsCollection = MongoDbService.Admins;
                var filter = Builders<BsonDocument>.Filter.Eq("username", username);
                var existingUser = adminsCollection.Find(filter).FirstOrDefault();

                if (existingUser == null)
                {
                    MessageBox.Show("Incorrect username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string storedHashedPassword = existingUser["password"].AsString;
                string enteredHashedPassword = MongoDbService.HashPassword(password);

                if (storedHashedPassword == enteredHashedPassword)
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
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during login.\n\nError: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (!string.IsNullOrEmpty(txtUsername.Text))
            {
                label2.Visible = false;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPassword.Text))
            {
                label3.Visible = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            txtUsername.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            txtPassword.Focus();
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            label2.Visible = false;
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                label2.Visible = true;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            label3.Visible = false;
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                label3.Visible = true;
            }
        }
    }
}