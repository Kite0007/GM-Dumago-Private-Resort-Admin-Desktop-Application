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
    public partial class CustomerManagenentForm : Form
    {
        bool sidebarExpand;
        bool homeCollapse;
        bool customerCollapse;

        public CustomerManagenentForm()
        {
            InitializeComponent();
            ReservationsContainer.Height = ReservationsContainer.MinimumSize.Height;
            homeCollapse = true;
            CustomerContainer.Height = CustomerContainer.MinimumSize.Height;
            customerCollapse = true;
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

        private void menuButton_Click(object sender, EventArgs e)
        {
            if (sidebarTimer != null)
            {
                sidebarTimer.Start();
            }
        }

        private void CustomerManagenentForm_Load(object sender, EventArgs e)
        {
            dgvCustomers.Rows.Clear();
            dgvCustomers.Rows.Add("CUST-001", "John Doe", "john@mail.com", "SC-1234");
            dgvCustomers.Rows.Add("CUST-002", "Jane Smith", "jane@mail.com", "SC-5678");
            dgvCustomers.Rows.Add("CUST-003", "Bob Johnson", "bob@mail.com", "(None)");
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

        private void Reports_Click(object sender, EventArgs e)
        {
            ReportsForm reports = new ReportsForm();
            reports.FormClosed += (s, args) => this.Close();
            reports.Show();
            this.Hide();
        }

        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (dgvCustomers.Columns[e.ColumnIndex].Name == "colViewEdit")
            {
                string customerId = dgvCustomers.Rows[e.RowIndex].Cells["colCustID"].Value.ToString();
                MessageBox.Show("You want to View/Edit customer with ID: " + customerId);
            }

            if (dgvCustomers.Columns[e.ColumnIndex].Name == "colDelete")
            {
                string customerId = dgvCustomers.Rows[e.RowIndex].Cells["colCustID"].Value.ToString();
                string customerName = dgvCustomers.Rows[e.RowIndex].Cells["colName"].Value.ToString();

                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete customer: " + customerName + "?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Deleting customer with ID: " + customerId);
                    // dgvCustomers.Rows.RemoveAt(e.RowIndex);
                }
            }
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
                LoginForm login = new LoginForm();
                login.FormClosed += (s, args) => this.Close();
                login.Show();
                this.Hide();
            }
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

        private void btnBroadcast_Click(object sender, EventArgs e)
        {
            BroadcastForm broadcast = new BroadcastForm();
            broadcast.FormClosed += (s, args) => this.Close();
            broadcast.Show();
            this.Hide();
        }
    }
}