using System;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using MongoDB.Driver;
using MongoDB.Bson;

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

            try
            {
                var adminsCollection = MongoDbService.Admins;
                var filter = Builders<BsonDocument>.Filter.Eq("username", username);

                if (adminsCollection.Find(filter).Any())
                {
                    MessageBox.Show("This username is already taken. Please choose a different one.", "Username Exists", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string hashedPassword = MongoDbService.HashPassword(password);

                var newUserDocument = new BsonDocument
                {
                    { "username", username },
                    { "password", hashedPassword },
                    { "createdAt", DateTime.UtcNow }
                };

                adminsCollection.InsertOne(newUserDocument);

                MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GoToLogin();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while creating the account.\n\nError: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            if (!string.IsNullOrEmpty(txtNewUsername.Text))
            {
                lblUsername.Visible = false;
            }
        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNewPassword.Text))
            {
                lblPassword.Visible = false;
            }
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                lblConfirmPassword.Visible = false;
            }
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {
            lblUsername.Visible = false;
            txtNewUsername.Focus();
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {
            lblPassword.Visible = false;
            txtNewPassword.Focus();
        }

        private void lblConfirmPassword_Click(object sender, EventArgs e)
        {
            lblConfirmPassword.Visible = false;
            txtConfirmPassword.Focus();
        }

        private void txtNewUsername_Enter(object sender, EventArgs e)
        {
            lblUsername.Visible = false;
        }

        private void txtNewUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNewUsername.Text))
            {
                lblUsername.Visible = true;
            }
        }

        private void txtNewPassword_Enter(object sender, EventArgs e)
        {
            lblPassword.Visible = false;
        }

        private void txtNewPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNewPassword.Text))
            {
                lblPassword.Visible = true;
            }
        }

        private void txtConfirmPassword_Enter(object sender, EventArgs e)
        {
            lblConfirmPassword.Visible = false;
        }

        private void txtConfirmPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                lblConfirmPassword.Visible = true;
            }
        }
    }
}