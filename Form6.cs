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

            // Set initial images for both arrows
            if (imageList1 != null && imageList1.Images.Count > 1)
            {
                if (ReservationsArrow != null)
                {
                    ReservationsArrow.Image = imageList1.Images[0]; // Down arrow
                }
                if (CustomerArrow != null)
                {
                    CustomerArrow.Image = imageList1.Images[0]; // Down arrow
                }
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

        private void menuButton_Click(object sender, EventArgs e)
        {
            if (sidebarTimer != null)
            {
                sidebarTimer.Start();
            }
        }

        private void ReservationsTimer_Tick(object sender, EventArgs e)
        {
            if (ReservationsContainer == null || ReservationsTimer == null) return;

            if (homeCollapse)
            {
                ReservationsContainer.Height += 10;
                if (ReservationsContainer.Height >= ReservationsContainer.MaximumSize.Height)
                {
                    ReservationsContainer.Height = ReservationsContainer.MaximumSize.Height;
                    homeCollapse = false;
                    ReservationsTimer.Stop();
                }
            }
            else
            {
                ReservationsContainer.Height -= 10;
                if (ReservationsContainer.Height <= ReservationsContainer.MinimumSize.Height)
                {
                    ReservationsContainer.Height = ReservationsContainer.MinimumSize.Height;
                    homeCollapse = true;
                    ReservationsTimer.Stop();
                }
            }
        }

        private void CustomerTimer_Tick(object sender, EventArgs e)
        {
            if (CustomerContainer == null || CustomerTimer == null) return;

            if (customerCollapse)
            {
                CustomerContainer.Height += 10;
                if (CustomerContainer.Height >= CustomerContainer.MaximumSize.Height)
                {
                    CustomerContainer.Height = CustomerContainer.MaximumSize.Height;
                    customerCollapse = false;
                    CustomerTimer.Stop();
                }
            }
            else
            {
                CustomerContainer.Height -= 10;
                if (CustomerContainer.Height <= CustomerContainer.MinimumSize.Height)
                {
                    CustomerContainer.Height = CustomerContainer.MinimumSize.Height;
                    customerCollapse = true;
                    CustomerTimer.Stop();
                }
            }
        }

        private void ReservationsArrow_Click_1(object sender, EventArgs e)
        {
            if (ReservationsTimer != null)
            {
                if (homeCollapse)
                {
                    ReservationsArrow.Image = imageList1.Images[1]; // Set to 'Up' arrow
                }
                else
                {
                    ReservationsArrow.Image = imageList1.Images[0]; // Set to 'Down' arrow
                }
                ReservationsTimer.Start();
            }
        }

        private void CustomerArrow_Click_1(object sender, EventArgs e)
        {
            if (CustomerTimer != null)
            {
                if (customerCollapse)
                {
                    CustomerArrow.Image = imageList1.Images[1]; // Set to 'Up' arrow
                }
                else
                {
                    CustomerArrow.Image = imageList1.Images[0]; // Set to 'Down' arrow
                }
                CustomerTimer.Start();
            }
        }

        private void CustomerManagenentForm_Load(object sender, EventArgs e)
        {
            // You can add any code you need to run when the form loads here.
        }

        // --- Sidebar Navigation Click Events ---
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

        private void ReservationsDetails_Click(object sender, EventArgs e)
        {
            ReservationDetailsForm resevationdetails = new ReservationDetailsForm();
            resevationdetails.FormClosed += (s, args) => this.Close();
            resevationdetails.Show();
            this.Hide();
        }

        private void Customer_Click(object sender, EventArgs e)
        {
            CustomerManagenentForm customermanagement = new CustomerManagenentForm();
            customermanagement.FormClosed += (s, args) => this.Close();
            customermanagement.Show();
            this.Hide();
        }

        private void CustomerDetails_Click_1(object sender, EventArgs e)
        {
            CustomerDetailsForm customerdetails = new CustomerDetailsForm();
            customerdetails.FormClosed += (s, args) => this.Close();
            customerdetails.Show();
            this.Hide();
        }

        private void SukiCard_Click(object sender, EventArgs e)
        {
            SukiCardForm sukicard = new SukiCardForm();
            sukicard.FormClosed += (s, args) => this.Close();
            sukicard.Show();
            this.Hide();
        }

        private void Reports_Click(object sender, EventArgs e)
        {
            ReportsForm reports = new ReportsForm();
            reports.FormClosed += (s, args) => this.Close();
            reports.Show();
            this.Hide();
        }
    }
}