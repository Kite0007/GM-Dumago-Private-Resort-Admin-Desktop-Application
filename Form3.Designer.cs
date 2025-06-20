namespace GM_Dumago_Private_Resort_Admin_Desktop_Application
{
    partial class DashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            panel1 = new Panel();
            label1 = new Label();
            menuButton = new PictureBox();
            panel2 = new Panel();
            Dashboard = new Button();
            ReservationsContainer = new Panel();
            panel10 = new Panel();
            ReservationsDetails = new Button();
            panel3 = new Panel();
            Reservations = new Button();
            sidebar = new FlowLayoutPanel();
            CustomerContainer = new Panel();
            panel12 = new Panel();
            CustomerDetails = new Button();
            panel13 = new Panel();
            Customer = new Button();
            panel6 = new Panel();
            Reports = new Button();
            panel5 = new Panel();
            panel9 = new Panel();
            SignOut = new Button();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            label3 = new Label();
            lblTotalReservationsCount = new Label();
            lblPendingReservationsCount = new Label();
            lblMonthlyRevenueAmount = new Label();
            lblConfirmedReservationsCount = new Label();
            lblMonthlyReservationsTrend = new Label();
            pnlChartHost = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).BeginInit();
            panel2.SuspendLayout();
            ReservationsContainer.SuspendLayout();
            panel10.SuspendLayout();
            panel3.SuspendLayout();
            sidebar.SuspendLayout();
            CustomerContainer.SuspendLayout();
            panel12.SuspendLayout();
            panel13.SuspendLayout();
            panel6.SuspendLayout();
            panel9.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(menuButton);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(242, 97);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(76, 34);
            label1.Name = "label1";
            label1.Size = new Size(50, 21);
            label1.TabIndex = 1;
            label1.Text = "Menu";
            // 
            // menuButton
            // 
            menuButton.Image = (Image)resources.GetObject("menuButton.Image");
            menuButton.Location = new Point(16, 30);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(31, 26);
            menuButton.SizeMode = PictureBoxSizeMode.StretchImage;
            menuButton.TabIndex = 0;
            menuButton.TabStop = false;
            menuButton.Click += menuButton_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(Dashboard);
            panel2.Location = new Point(3, 106);
            panel2.Name = "panel2";
            panel2.Size = new Size(242, 44);
            panel2.TabIndex = 1;
            // 
            // Dashboard
            // 
            Dashboard.FlatStyle = FlatStyle.Flat;
            Dashboard.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Dashboard.ForeColor = Color.White;
            Dashboard.Image = (Image)resources.GetObject("Dashboard.Image");
            Dashboard.ImageAlign = ContentAlignment.MiddleLeft;
            Dashboard.Location = new Point(-17, -8);
            Dashboard.Name = "Dashboard";
            Dashboard.Padding = new Padding(30, 0, 0, 0);
            Dashboard.Size = new Size(274, 60);
            Dashboard.TabIndex = 1;
            Dashboard.Text = "              Dashboard";
            Dashboard.TextAlign = ContentAlignment.MiddleLeft;
            Dashboard.UseVisualStyleBackColor = true;
            Dashboard.Click += Dashboard_Click;
            // 
            // ReservationsContainer
            // 
            ReservationsContainer.BackColor = Color.FromArgb(35, 40, 45);
            ReservationsContainer.Controls.Add(panel10);
            ReservationsContainer.Controls.Add(panel3);
            ReservationsContainer.Location = new Point(3, 156);
            ReservationsContainer.MaximumSize = new Size(242, 100);
            ReservationsContainer.MinimumSize = new Size(242, 44);
            ReservationsContainer.Name = "ReservationsContainer";
            ReservationsContainer.Size = new Size(242, 44);
            ReservationsContainer.TabIndex = 9;
            // 
            // panel10
            // 
            panel10.Controls.Add(ReservationsDetails);
            panel10.Location = new Point(0, 53);
            panel10.Name = "panel10";
            panel10.Size = new Size(242, 44);
            panel10.TabIndex = 3;
            // 
            // ReservationsDetails
            // 
            ReservationsDetails.BackColor = Color.FromArgb(50, 55, 60);
            ReservationsDetails.FlatStyle = FlatStyle.Flat;
            ReservationsDetails.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ReservationsDetails.ForeColor = Color.White;
            ReservationsDetails.Image = (Image)resources.GetObject("ReservationsDetails.Image");
            ReservationsDetails.ImageAlign = ContentAlignment.MiddleLeft;
            ReservationsDetails.Location = new Point(-16, -8);
            ReservationsDetails.Name = "ReservationsDetails";
            ReservationsDetails.Padding = new Padding(30, 0, 0, 0);
            ReservationsDetails.Size = new Size(274, 60);
            ReservationsDetails.TabIndex = 2;
            ReservationsDetails.Text = "              Reservations Details";
            ReservationsDetails.TextAlign = ContentAlignment.MiddleLeft;
            ReservationsDetails.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(Reservations);
            panel3.Location = new Point(0, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(242, 44);
            panel3.TabIndex = 2;
            // 
            // Reservations
            // 
            Reservations.FlatStyle = FlatStyle.Flat;
            Reservations.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Reservations.ForeColor = Color.White;
            Reservations.Image = (Image)resources.GetObject("Reservations.Image");
            Reservations.ImageAlign = ContentAlignment.MiddleLeft;
            Reservations.Location = new Point(-16, -8);
            Reservations.Name = "Reservations";
            Reservations.Padding = new Padding(30, 0, 0, 0);
            Reservations.Size = new Size(274, 60);
            Reservations.TabIndex = 2;
            Reservations.Text = "              Reservations";
            Reservations.TextAlign = ContentAlignment.MiddleLeft;
            Reservations.UseVisualStyleBackColor = true;
            Reservations.Click += Reservations_Click;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(35, 40, 45);
            sidebar.Controls.Add(panel1);
            sidebar.Controls.Add(panel2);
            sidebar.Controls.Add(ReservationsContainer);
            sidebar.Controls.Add(CustomerContainer);
            sidebar.Controls.Add(panel6);
            sidebar.Controls.Add(panel5);
            sidebar.Controls.Add(panel9);
            sidebar.Dock = DockStyle.Left;
            sidebar.ForeColor = SystemColors.ControlLightLight;
            sidebar.Location = new Point(0, 0);
            sidebar.MaximumSize = new Size(245, 533);
            sidebar.MinimumSize = new Size(70, 533);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(70, 533);
            sidebar.TabIndex = 6;
            // 
            // CustomerContainer
            // 
            CustomerContainer.BackColor = Color.FromArgb(35, 40, 45);
            CustomerContainer.Controls.Add(panel12);
            CustomerContainer.Controls.Add(panel13);
            CustomerContainer.Location = new Point(3, 206);
            CustomerContainer.MaximumSize = new Size(242, 100);
            CustomerContainer.MinimumSize = new Size(242, 44);
            CustomerContainer.Name = "CustomerContainer";
            CustomerContainer.Size = new Size(242, 44);
            CustomerContainer.TabIndex = 11;
            // 
            // panel12
            // 
            panel12.Controls.Add(CustomerDetails);
            panel12.Location = new Point(0, 53);
            panel12.Name = "panel12";
            panel12.Size = new Size(242, 44);
            panel12.TabIndex = 3;
            // 
            // CustomerDetails
            // 
            CustomerDetails.BackColor = Color.FromArgb(50, 55, 60);
            CustomerDetails.FlatStyle = FlatStyle.Flat;
            CustomerDetails.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CustomerDetails.ForeColor = Color.White;
            CustomerDetails.Image = (Image)resources.GetObject("CustomerDetails.Image");
            CustomerDetails.ImageAlign = ContentAlignment.MiddleLeft;
            CustomerDetails.Location = new Point(-16, -8);
            CustomerDetails.Name = "CustomerDetails";
            CustomerDetails.Padding = new Padding(30, 0, 0, 0);
            CustomerDetails.Size = new Size(274, 60);
            CustomerDetails.TabIndex = 2;
            CustomerDetails.Text = "              Customer Details";
            CustomerDetails.TextAlign = ContentAlignment.MiddleLeft;
            CustomerDetails.UseVisualStyleBackColor = false;
            // 
            // panel13
            // 
            panel13.Controls.Add(Customer);
            panel13.Location = new Point(0, 3);
            panel13.Name = "panel13";
            panel13.Size = new Size(242, 44);
            panel13.TabIndex = 2;
            // 
            // Customer
            // 
            Customer.FlatStyle = FlatStyle.Flat;
            Customer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Customer.ForeColor = Color.White;
            Customer.Image = (Image)resources.GetObject("Customer.Image");
            Customer.ImageAlign = ContentAlignment.MiddleLeft;
            Customer.Location = new Point(-16, -8);
            Customer.Name = "Customer";
            Customer.Padding = new Padding(30, 0, 0, 0);
            Customer.Size = new Size(274, 60);
            Customer.TabIndex = 2;
            Customer.Text = "              Customers";
            Customer.TextAlign = ContentAlignment.MiddleLeft;
            Customer.UseVisualStyleBackColor = true;
            Customer.Click += Customer_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(Reports);
            panel6.Location = new Point(3, 256);
            panel6.Name = "panel6";
            panel6.Size = new Size(242, 44);
            panel6.TabIndex = 5;
            // 
            // Reports
            // 
            Reports.FlatStyle = FlatStyle.Flat;
            Reports.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Reports.ForeColor = Color.White;
            Reports.Image = (Image)resources.GetObject("Reports.Image");
            Reports.ImageAlign = ContentAlignment.MiddleLeft;
            Reports.Location = new Point(-16, -8);
            Reports.Name = "Reports";
            Reports.Padding = new Padding(30, 0, 0, 0);
            Reports.Size = new Size(274, 60);
            Reports.TabIndex = 2;
            Reports.Text = "              Reports\r\n";
            Reports.TextAlign = ContentAlignment.MiddleLeft;
            Reports.UseVisualStyleBackColor = true;
            Reports.Click += Reports_Click;
            // 
            // panel5
            // 
            panel5.Location = new Point(3, 306);
            panel5.Name = "panel5";
            panel5.Size = new Size(242, 174);
            panel5.TabIndex = 12;
            // 
            // panel9
            // 
            panel9.Controls.Add(SignOut);
            panel9.Location = new Point(3, 486);
            panel9.Name = "panel9";
            panel9.Size = new Size(242, 44);
            panel9.TabIndex = 8;
            // 
            // SignOut
            // 
            SignOut.FlatStyle = FlatStyle.Flat;
            SignOut.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SignOut.ForeColor = Color.White;
            SignOut.Image = (Image)resources.GetObject("SignOut.Image");
            SignOut.ImageAlign = ContentAlignment.MiddleLeft;
            SignOut.Location = new Point(-16, -8);
            SignOut.Name = "SignOut";
            SignOut.Padding = new Padding(30, 0, 0, 0);
            SignOut.Size = new Size(274, 60);
            SignOut.TabIndex = 2;
            SignOut.Text = "              Sign Out";
            SignOut.TextAlign = ContentAlignment.MiddleLeft;
            SignOut.UseVisualStyleBackColor = true;
            SignOut.Click += SignOut_Click;
            // 
            // sidebarTimer
            // 
            sidebarTimer.Interval = 10;
            sidebarTimer.Tick += sidebarTimer_Tick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(104, 65);
            label3.Name = "label3";
            label3.Size = new Size(251, 30);
            label3.TabIndex = 8;
            label3.Text = "Welcome, [Admin Name]!";
            // 
            // lblTotalReservationsCount
            // 
            lblTotalReservationsCount.AutoSize = true;
            lblTotalReservationsCount.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalReservationsCount.Location = new Point(129, 191);
            lblTotalReservationsCount.Name = "lblTotalReservationsCount";
            lblTotalReservationsCount.Size = new Size(132, 20);
            lblTotalReservationsCount.TabIndex = 9;
            lblTotalReservationsCount.Text = "Total Reservations:";
            // 
            // lblPendingReservationsCount
            // 
            lblPendingReservationsCount.AutoSize = true;
            lblPendingReservationsCount.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPendingReservationsCount.Location = new Point(129, 234);
            lblPendingReservationsCount.Name = "lblPendingReservationsCount";
            lblPendingReservationsCount.Size = new Size(152, 20);
            lblPendingReservationsCount.TabIndex = 10;
            lblPendingReservationsCount.Text = "Pending Reservations:";
            // 
            // lblMonthlyRevenueAmount
            // 
            lblMonthlyRevenueAmount.AutoSize = true;
            lblMonthlyRevenueAmount.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMonthlyRevenueAmount.Location = new Point(129, 321);
            lblMonthlyRevenueAmount.Name = "lblMonthlyRevenueAmount";
            lblMonthlyRevenueAmount.Size = new Size(162, 20);
            lblMonthlyRevenueAmount.TabIndex = 12;
            lblMonthlyRevenueAmount.Text = "Total Revenue (Month):";
            // 
            // lblConfirmedReservationsCount
            // 
            lblConfirmedReservationsCount.AutoSize = true;
            lblConfirmedReservationsCount.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfirmedReservationsCount.Location = new Point(129, 278);
            lblConfirmedReservationsCount.Name = "lblConfirmedReservationsCount";
            lblConfirmedReservationsCount.Size = new Size(169, 20);
            lblConfirmedReservationsCount.TabIndex = 11;
            lblConfirmedReservationsCount.Text = "Confirmed Reservations:";
            // 
            // lblMonthlyReservationsTrend
            // 
            lblMonthlyReservationsTrend.AutoSize = true;
            lblMonthlyReservationsTrend.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMonthlyReservationsTrend.Location = new Point(406, 72);
            lblMonthlyReservationsTrend.Name = "lblMonthlyReservationsTrend";
            lblMonthlyReservationsTrend.Size = new Size(194, 20);
            lblMonthlyReservationsTrend.TabIndex = 13;
            lblMonthlyReservationsTrend.Text = "Monthly Reservations Trend:";
            // 
            // pnlChartHost
            // 
            pnlChartHost.Location = new Point(411, 98);
            pnlChartHost.Name = "pnlChartHost";
            pnlChartHost.Size = new Size(606, 345);
            pnlChartHost.TabIndex = 14;
            pnlChartHost.Paint += pnlChartHost_Paint;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1070, 533);
            Controls.Add(sidebar);
            Controls.Add(pnlChartHost);
            Controls.Add(lblMonthlyReservationsTrend);
            Controls.Add(lblMonthlyRevenueAmount);
            Controls.Add(lblConfirmedReservationsCount);
            Controls.Add(lblPendingReservationsCount);
            Controls.Add(lblTotalReservationsCount);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            Load += DashboardForm_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).EndInit();
            panel2.ResumeLayout(false);
            ReservationsContainer.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel3.ResumeLayout(false);
            sidebar.ResumeLayout(false);
            CustomerContainer.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel13.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel9.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox menuButton;
        private Panel panel2;
        private Button Dashboard;
        private Panel ReservationsContainer;
        private Panel panel10;
        private Button ReservationsDetails;
        private Panel panel3;
        private Button Reservations;
        private FlowLayoutPanel sidebar;
        private Panel CustomerContainer;
        private Panel panel12;
        private Button CustomerDetails;
        private Panel panel13;
        private Button Customer;
        private Panel panel6;
        private Button Reports;
        private Panel panel9;
        private Button SignOut;
        private System.Windows.Forms.Timer sidebarTimer;
        private Label label3;
        private Label lblTotalReservationsCount;
        private Label lblPendingReservationsCount;
        private Label lblMonthlyRevenueAmount;
        private Label lblConfirmedReservationsCount;
        private Label lblMonthlyReservationsTrend;
        private Panel pnlChartHost;
        private Panel panel5;
    }
}