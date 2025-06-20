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
    public partial class ReservationManagementForm : Form
    {
        bool sidebarExpand;
        bool homeCollapse;
        bool customerCollapse;

        public ReservationManagementForm()
        {
            InitializeComponent();
            ReservationsContainer_1.Height = ReservationsContainer_1.MinimumSize.Height;
            homeCollapse = true;
            CustomerContainer_1.Height = CustomerContainer_1.MinimumSize.Height;
            customerCollapse = true;
        }

        private void sidebarTimer_Tick_1(object sender, EventArgs e)
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

        private void ReservationManagementForm_Load(object sender, EventArgs e)
        {
            dgvReservations.Rows.Clear();
            dgvReservations.Rows.Add("RES-001", "John Doe", "2023-10-26", "Confirmed");
            dgvReservations.Rows.Add("RES-002", "Jane Smith", "2023-11-01", "Pending");
            dgvReservations.Rows.Add("RES-003", "Bob Johnson", "2023-09-15", "Cancelled");
            dgvReservations.Rows.Add("RES-004", "Alice Brown", "2023-10-29", "Paid");
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

        private void Customer_Click_1(object sender, EventArgs e)
        {
            CustomerManagenentForm customermanagement = new CustomerManagenentForm();
            customermanagement.FormClosed += (s, args) => this.Close();
            customermanagement.Show();
            this.Hide();
        }

        private void Reports_Click_1(object sender, EventArgs e)
        {
            ReportsForm reports = new ReportsForm();
            reports.FormClosed += (s, args) => this.Close();
            reports.Show();
            this.Hide();
        }

        private void dgvReservations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (dgvReservations.Columns[e.ColumnIndex].Name == "colViewEdit")
            {
                string reservationId = dgvReservations.Rows[e.RowIndex].Cells["colResID"].Value.ToString();
                MessageBox.Show("You clicked 'View/Edit' for Reservation ID: " + reservationId);
            }

            if (dgvReservations.Columns[e.ColumnIndex].Name == "colCancel")
            {
                string reservationId = dgvReservations.Rows[e.RowIndex].Cells["colResID"].Value.ToString();
                MessageBox.Show("You clicked 'Cancel' for Reservation ID: " + reservationId);
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
    }
}