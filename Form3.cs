using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GM_Dumago_Private_Resort_Admin_Desktop_Application
{
    public partial class DashboardForm : Form
    {
        bool sidebarExpand;
        bool homeCollapse;
        bool customerCollapse;

        public DashboardForm()
        {
            InitializeComponent();
            ReservationsContainer.Height = ReservationsContainer.MinimumSize.Height;
            homeCollapse = true;
            CustomerContainer.Height = CustomerContainer.MinimumSize.Height;
            customerCollapse = true;

            this.Load += new System.EventHandler(this.DashboardForm_Load);
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            if (pnlChartHost != null)
            {
                var myChart = new Chart();
                myChart.Name = "chartMonthlyReservations";
                myChart.Dock = DockStyle.Fill;
                myChart.ChartAreas.Add(new ChartArea("MainChartArea"));
                var series = myChart.Series.Add("Monthly Reservations");
                series.ChartType = SeriesChartType.Column;

                series.Points.AddXY("Jan", 50);
                series.Points.AddXY("Feb", 75);
                series.Points.AddXY("Mar", 120);
                series.Points.AddXY("Apr", 90);
                series.Points.AddXY("May", 150);
                series.Points.AddXY("Jun", 110);

                ChartArea chartArea = myChart.ChartAreas["MainChartArea"];
                chartArea.AxisX.MajorGrid.Enabled = false;
                chartArea.AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
                chartArea.AxisY.Title = "Reservations";
                chartArea.BackColor = Color.Transparent;

                series.Color = Color.SteelBlue;

                pnlChartHost.Controls.Add(myChart);
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

        private void pnlChartHost_Paint(object sender, PaintEventArgs e)
        {

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

        private void DashboardForm_Load_1(object sender, EventArgs e)
        {

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