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
    public partial class ChatForm : Form
    {
        bool sidebarExpand;

        public ChatForm()
        {
            InitializeComponent();
        }

        private void lstConversations_SelectedIndexChanged(object sender, EventArgs e)
        {
            // You can add logic here to load the selected chat history
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            if (sidebarTimer != null)
            {
                sidebarTimer.Start();
            }
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebar == null || sidebarTimer == null) return;

            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= sidebar.MinimumSize.Width)
                {
                    sidebar.Width = sidebar.MinimumSize.Width;
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= sidebar.MaximumSize.Width)
                {
                    sidebar.Width = sidebar.MaximumSize.Width;
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        // --- Navigation Methods ---
        private void OpenNewForm(Form newForm)
        {
            this.Hide();
            newForm.Show();
            newForm.FormClosed += (s, args) => this.Show();
        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            DashboardForm dashboard = new DashboardForm();
            dashboard.FormClosed += (s, args) => this.Close();
            dashboard.Show();
            this.Hide();
        }

        private void Reservations_Click(object sender, EventArgs e)
        {
            ReservationManagementForm reservationmanagement = new ReservationManagementForm();
            reservationmanagement.FormClosed += (s, args) => this.Close();
            reservationmanagement.Show();
            this.Hide();
        }

        private void Customer_Click(object sender, EventArgs e)
        {
            CustomerManagenentForm customermanagement = new CustomerManagenentForm();
            customermanagement.FormClosed += (s, args) => this.Close();
            customermanagement.Show();
            this.Hide();
        }

        private void Reports_Click(object sender, EventArgs e)
        {
            ReportsForm reports = new ReportsForm();
            reports.FormClosed += (s, args) => this.Close();
            reports.Show();
            this.Hide();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsForm settings = new SettingsForm();
            settings.FormClosed += (s, args) => this.Close();
            settings.Show();
            this.Hide();
        }

        private void btnBroadcast_Click(object sender, EventArgs e)
        {
            BroadcastForm broadcast = new BroadcastForm();
            broadcast.FormClosed += (s, args) => this.Close();
            broadcast.Show();
            this.Hide();
        }

        private void SignOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to sign out?",
                "Confirm Sign Out",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.FormClosed += (s, args) => this.Close();
                loginForm.Show();
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtChatHistory_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAdminReply_TextChanged(object sender, EventArgs e)
        {

        }
    }
}