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
    public partial class ReportsForm : Form
    {
        bool sidebarExpand;
        bool homeCollapse;
        bool customerCollapse;
        private List<Tuple<string, int, int, int>> reportData;

        public ReportsForm()
        {
            InitializeComponent();
            ReservationsContainer.Height = ReservationsContainer.MinimumSize.Height;
            homeCollapse = true;
            CustomerContainer.Height = CustomerContainer.MinimumSize.Height;
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

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            reportData = new List<Tuple<string, int, int, int>>
            {
                Tuple.Create("Jan", 25, 5000, 60),
                Tuple.Create("Feb", 30, 6500, 70),
                Tuple.Create("Mar", 28, 5800, 65)
            };
            LoadReportDetails();
        }

        private void LoadReportDetails()
        {
            dgvReportDetails.Rows.Clear();
            foreach (var dataPoint in reportData)
            {
                dgvReportDetails.Rows.Add(dataPoint.Item1, dataPoint.Item2, dataPoint.Item3, dataPoint.Item4 + "%");
            }
        }

        private void SukiCardForm_Load(object sender, EventArgs e)
        {
        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            DashboardForm dashboard = new DashboardForm();
            dashboard.FormClosed += (s, args) => this.Close();
            dashboard.Show();
            this.Hide();
        }

        private void Reservations_Click_1(object sender, EventArgs e)
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

        private void SukiCard_Click_1(object sender, EventArgs e)
        {
            SukiCardForm sukicard = new SukiCardForm();
            sukicard.FormClosed += (s, args) => this.Close();
            sukicard.Show();
            this.Hide();
        }

        private void Reports_Click_1(object sender, EventArgs e)
        {
            ReportsForm reports = new ReportsForm();
            reports.FormClosed += (s, args) => this.Close();
            reports.Show();
            this.Hide();
        }

        private void pnlChartHost_Paint(object sender, PaintEventArgs e)
        {
            if (reportData == null || reportData.Count == 0)
            {
                return;
            }

            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Brush barBrush = new SolidBrush(Color.SteelBlue);
            Brush textBrush = new SolidBrush(Color.Black);
            Pen axisPen = new Pen(Color.Gray, 1);

            int panelWidth = pnlChartHost.ClientSize.Width;
            int panelHeight = pnlChartHost.ClientSize.Height;
            int bottomMargin = 30;
            int leftMargin = 40;

            int maxRevenue = reportData.Max(item => item.Item3);
            if (maxRevenue == 0) maxRevenue = 10000;

            float slotWidth = (float)(panelWidth - leftMargin) / reportData.Count;
            float barWidth = slotWidth * 0.3f;

            g.DrawLine(axisPen, leftMargin, 5, leftMargin, panelHeight - bottomMargin);
            g.DrawLine(axisPen, leftMargin, panelHeight - bottomMargin, panelWidth - 5, panelHeight - bottomMargin);

            for (int i = 0; i < reportData.Count; i++)
            {
                var dataPoint = reportData[i];
                string month = dataPoint.Item1;
                int revenue = dataPoint.Item3;

                int barHeight = (int)(((double)revenue / maxRevenue) * (panelHeight - bottomMargin - 5));

                float xPos = leftMargin + (i * slotWidth) + (slotWidth - barWidth) / 2;
                int yPos = panelHeight - bottomMargin - barHeight;

                g.FillRectangle(barBrush, xPos, yPos, barWidth, barHeight);

                SizeF textSize = g.MeasureString(month, this.Font);
                float labelXPos = xPos + (barWidth / 2) - (textSize.Width / 2);
                g.DrawString(month, this.Font, textBrush, labelXPos, panelHeight - bottomMargin + 5);
            }

            barBrush.Dispose();
            textBrush.Dispose();
            axisPen.Dispose();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            pnlChartHost.Invalidate();
        }

        private void dgvReportDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
    }
}