namespace GM_Dumago_Private_Resort_Admin_Desktop_Application
{
    partial class SukiCardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SukiCardForm));
            sidebarTimer = new System.Windows.Forms.Timer(components);
            SignOut = new Button();
            panel9 = new Panel();
            Reports = new Button();
            panel6 = new Panel();
            SukiCard = new Button();
            panel5 = new Panel();
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
            btnRegisterNewSukiCard = new Button();
            btnLoadCard = new Button();
            txtSukiCardRFID = new TextBox();
            lblTotalReservationsCount = new Label();
            lblCurrentPoints = new Label();
            lblSukiCustomerName = new Label();
            label2 = new Label();
            nudPointsAmount = new NumericUpDown();
            btnDeductPointsDirect = new Button();
            btnAddPointsDirect = new Button();
            label3 = new Label();
            dgvPointsHistory = new DataGridView();
            colDate = new DataGridViewTextBoxColumn();
            colType = new DataGridViewTextBoxColumn();
            colPointsChange = new DataGridViewTextBoxColumn();
            colDescription = new DataGridViewTextBoxColumn();
            panel9.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)nudPointsAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPointsHistory).BeginInit();
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
            // panel9
            // 
            panel9.Controls.Add(SignOut);
            panel9.Location = new Point(3, 356);
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
            Reports.Click += Reports_Click_1;
            // 
            // panel6
            // 
            panel6.Controls.Add(Reports);
            panel6.Location = new Point(3, 306);
            panel6.Name = "panel6";
            panel6.Size = new Size(242, 44);
            panel6.TabIndex = 5;
            // 
            // SukiCard
            // 
            SukiCard.FlatStyle = FlatStyle.Flat;
            SukiCard.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SukiCard.ForeColor = Color.White;
            SukiCard.Image = (Image)resources.GetObject("SukiCard.Image");
            SukiCard.ImageAlign = ContentAlignment.MiddleLeft;
            SukiCard.Location = new Point(-16, -8);
            SukiCard.Name = "SukiCard";
            SukiCard.Padding = new Padding(30, 0, 0, 0);
            SukiCard.Size = new Size(274, 60);
            SukiCard.TabIndex = 2;
            SukiCard.Text = "              Suki Cards";
            SukiCard.TextAlign = ContentAlignment.MiddleLeft;
            SukiCard.UseVisualStyleBackColor = true;
            SukiCard.Click += SukiCard_Click_1;
            // 
            // panel5
            // 
            panel5.Controls.Add(SukiCard);
            panel5.Location = new Point(3, 256);
            panel5.Name = "panel5";
            panel5.Size = new Size(242, 44);
            panel5.TabIndex = 4;
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
            sidebar.Controls.Add(panel5);
            sidebar.Controls.Add(panel6);
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
            // btnRegisterNewSukiCard
            // 
            btnRegisterNewSukiCard.BackColor = Color.FromArgb(35, 40, 45);
            btnRegisterNewSukiCard.FlatStyle = FlatStyle.Popup;
            btnRegisterNewSukiCard.ForeColor = Color.White;
            btnRegisterNewSukiCard.Location = new Point(605, 32);
            btnRegisterNewSukiCard.Name = "btnRegisterNewSukiCard";
            btnRegisterNewSukiCard.Size = new Size(129, 23);
            btnRegisterNewSukiCard.TabIndex = 23;
            btnRegisterNewSukiCard.Text = "Register New Card";
            btnRegisterNewSukiCard.UseVisualStyleBackColor = false;
            // 
            // btnLoadCard
            // 
            btnLoadCard.BackColor = Color.FromArgb(35, 40, 45);
            btnLoadCard.FlatStyle = FlatStyle.Popup;
            btnLoadCard.ForeColor = Color.White;
            btnLoadCard.Location = new Point(525, 32);
            btnLoadCard.Name = "btnLoadCard";
            btnLoadCard.Size = new Size(75, 23);
            btnLoadCard.TabIndex = 22;
            btnLoadCard.Text = "Load Card";
            btnLoadCard.UseVisualStyleBackColor = false;
            // 
            // txtSukiCardRFID
            // 
            txtSukiCardRFID.Font = new Font("Segoe UI", 9.75F);
            txtSukiCardRFID.Location = new Point(260, 32);
            txtSukiCardRFID.Name = "txtSukiCardRFID";
            txtSukiCardRFID.Size = new Size(259, 25);
            txtSukiCardRFID.TabIndex = 21;
            // 
            // lblTotalReservationsCount
            // 
            lblTotalReservationsCount.AutoSize = true;
            lblTotalReservationsCount.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalReservationsCount.Location = new Point(137, 33);
            lblTotalReservationsCount.Name = "lblTotalReservationsCount";
            lblTotalReservationsCount.Size = new Size(109, 20);
            lblTotalReservationsCount.TabIndex = 20;
            lblTotalReservationsCount.Text = "Suki Card RFID:";
            // 
            // lblCurrentPoints
            // 
            lblCurrentPoints.AutoSize = true;
            lblCurrentPoints.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCurrentPoints.Location = new Point(137, 117);
            lblCurrentPoints.Name = "lblCurrentPoints";
            lblCurrentPoints.Size = new Size(103, 20);
            lblCurrentPoints.TabIndex = 25;
            lblCurrentPoints.Text = "Current Points:";
            // 
            // lblSukiCustomerName
            // 
            lblSukiCustomerName.AutoSize = true;
            lblSukiCustomerName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSukiCustomerName.Location = new Point(137, 74);
            lblSukiCustomerName.Name = "lblSukiCustomerName";
            lblSukiCustomerName.Size = new Size(119, 20);
            lblSukiCustomerName.TabIndex = 24;
            lblSukiCustomerName.Text = "Customer Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(137, 158);
            label2.Name = "label2";
            label2.Size = new Size(115, 20);
            label2.TabIndex = 26;
            label2.Text = "Points to Adjust:";
            // 
            // nudPointsAmount
            // 
            nudPointsAmount.Font = new Font("Segoe UI", 9.75F);
            nudPointsAmount.Location = new Point(266, 158);
            nudPointsAmount.Name = "nudPointsAmount";
            nudPointsAmount.Size = new Size(68, 25);
            nudPointsAmount.TabIndex = 27;
            // 
            // btnDeductPointsDirect
            // 
            btnDeductPointsDirect.BackColor = Color.FromArgb(35, 40, 45);
            btnDeductPointsDirect.FlatAppearance.BorderSize = 0;
            btnDeductPointsDirect.FlatStyle = FlatStyle.Popup;
            btnDeductPointsDirect.Font = new Font("Arial", 9F);
            btnDeductPointsDirect.ForeColor = Color.White;
            btnDeductPointsDirect.Location = new Point(425, 159);
            btnDeductPointsDirect.Name = "btnDeductPointsDirect";
            btnDeductPointsDirect.Size = new Size(94, 22);
            btnDeductPointsDirect.TabIndex = 47;
            btnDeductPointsDirect.Text = "Deduct Points";
            btnDeductPointsDirect.UseVisualStyleBackColor = false;
            // 
            // btnAddPointsDirect
            // 
            btnAddPointsDirect.BackColor = Color.FromArgb(35, 40, 45);
            btnAddPointsDirect.FlatAppearance.BorderSize = 0;
            btnAddPointsDirect.FlatStyle = FlatStyle.Popup;
            btnAddPointsDirect.Font = new Font("Arial", 9F);
            btnAddPointsDirect.ForeColor = Color.White;
            btnAddPointsDirect.Location = new Point(340, 158);
            btnAddPointsDirect.Name = "btnAddPointsDirect";
            btnAddPointsDirect.Size = new Size(79, 22);
            btnAddPointsDirect.TabIndex = 46;
            btnAddPointsDirect.Text = "Add Points";
            btnAddPointsDirect.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(137, 233);
            label3.Name = "label3";
            label3.Size = new Size(181, 20);
            label3.TabIndex = 48;
            label3.Text = "Points Transaction History:";
            // 
            // dgvPointsHistory
            // 
            dgvPointsHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPointsHistory.Columns.AddRange(new DataGridViewColumn[] { colDate, colType, colPointsChange, colDescription });
            dgvPointsHistory.Location = new Point(99, 271);
            dgvPointsHistory.Name = "dgvPointsHistory";
            dgvPointsHistory.Size = new Size(943, 235);
            dgvPointsHistory.TabIndex = 49;
            dgvPointsHistory.CellContentClick += dgvPointsHistory_CellContentClick;
            // 
            // colDate
            // 
            colDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colDate.HeaderText = "Date";
            colDate.Name = "colDate";
            // 
            // colType
            // 
            colType.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colType.HeaderText = "Type";
            colType.Name = "colType";
            // 
            // colPointsChange
            // 
            colPointsChange.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colPointsChange.HeaderText = "Points Change";
            colPointsChange.Name = "colPointsChange";
            // 
            // colDescription
            // 
            colDescription.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colDescription.HeaderText = "Description";
            colDescription.Name = "colDescription";
            // 
            // SukiCardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1070, 533);
            Controls.Add(sidebar);
            Controls.Add(dgvPointsHistory);
            Controls.Add(label3);
            Controls.Add(btnDeductPointsDirect);
            Controls.Add(btnAddPointsDirect);
            Controls.Add(nudPointsAmount);
            Controls.Add(label2);
            Controls.Add(lblCurrentPoints);
            Controls.Add(lblSukiCustomerName);
            Controls.Add(btnRegisterNewSukiCard);
            Controls.Add(btnLoadCard);
            Controls.Add(txtSukiCardRFID);
            Controls.Add(lblTotalReservationsCount);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SukiCardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form8";
            Load += SukiCardForm_Load;
            panel9.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
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
            ((System.ComponentModel.ISupportInitialize)nudPointsAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPointsHistory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer sidebarTimer;
        private Button SignOut;
        private Panel panel9;
        private Button Reports;
        private Panel panel6;
        private Button SukiCard;
        private Panel panel5;
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
        private Button btnAddNewCustomer;
        private Button btnRegisterNewSukiCard;
        private Button btnLoadCard;
        private TextBox txtSukiCardRFID;
        private Label lblTotalReservationsCount;
        private Label lblCurrentPoints;
        private Label lblSukiCustomerName;
        private Label label2;
        private NumericUpDown nudPointsAmount;
        private Button btnDeductPointsDirect;
        private Button btnAddPointsDirect;
        private Label label3;
        private DataGridView dgvPointsHistory;
        private DataGridViewTextBoxColumn colDate;
        private DataGridViewTextBoxColumn colType;
        private DataGridViewTextBoxColumn colPointsChange;
        private DataGridViewTextBoxColumn colDescription;
    }
}