namespace GM_Dumago_Private_Resort_Admin_Desktop_Application
{
    partial class ReportsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportsForm));
            sidebarTimer = new System.Windows.Forms.Timer(components);
            SignOut = new Button();
            panel9 = new Panel();
            Reports = new Button();
            panel6 = new Panel();
            Customer = new Button();
            panel13 = new Panel();
            CustomerDetails = new Button();
            CustomerContainer = new Panel();
            panel12 = new Panel();
            sidebar = new FlowLayoutPanel();
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
            panel4 = new Panel();
            btnChat = new Button();
            panel5 = new Panel();
            btnSettings = new Button();
            panel7 = new Panel();
            btnBroadcast = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            lblTotalReservationsCount = new Label();
            label2 = new Label();
            cboReportYear = new ComboBox();
            cboReportType = new ComboBox();
            btnGenerateReport = new Button();
            dgvReportDetails = new DataGridView();
            colMonth = new DataGridViewTextBoxColumn();
            colReservations = new DataGridViewTextBoxColumn();
            colRevenue = new DataGridViewTextBoxColumn();
            colOccupancy = new DataGridViewTextBoxColumn();
            sqlCommand2 = new Microsoft.Data.SqlClient.SqlCommand();
            pnlChartHost = new Panel();
            panel9.SuspendLayout();
            panel6.SuspendLayout();
            panel13.SuspendLayout();
            CustomerContainer.SuspendLayout();
            panel12.SuspendLayout();
            sidebar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).BeginInit();
            panel2.SuspendLayout();
            ReservationsContainer.SuspendLayout();
            panel10.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReportDetails).BeginInit();
            SuspendLayout();
            // 
            // sidebarTimer
            // 
            sidebarTimer.Interval = 10;
            sidebarTimer.Tick += sidebarTimer_Tick_1;
            // 
            // SignOut
            // 
            SignOut.FlatStyle = FlatStyle.Flat;
            SignOut.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SignOut.ForeColor = Color.White;
            SignOut.Image = (Image)resources.GetObject("SignOut.Image");
            SignOut.ImageAlign = ContentAlignment.MiddleLeft;
            SignOut.Location = new Point(-13, -8);
            SignOut.Name = "SignOut";
            SignOut.Padding = new Padding(30, 0, 0, 0);
            SignOut.Size = new Size(274, 60);
            SignOut.TabIndex = 2;
            SignOut.Text = "              Sign Out";
            SignOut.TextAlign = ContentAlignment.MiddleLeft;
            SignOut.UseVisualStyleBackColor = true;
            SignOut.Click += SignOut_Click;
            // 
            // panel9
            // 
            panel9.Controls.Add(SignOut);
            panel9.Location = new Point(3, 456);
            panel9.Name = "panel9";
            panel9.Size = new Size(242, 44);
            panel9.TabIndex = 8;
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
            // 
            // panel6
            // 
            panel6.Controls.Add(Reports);
            panel6.Location = new Point(3, 256);
            panel6.Name = "panel6";
            panel6.Size = new Size(242, 44);
            panel6.TabIndex = 5;
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
            Customer.Click += Customer_Click_1;
            // 
            // panel13
            // 
            panel13.Controls.Add(Customer);
            panel13.Location = new Point(0, 3);
            panel13.Name = "panel13";
            panel13.Size = new Size(242, 44);
            panel13.TabIndex = 2;
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
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(35, 40, 45);
            sidebar.Controls.Add(panel1);
            sidebar.Controls.Add(panel2);
            sidebar.Controls.Add(ReservationsContainer);
            sidebar.Controls.Add(CustomerContainer);
            sidebar.Controls.Add(panel6);
            sidebar.Controls.Add(panel4);
            sidebar.Controls.Add(panel5);
            sidebar.Controls.Add(panel7);
            sidebar.Controls.Add(panel9);
            sidebar.Dock = DockStyle.Left;
            sidebar.ForeColor = SystemColors.ControlLightLight;
            sidebar.Location = new Point(0, 0);
            sidebar.MaximumSize = new Size(245, 533);
            sidebar.MinimumSize = new Size(70, 533);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(245, 533);
            sidebar.TabIndex = 8;
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
            Reservations.Click += Reservations_Click_1;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnChat);
            panel4.Location = new Point(3, 306);
            panel4.Name = "panel4";
            panel4.Size = new Size(242, 44);
            panel4.TabIndex = 15;
            // 
            // btnChat
            // 
            btnChat.FlatStyle = FlatStyle.Flat;
            btnChat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnChat.ForeColor = Color.White;
            btnChat.Image = (Image)resources.GetObject("btnChat.Image");
            btnChat.ImageAlign = ContentAlignment.MiddleLeft;
            btnChat.Location = new Point(-16, -8);
            btnChat.Name = "btnChat";
            btnChat.Padding = new Padding(30, 0, 0, 0);
            btnChat.Size = new Size(274, 60);
            btnChat.TabIndex = 2;
            btnChat.Text = "              Chat\r\n";
            btnChat.TextAlign = ContentAlignment.MiddleLeft;
            btnChat.UseVisualStyleBackColor = true;
            btnChat.Click += btnChat_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnSettings);
            panel5.Location = new Point(3, 356);
            panel5.Name = "panel5";
            panel5.Size = new Size(242, 44);
            panel5.TabIndex = 16;
            // 
            // btnSettings
            // 
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSettings.ForeColor = Color.White;
            btnSettings.Image = (Image)resources.GetObject("btnSettings.Image");
            btnSettings.ImageAlign = ContentAlignment.MiddleLeft;
            btnSettings.Location = new Point(-16, -8);
            btnSettings.Name = "btnSettings";
            btnSettings.Padding = new Padding(30, 0, 0, 0);
            btnSettings.Size = new Size(274, 60);
            btnSettings.TabIndex = 2;
            btnSettings.Text = "              Settings\r\n";
            btnSettings.TextAlign = ContentAlignment.MiddleLeft;
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(btnBroadcast);
            panel7.Location = new Point(3, 406);
            panel7.Name = "panel7";
            panel7.Size = new Size(242, 44);
            panel7.TabIndex = 17;
            // 
            // btnBroadcast
            // 
            btnBroadcast.FlatStyle = FlatStyle.Flat;
            btnBroadcast.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBroadcast.ForeColor = Color.White;
            btnBroadcast.Image = (Image)resources.GetObject("btnBroadcast.Image");
            btnBroadcast.ImageAlign = ContentAlignment.MiddleLeft;
            btnBroadcast.Location = new Point(-16, -8);
            btnBroadcast.Name = "btnBroadcast";
            btnBroadcast.Padding = new Padding(30, 0, 0, 0);
            btnBroadcast.Size = new Size(274, 60);
            btnBroadcast.TabIndex = 2;
            btnBroadcast.Text = "              Broadcast\r\n";
            btnBroadcast.TextAlign = ContentAlignment.MiddleLeft;
            btnBroadcast.UseVisualStyleBackColor = true;
            btnBroadcast.Click += btnBroadcast_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // lblTotalReservationsCount
            // 
            lblTotalReservationsCount.AutoSize = true;
            lblTotalReservationsCount.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalReservationsCount.Location = new Point(158, 41);
            lblTotalReservationsCount.Name = "lblTotalReservationsCount";
            lblTotalReservationsCount.Size = new Size(84, 20);
            lblTotalReservationsCount.TabIndex = 17;
            lblTotalReservationsCount.Text = "Select Year:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(158, 74);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 19;
            label2.Text = "Report Type:";
            // 
            // cboReportYear
            // 
            cboReportYear.Font = new Font("Segoe UI", 9.75F);
            cboReportYear.FormattingEnabled = true;
            cboReportYear.Items.AddRange(new object[] { "2023", "2024", "2025" });
            cboReportYear.Location = new Point(262, 40);
            cboReportYear.Name = "cboReportYear";
            cboReportYear.Size = new Size(249, 25);
            cboReportYear.TabIndex = 20;
            // 
            // cboReportType
            // 
            cboReportType.Font = new Font("Segoe UI", 9.75F);
            cboReportType.FormattingEnabled = true;
            cboReportType.Items.AddRange(new object[] { "Monthly Reservations", "Revenue by Month", "Room Occupancy" });
            cboReportType.Location = new Point(262, 74);
            cboReportType.Name = "cboReportType";
            cboReportType.Size = new Size(249, 25);
            cboReportType.TabIndex = 21;
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.BackColor = Color.FromArgb(35, 40, 45);
            btnGenerateReport.FlatAppearance.BorderSize = 0;
            btnGenerateReport.FlatStyle = FlatStyle.Popup;
            btnGenerateReport.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerateReport.ForeColor = Color.White;
            btnGenerateReport.Location = new Point(522, 40);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(88, 57);
            btnGenerateReport.TabIndex = 38;
            btnGenerateReport.Text = "Generate Report";
            btnGenerateReport.UseVisualStyleBackColor = false;
            // 
            // dgvReportDetails
            // 
            dgvReportDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReportDetails.Columns.AddRange(new DataGridViewColumn[] { colMonth, colReservations, colRevenue, colOccupancy });
            dgvReportDetails.Location = new Point(158, 414);
            dgvReportDetails.Name = "dgvReportDetails";
            dgvReportDetails.Size = new Size(832, 109);
            dgvReportDetails.TabIndex = 50;
            dgvReportDetails.CellContentClick += dgvReportDetails_CellContentClick;
            // 
            // colMonth
            // 
            colMonth.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colMonth.HeaderText = "Month";
            colMonth.Name = "colMonth";
            // 
            // colReservations
            // 
            colReservations.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colReservations.HeaderText = "Reservations";
            colReservations.Name = "colReservations";
            // 
            // colRevenue
            // 
            colRevenue.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colRevenue.HeaderText = "Revenue (₱)";
            colRevenue.Name = "colRevenue";
            // 
            // colOccupancy
            // 
            colOccupancy.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colOccupancy.HeaderText = "Occupancy (%)";
            colOccupancy.Name = "colOccupancy";
            // 
            // sqlCommand2
            // 
            sqlCommand2.CommandTimeout = 30;
            sqlCommand2.Connection = null;
            sqlCommand2.Notification = null;
            sqlCommand2.Transaction = null;
            // 
            // pnlChartHost
            // 
            pnlChartHost.AutoSize = true;
            pnlChartHost.Location = new Point(158, 120);
            pnlChartHost.Name = "pnlChartHost";
            pnlChartHost.Size = new Size(832, 288);
            pnlChartHost.TabIndex = 51;
            pnlChartHost.Paint += pnlChartHost_Paint;
            // 
            // ReportsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1070, 533);
            Controls.Add(sidebar);
            Controls.Add(pnlChartHost);
            Controls.Add(dgvReportDetails);
            Controls.Add(btnGenerateReport);
            Controls.Add(cboReportType);
            Controls.Add(cboReportYear);
            Controls.Add(label2);
            Controls.Add(lblTotalReservationsCount);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReportsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form9";
            Load += ReportsForm_Load;
            panel9.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel13.ResumeLayout(false);
            CustomerContainer.ResumeLayout(false);
            panel12.ResumeLayout(false);
            sidebar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).EndInit();
            panel2.ResumeLayout(false);
            ReservationsContainer.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReportDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer sidebarTimer;
        private Button SignOut;
        private Panel panel9;
        private Button Reports;
        private Panel panel6;
        private Button Customer;
        private Panel panel13;
        private Button CustomerDetails;
        private Panel CustomerContainer;
        private Panel panel12;
        private FlowLayoutPanel sidebar;
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
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label lblTotalReservationsCount;
        private Label label2;
        private ComboBox cboReportYear;
        private ComboBox cboReportType;
        private Button btnGenerateReport;
        private DataGridView dgvReportDetails;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand2;
        private Panel pnlChartHost;
        private DataGridViewTextBoxColumn colMonth;
        private DataGridViewTextBoxColumn colReservations;
        private DataGridViewTextBoxColumn colRevenue;
        private DataGridViewTextBoxColumn colOccupancy;
        private Panel panel4;
        private Button btnChat;
        private Panel panel5;
        private Button btnSettings;
        private Panel panel7;
        private Button btnBroadcast;
    }
}