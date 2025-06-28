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
    public partial class BroadcastForm : Form
    {
        // Variable to track the state of the sidebar
        bool sidebarExpand;

        public BroadcastForm()
        {
            InitializeComponent();
        }

        // --- Sidebar Animation Logic ---

        private void menuButton_Click(object sender, EventArgs e)
        {
            // Start the timer to animate the sidebar
            if (sidebarTimer != null)
            {
                sidebarTimer.Start();
            }
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            // Check if sidebar and timer controls exist to prevent errors
            if (sidebar == null || sidebarTimer == null) return;

            // If the sidebar is expanded, collapse it
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
            // If the sidebar is collapsed, expand it
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

        private void btnChat_Click(object sender, EventArgs e)
        {
            ChatForm chat = new ChatForm();
            chat.FormClosed += (s, args) => this.Close();
            chat.Show();
            this.Hide();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsForm settings = new SettingsForm();
            settings.FormClosed += (s, args) => this.Close();
            settings.Show();
            this.Hide();
        }

        private void SignOut_Click(object sender, EventArgs e)
        {
            // Show a confirmation dialog before signing out
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

        // --- Other event handlers for this specific form ---

        private void label11_Click(object sender, EventArgs e)
        {
            // Add functionality for this label if needed
        }

        private void txtNoticeTitle_TextChanged(object sender, EventArgs e)
        {
            // Add functionality for this textbox if needed
        }
    }
}