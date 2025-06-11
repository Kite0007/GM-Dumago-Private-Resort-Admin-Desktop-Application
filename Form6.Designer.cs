namespace GM_Dumago_Private_Resort_Admin_Desktop_Application
{
    partial class CustomerManagenentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerManagenentForm));
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
            btnAddNewCustomer = new Button();
            btnRefresh = new Button();
            btnSearch = new Button();
            txtCustomerSearch = new TextBox();
            lblTotalReservationsCount = new Label();
            dgvCustomers = new DataGridView();
            colCustID = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colSukiCard = new DataGridViewTextBoxColumn();
            colViewEdit = new DataGridViewButtonColumn();
            colDelete = new DataGridViewButtonColumn();
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
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            SuspendLayout();
            // 
            // sidebarTimer
            // 
            sidebarTimer.Interval = 10;
            sidebarTimer.Tick += sidebarTimer_Tick;
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
            Reports.Click += Reports_Click;
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
            SukiCard.Click += SukiCard_Click;
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
            Customer.Click += Customer_Click;
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
            sidebar.Size = new Size(70, 533);
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
            Reservations.Click += Reservations_Click;
            // 
            // btnAddNewCustomer
            // 
            btnAddNewCustomer.Location = new Point(632, 56);
            btnAddNewCustomer.Name = "btnAddNewCustomer";
            btnAddNewCustomer.Size = new Size(143, 23);
            btnAddNewCustomer.TabIndex = 19;
            btnAddNewCustomer.Text = "Add New Customer";
            btnAddNewCustomer.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(536, 56);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 18;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(439, 56);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 17;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtCustomerSearch
            // 
            txtCustomerSearch.Location = new Point(205, 56);
            txtCustomerSearch.Name = "txtCustomerSearch";
            txtCustomerSearch.Size = new Size(193, 23);
            txtCustomerSearch.TabIndex = 16;
            // 
            // lblTotalReservationsCount
            // 
            lblTotalReservationsCount.AutoSize = true;
            lblTotalReservationsCount.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalReservationsCount.Location = new Point(143, 56);
            lblTotalReservationsCount.Name = "lblTotalReservationsCount";
            lblTotalReservationsCount.Size = new Size(56, 20);
            lblTotalReservationsCount.TabIndex = 15;
            lblTotalReservationsCount.Text = "Search:";
            // 
            // dgvCustomers
            // 
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Columns.AddRange(new DataGridViewColumn[] { colCustID, colName, colEmail, colSukiCard, colViewEdit, colDelete });
            dgvCustomers.Location = new Point(99, 142);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.Size = new Size(943, 324);
            dgvCustomers.TabIndex = 20;
            dgvCustomers.CellContentClick += dgvCustomers_CellContentClick;
            // 
            // colCustID
            // 
            colCustID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCustID.HeaderText = "Cust ID";
            colCustID.Name = "colCustID";
            // 
            // colName
            // 
            colName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colName.HeaderText = "Name";
            colName.Name = "colName";
            // 
            // colEmail
            // 
            colEmail.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colEmail.HeaderText = "Email";
            colEmail.Name = "colEmail";
            // 
            // colSukiCard
            // 
            colSukiCard.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colSukiCard.HeaderText = "Suki Card";
            colSukiCard.Name = "colSukiCard";
            // 
            // colViewEdit
            // 
            colViewEdit.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colViewEdit.HeaderText = "Actions";
            colViewEdit.Name = "colViewEdit";
            colViewEdit.Resizable = DataGridViewTriState.True;
            colViewEdit.SortMode = DataGridViewColumnSortMode.Automatic;
            colViewEdit.Text = "View/Edit";
            colViewEdit.UseColumnTextForButtonValue = true;
            // 
            // colDelete
            // 
            colDelete.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colDelete.HeaderText = "";
            colDelete.Name = "colDelete";
            colDelete.Text = "Cancel";
            colDelete.UseColumnTextForButtonValue = true;
            // 
            // CustomerManagenentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1070, 533);
            Controls.Add(sidebar);
            Controls.Add(dgvCustomers);
            Controls.Add(btnAddNewCustomer);
            Controls.Add(btnRefresh);
            Controls.Add(btnSearch);
            Controls.Add(txtCustomerSearch);
            Controls.Add(lblTotalReservationsCount);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomerManagenentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form6";
            Load += CustomerManagenentForm_Load;
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
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
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
        private Button btnRefresh;
        private Button btnSearch;
        private TextBox txtCustomerSearch;
        private Label lblTotalReservationsCount;
        private DataGridView dgvCustomers;
        private DataGridViewTextBoxColumn colCustID;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colSukiCard;
        private DataGridViewButtonColumn colViewEdit;
        private DataGridViewButtonColumn colDelete;
    }
}