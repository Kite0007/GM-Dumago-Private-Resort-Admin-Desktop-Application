namespace GM_Dumago_Private_Resort_Admin_Desktop_Application
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
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
            CustomerContainer = new Panel();
            panel12 = new Panel();
            CustomerDetails = new Button();
            panel13 = new Panel();
            Customer = new Button();
            panel6 = new Panel();
            Reports = new Button();
            panel4 = new Panel();
            btnChat = new Button();
            panel5 = new Panel();
            btnSettings = new Button();
            panel7 = new Panel();
            btnBroadcast = new Button();
            panel9 = new Panel();
            SignOut = new Button();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            label6 = new Label();
            dgvRoomTypes = new DataGridView();
            colPackageName = new DataGridViewTextBoxColumn();
            colShift = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            colDownpayment = new DataGridViewTextBoxColumn();
            colEditPackage = new DataGridViewButtonColumn();
            colDeletePackage = new DataGridViewButtonColumn();
            label8 = new Label();
            nudExtraPersonFee = new NumericUpDown();
            label2 = new Label();
            label4 = new Label();
            lstVenues = new ListBox();
            label5 = new Label();
            btnAddPkg = new Button();
            btnAddNewVenue = new Button();
            label7 = new Label();
            dgvMenuItems = new DataGridView();
            colResID = new DataGridViewTextBoxColumn();
            colCustomerName = new DataGridViewTextBoxColumn();
            colCheckIn = new DataGridViewTextBoxColumn();
            colViewEdit = new DataGridViewButtonColumn();
            colCancel = new DataGridViewButtonColumn();
            label3 = new Label();
            btnSaveChanges_Fees = new Button();
            VenuePackageDetailspnl = new Panel();
            label13 = new Label();
            MenuItemDetailspnl = new Panel();
            btnCancelMenu = new Button();
            btnSaveMenu = new Button();
            label14 = new Label();
            nudItemPrice = new NumericUpDown();
            label16 = new Label();
            txtItemDescription = new TextBox();
            label17 = new Label();
            txtItemName = new TextBox();
            label18 = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            nudDownpayment = new NumericUpDown();
            label12 = new Label();
            nudPrice = new NumericUpDown();
            label11 = new Label();
            txtShift = new TextBox();
            label10 = new Label();
            txtPackageName = new TextBox();
            label9 = new Label();
            sidebar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).BeginInit();
            panel2.SuspendLayout();
            ReservationsContainer.SuspendLayout();
            panel10.SuspendLayout();
            panel3.SuspendLayout();
            CustomerContainer.SuspendLayout();
            panel12.SuspendLayout();
            panel13.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRoomTypes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudExtraPersonFee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMenuItems).BeginInit();
            VenuePackageDetailspnl.SuspendLayout();
            MenuItemDetailspnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudItemPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDownpayment).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            SuspendLayout();
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
            sidebar.TabIndex = 48;
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
            // panel9
            // 
            panel9.Controls.Add(SignOut);
            panel9.Location = new Point(3, 456);
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
            // sidebarTimer
            // 
            sidebarTimer.Interval = 10;
            sidebarTimer.Tick += sidebarTimer_Tick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Palatino Linotype", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(101, 17);
            label6.Name = "label6";
            label6.Size = new Size(258, 32);
            label6.TabIndex = 66;
            label6.Text = "Settings & Management";
            // 
            // dgvRoomTypes
            // 
            dgvRoomTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoomTypes.Columns.AddRange(new DataGridViewColumn[] { colPackageName, colShift, colPrice, colDownpayment, colEditPackage, colDeletePackage });
            dgvRoomTypes.Location = new Point(417, 127);
            dgvRoomTypes.Name = "dgvRoomTypes";
            dgvRoomTypes.Size = new Size(581, 136);
            dgvRoomTypes.TabIndex = 67;
            dgvRoomTypes.CellContentClick += dgvMenuItems_CellContentClick;
            // 
            // colPackageName
            // 
            colPackageName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colPackageName.HeaderText = "Pkg Name";
            colPackageName.Name = "colPackageName";
            // 
            // colShift
            // 
            colShift.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colShift.HeaderText = "Shift";
            colShift.Name = "colShift";
            // 
            // colPrice
            // 
            colPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colPrice.HeaderText = "Price";
            colPrice.Name = "colPrice";
            // 
            // colDownpayment
            // 
            colDownpayment.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colDownpayment.HeaderText = "D/P";
            colDownpayment.Name = "colDownpayment";
            // 
            // colEditPackage
            // 
            colEditPackage.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colEditPackage.HeaderText = "Action";
            colEditPackage.Name = "colEditPackage";
            colEditPackage.Text = "Edit";
            colEditPackage.UseColumnTextForButtonValue = true;
            // 
            // colDeletePackage
            // 
            colDeletePackage.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colDeletePackage.HeaderText = "";
            colDeletePackage.Name = "colDeletePackage";
            colDeletePackage.Text = "Delete";
            colDeletePackage.UseColumnTextForButtonValue = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(205, 483);
            label8.Name = "label8";
            label8.Size = new Size(142, 20);
            label8.TabIndex = 71;
            label8.Text = "Fee for Extra Person:";
            // 
            // nudExtraPersonFee
            // 
            nudExtraPersonFee.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudExtraPersonFee.Location = new Point(353, 481);
            nudExtraPersonFee.Name = "nudExtraPersonFee";
            nudExtraPersonFee.Size = new Size(54, 27);
            nudExtraPersonFee.TabIndex = 73;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(163, 64);
            label2.Name = "label2";
            label2.Size = new Size(216, 20);
            label2.TabIndex = 74;
            label2.Text = "Venue & Package Management";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(195, 98);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 75;
            label4.Text = "Venues";
            // 
            // lstVenues
            // 
            lstVenues.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstVenues.FormattingEnabled = true;
            lstVenues.ItemHeight = 20;
            lstVenues.Items.AddRange(new object[] { "Main Pool Area", "Function Hall", "Private Villa" });
            lstVenues.Location = new Point(205, 127);
            lstVenues.Name = "lstVenues";
            lstVenues.Size = new Size(202, 104);
            lstVenues.TabIndex = 76;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(417, 98);
            label5.Name = "label5";
            label5.Size = new Size(197, 20);
            label5.TabIndex = 77;
            label5.Text = "Packages for Selected Venue";
            // 
            // btnAddPkg
            // 
            btnAddPkg.BackColor = Color.FromArgb(35, 40, 45);
            btnAddPkg.FlatAppearance.BorderSize = 0;
            btnAddPkg.FlatStyle = FlatStyle.Popup;
            btnAddPkg.Font = new Font("Arial", 9.75F);
            btnAddPkg.ForeColor = Color.White;
            btnAddPkg.Location = new Point(309, 235);
            btnAddPkg.Name = "btnAddPkg";
            btnAddPkg.Size = new Size(98, 28);
            btnAddPkg.TabIndex = 79;
            btnAddPkg.Text = "Add Pkg";
            btnAddPkg.UseVisualStyleBackColor = false;
            // 
            // btnAddNewVenue
            // 
            btnAddNewVenue.BackColor = Color.FromArgb(35, 40, 45);
            btnAddNewVenue.FlatAppearance.BorderSize = 0;
            btnAddNewVenue.FlatStyle = FlatStyle.Popup;
            btnAddNewVenue.Font = new Font("Arial", 9.75F);
            btnAddNewVenue.ForeColor = Color.White;
            btnAddNewVenue.Location = new Point(205, 235);
            btnAddNewVenue.Name = "btnAddNewVenue";
            btnAddNewVenue.Size = new Size(98, 28);
            btnAddNewVenue.TabIndex = 78;
            btnAddNewVenue.Text = "Add Venue";
            btnAddNewVenue.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label7.Location = new Point(163, 280);
            label7.Name = "label7";
            label7.Size = new Size(125, 20);
            label7.TabIndex = 80;
            label7.Text = "Food Menu Items";
            // 
            // dgvMenuItems
            // 
            dgvMenuItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMenuItems.Columns.AddRange(new DataGridViewColumn[] { colResID, colCustomerName, colCheckIn, colViewEdit, colCancel });
            dgvMenuItems.Location = new Point(417, 298);
            dgvMenuItems.Name = "dgvMenuItems";
            dgvMenuItems.Size = new Size(585, 136);
            dgvMenuItems.TabIndex = 81;
            dgvMenuItems.CellContentClick += dgvMenuItems_CellContentClick;
            // 
            // colResID
            // 
            colResID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colResID.HeaderText = "Item Name";
            colResID.Name = "colResID";
            // 
            // colCustomerName
            // 
            colCustomerName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCustomerName.HeaderText = "Description";
            colCustomerName.Name = "colCustomerName";
            // 
            // colCheckIn
            // 
            colCheckIn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCheckIn.HeaderText = "Price";
            colCheckIn.Name = "colCheckIn";
            // 
            // colViewEdit
            // 
            colViewEdit.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colViewEdit.HeaderText = "Action";
            colViewEdit.Name = "colViewEdit";
            colViewEdit.Resizable = DataGridViewTriState.True;
            colViewEdit.SortMode = DataGridViewColumnSortMode.Automatic;
            colViewEdit.Text = "Edit";
            colViewEdit.UseColumnTextForButtonValue = true;
            // 
            // colCancel
            // 
            colCancel.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCancel.HeaderText = "";
            colCancel.Name = "colCancel";
            colCancel.Text = "Delete";
            colCancel.UseColumnTextForButtonValue = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.Location = new Point(163, 451);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 82;
            label3.Text = "Other Fees";
            // 
            // btnSaveChanges_Fees
            // 
            btnSaveChanges_Fees.BackColor = Color.FromArgb(35, 40, 45);
            btnSaveChanges_Fees.FlatAppearance.BorderSize = 0;
            btnSaveChanges_Fees.FlatStyle = FlatStyle.Popup;
            btnSaveChanges_Fees.Font = new Font("Arial", 9.75F);
            btnSaveChanges_Fees.ForeColor = Color.White;
            btnSaveChanges_Fees.Location = new Point(417, 481);
            btnSaveChanges_Fees.Name = "btnSaveChanges_Fees";
            btnSaveChanges_Fees.Size = new Size(154, 27);
            btnSaveChanges_Fees.TabIndex = 83;
            btnSaveChanges_Fees.Text = "Save Fee Changes";
            btnSaveChanges_Fees.UseVisualStyleBackColor = false;
            // 
            // VenuePackageDetailspnl
            // 
            VenuePackageDetailspnl.Controls.Add(label13);
            VenuePackageDetailspnl.Controls.Add(MenuItemDetailspnl);
            VenuePackageDetailspnl.Controls.Add(btnCancel);
            VenuePackageDetailspnl.Controls.Add(btnSave);
            VenuePackageDetailspnl.Controls.Add(nudDownpayment);
            VenuePackageDetailspnl.Controls.Add(label12);
            VenuePackageDetailspnl.Controls.Add(nudPrice);
            VenuePackageDetailspnl.Controls.Add(label11);
            VenuePackageDetailspnl.Controls.Add(txtShift);
            VenuePackageDetailspnl.Controls.Add(label10);
            VenuePackageDetailspnl.Controls.Add(txtPackageName);
            VenuePackageDetailspnl.Controls.Add(label9);
            VenuePackageDetailspnl.Location = new Point(376, 79);
            VenuePackageDetailspnl.Name = "VenuePackageDetailspnl";
            VenuePackageDetailspnl.Size = new Size(420, 371);
            VenuePackageDetailspnl.TabIndex = 84;
            VenuePackageDetailspnl.Visible = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(17, 19);
            label13.Name = "label13";
            label13.Size = new Size(124, 20);
            label13.TabIndex = 82;
            label13.Text = " Package Details ";
            // 
            // MenuItemDetailspnl
            // 
            MenuItemDetailspnl.Controls.Add(btnCancelMenu);
            MenuItemDetailspnl.Controls.Add(btnSaveMenu);
            MenuItemDetailspnl.Controls.Add(label14);
            MenuItemDetailspnl.Controls.Add(nudItemPrice);
            MenuItemDetailspnl.Controls.Add(label16);
            MenuItemDetailspnl.Controls.Add(txtItemDescription);
            MenuItemDetailspnl.Controls.Add(label17);
            MenuItemDetailspnl.Controls.Add(txtItemName);
            MenuItemDetailspnl.Controls.Add(label18);
            MenuItemDetailspnl.Location = new Point(3, 0);
            MenuItemDetailspnl.Name = "MenuItemDetailspnl";
            MenuItemDetailspnl.Size = new Size(420, 371);
            MenuItemDetailspnl.TabIndex = 85;
            MenuItemDetailspnl.Visible = false;
            // 
            // btnCancelMenu
            // 
            btnCancelMenu.BackColor = Color.FromArgb(35, 40, 45);
            btnCancelMenu.FlatAppearance.BorderSize = 0;
            btnCancelMenu.FlatStyle = FlatStyle.Popup;
            btnCancelMenu.Font = new Font("Arial", 9.75F);
            btnCancelMenu.ForeColor = Color.White;
            btnCancelMenu.Location = new Point(210, 320);
            btnCancelMenu.Name = "btnCancelMenu";
            btnCancelMenu.Size = new Size(98, 28);
            btnCancelMenu.TabIndex = 84;
            btnCancelMenu.Text = "Cancel";
            btnCancelMenu.UseVisualStyleBackColor = false;
            // 
            // btnSaveMenu
            // 
            btnSaveMenu.BackColor = Color.FromArgb(35, 40, 45);
            btnSaveMenu.FlatAppearance.BorderSize = 0;
            btnSaveMenu.FlatStyle = FlatStyle.Popup;
            btnSaveMenu.Font = new Font("Arial", 9.75F);
            btnSaveMenu.ForeColor = Color.White;
            btnSaveMenu.Location = new Point(106, 320);
            btnSaveMenu.Name = "btnSaveMenu";
            btnSaveMenu.Size = new Size(98, 28);
            btnSaveMenu.TabIndex = 83;
            btnSaveMenu.Text = "Save";
            btnSaveMenu.UseVisualStyleBackColor = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(17, 19);
            label14.Name = "label14";
            label14.Size = new Size(133, 20);
            label14.TabIndex = 82;
            label14.Text = "Menu Item Details";
            // 
            // nudItemPrice
            // 
            nudItemPrice.Font = new Font("Segoe UI", 11.25F);
            nudItemPrice.Location = new Point(151, 252);
            nudItemPrice.Name = "nudItemPrice";
            nudItemPrice.Size = new Size(228, 27);
            nudItemPrice.TabIndex = 77;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(52, 254);
            label16.Name = "label16";
            label16.Size = new Size(44, 20);
            label16.TabIndex = 76;
            label16.Text = "Price:";
            // 
            // txtItemDescription
            // 
            txtItemDescription.Font = new Font("Segoe UI", 11.25F);
            txtItemDescription.Location = new Point(151, 130);
            txtItemDescription.Multiline = true;
            txtItemDescription.Name = "txtItemDescription";
            txtItemDescription.Size = new Size(228, 116);
            txtItemDescription.TabIndex = 75;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.Location = new Point(48, 127);
            label17.Name = "label17";
            label17.Size = new Size(88, 20);
            label17.TabIndex = 74;
            label17.Text = "Description:";
            // 
            // txtItemName
            // 
            txtItemName.Font = new Font("Segoe UI", 11.25F);
            txtItemName.Location = new Point(151, 79);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(228, 27);
            txtItemName.TabIndex = 73;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.Location = new Point(48, 81);
            label18.Name = "label18";
            label18.Size = new Size(86, 20);
            label18.TabIndex = 72;
            label18.Text = "Item Name:";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(35, 40, 45);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Arial", 9.75F);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(210, 323);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(98, 28);
            btnCancel.TabIndex = 81;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(35, 40, 45);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Arial", 9.75F);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(106, 323);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(98, 28);
            btnSave.TabIndex = 80;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // nudDownpayment
            // 
            nudDownpayment.Font = new Font("Segoe UI", 11.25F);
            nudDownpayment.Location = new Point(176, 240);
            nudDownpayment.Name = "nudDownpayment";
            nudDownpayment.Size = new Size(203, 27);
            nudDownpayment.TabIndex = 79;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(49, 242);
            label12.Name = "label12";
            label12.Size = new Size(109, 20);
            label12.TabIndex = 78;
            label12.Text = "Downpayment:";
            // 
            // nudPrice
            // 
            nudPrice.Font = new Font("Segoe UI", 11.25F);
            nudPrice.Location = new Point(176, 189);
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(203, 27);
            nudPrice.TabIndex = 77;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(52, 191);
            label11.Name = "label11";
            label11.Size = new Size(44, 20);
            label11.TabIndex = 76;
            label11.Text = "Price:";
            // 
            // txtShift
            // 
            txtShift.Font = new Font("Segoe UI", 11.25F);
            txtShift.Location = new Point(176, 130);
            txtShift.Name = "txtShift";
            txtShift.Size = new Size(203, 27);
            txtShift.TabIndex = 75;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(52, 133);
            label10.Name = "label10";
            label10.Size = new Size(42, 20);
            label10.TabIndex = 74;
            label10.Text = "Shift:";
            // 
            // txtPackageName
            // 
            txtPackageName.Font = new Font("Segoe UI", 11.25F);
            txtPackageName.Location = new Point(176, 79);
            txtPackageName.Name = "txtPackageName";
            txtPackageName.Size = new Size(203, 27);
            txtPackageName.TabIndex = 73;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(48, 82);
            label9.Name = "label9";
            label9.Size = new Size(110, 20);
            label9.TabIndex = 72;
            label9.Text = "Package Name:";
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1070, 533);
            Controls.Add(sidebar);
            Controls.Add(VenuePackageDetailspnl);
            Controls.Add(btnSaveChanges_Fees);
            Controls.Add(label3);
            Controls.Add(dgvMenuItems);
            Controls.Add(label7);
            Controls.Add(btnAddPkg);
            Controls.Add(btnAddNewVenue);
            Controls.Add(label5);
            Controls.Add(lstVenues);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(nudExtraPersonFee);
            Controls.Add(label8);
            Controls.Add(dgvRoomTypes);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SettingsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "1070, 533";
            Load += SettingsForm_Load;
            sidebar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).EndInit();
            panel2.ResumeLayout(false);
            ReservationsContainer.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel3.ResumeLayout(false);
            CustomerContainer.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel13.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRoomTypes).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudExtraPersonFee).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMenuItems).EndInit();
            VenuePackageDetailspnl.ResumeLayout(false);
            VenuePackageDetailspnl.PerformLayout();
            MenuItemDetailspnl.ResumeLayout(false);
            MenuItemDetailspnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudItemPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDownpayment).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private Panel CustomerContainer;
        private Panel panel12;
        private Button CustomerDetails;
        private Panel panel13;
        private Button Customer;
        private Panel panel6;
        private Button Reports;
        private Panel panel4;
        private Button btnChat;
        private Panel panel5;
        private Button btnSettings;
        private Panel panel7;
        private Button btnBroadcast;
        private Panel panel9;
        private Button SignOut;
        private System.Windows.Forms.Timer sidebarTimer;
        private Label label6;
        private DataGridView dgvRoomTypes;
        private Label label8;
        private NumericUpDown nudExtraPersonFee;
        private Label label2;
        private Label label4;
        private ListBox lstVenues;
        private Label label5;
        private Button btnAddPkg;
        private Button btnAddNewVenue;
        private Label label7;
        private DataGridView dgvMenuItems;
        private DataGridViewTextBoxColumn colResID;
        private DataGridViewTextBoxColumn colCustomerName;
        private DataGridViewTextBoxColumn colCheckIn;
        private DataGridViewButtonColumn colViewEdit;
        private DataGridViewButtonColumn colCancel;
        private Label label3;
        private Button btnSaveChanges_Fees;
        private Panel VenuePackageDetailspnl;
        private Label label9;
        private TextBox txtShift;
        private Label label10;
        private TextBox txtPackageName;
        private NumericUpDown nudDownpayment;
        private Label label12;
        private NumericUpDown nudPrice;
        private Label label11;
        private Button btnCancel;
        private Button btnSave;
        private Label label13;
        private Panel MenuItemDetailspnl;
        private Label label14;
        private Button btnCancelMenu;
        private Button btnSaveMenu;
        private NumericUpDown numericUpDown1;
        private Label label15;
        private NumericUpDown nudItemPrice;
        private Label label16;
        private TextBox txtItemDescription;
        private Label label17;
        private TextBox txtItemName;
        private Label label18;
        private DataGridViewTextBoxColumn colPackageName;
        private DataGridViewTextBoxColumn colShift;
        private DataGridViewTextBoxColumn colPrice;
        private DataGridViewTextBoxColumn colDownpayment;
        private DataGridViewButtonColumn colEditPackage;
        private DataGridViewButtonColumn colDeletePackage;
    }
}