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
    public partial class SettingsForm : Form
    {
        bool sidebarExpand;

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            // Note: Your DataGridViews and columns must have the correct names in the Form Designer
            // for this code to work.

            // Renamed dgvRoomTypes to dgvVenuePackages for clarity.
            // Assumes columns are: colPkgName, colShift, colPrice, colDP, colEditPackage, colDeletePackage
            dgvRoomTypes.Rows.Clear();
            dgvRoomTypes.Rows.Add("Day Time", "8am-4pm", "7000", "1000", "Edit", "Delete");
            dgvRoomTypes.Rows.Add("Night Time", "8pm-4am", "8000", "1000", "Edit", "Delete");
            dgvRoomTypes.Rows.Add("20 Hours", "20 Hrs", "16000", "1000", "Edit", "Delete");

            // Assumes columns are: colItemName, colDescription, colPrice, colViewEdit, colCancel
            dgvMenuItems.Rows.Clear();
            dgvMenuItems.Rows.Add("Pork Sisig", "Sizzling pork dish", "250", "Edit", "Cancel");
            dgvMenuItems.Rows.Add("Halo-Halo", "Shaved ice dessert", "150", "Edit", "Cancel");
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

        // --- DataGridView Event Handlers ---
        private void dgvVenuePackages_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            string packageName = dgvRoomTypes.Rows[e.RowIndex].Cells["colPkgName"].Value.ToString();

            // Check if the "Edit" button column was clicked
            if (dgvRoomTypes.Columns[e.ColumnIndex].Name == "colEditPackage")
            {
                DialogResult result = MessageBox.Show($"Do you want to edit the '{packageName}' package?", "Confirm Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Now opening the editor for " + packageName);
                    // Open the VenuePackageDetailsForm here
                }
            }

            // Check if the "Delete" button column was clicked
            if (dgvRoomTypes.Columns[e.ColumnIndex].Name == "colDeletePackage")
            {
                DialogResult result = MessageBox.Show($"Are you sure you want to delete the '{packageName}' package? This cannot be undone.", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    MessageBox.Show($"The package '{packageName}' has been deleted.");
                    // Add your database deletion logic here
                    // dgvVenuePackages.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void dgvMenuItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            string itemName = dgvMenuItems.Rows[e.RowIndex].Cells["colItemName"].Value.ToString();

            // Check if the "Edit" button column was clicked
            if (dgvMenuItems.Columns[e.ColumnIndex].Name == "colViewEdit")
            {
                DialogResult result = MessageBox.Show($"Do you want to edit the '{itemName}' menu item?", "Confirm Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Now opening the editor for " + itemName);
                    // Open a form to edit the menu item here
                }
            }

            // Check if the "Cancel/Delete" button column was clicked
            if (dgvMenuItems.Columns[e.ColumnIndex].Name == "colCancel")
            {
                DialogResult result = MessageBox.Show($"Are you sure you want to remove the '{itemName}' menu item?", "Confirm Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    MessageBox.Show($"The menu item '{itemName}' has been removed.");
                    // Add your database deletion logic here
                    // dgvMenuItems.Rows.RemoveAt(e.RowIndex);
                }
            }
        }
    }
}