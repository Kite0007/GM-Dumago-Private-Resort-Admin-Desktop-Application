namespace GM_Dumago_Private_Resort_Admin_Desktop_Application
{
    partial class ReservationDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservationDetailsForm));
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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            lblTotalReservationsCount = new Label();
            txtReservationID = new TextBox();
            txtCustomerName = new TextBox();
            dtpCheckInDate = new DateTimePicker();
            dtpCheckOutDate = new DateTimePicker();
            a = new Label();
            label6 = new Label();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            btnSaveReservation = new Button();
            btnCancelEdit = new Button();
            nudNumAdults = new NumericUpDown();
            nudNumKids = new NumericUpDown();
            cboRoomType = new ComboBox();
            txtTotalAmount = new TextBox();
            cboPaymentStatus = new ComboBox();
            cboReservationStatus = new ComboBox();
            txtNotes = new TextBox();
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
            ((System.ComponentModel.ISupportInitialize)nudNumAdults).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNumKids).BeginInit();
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(134, 65);
            label4.Name = "label4";
            label4.Size = new Size(119, 20);
            label4.TabIndex = 18;
            label4.Text = "Customer Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(134, 112);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 17;
            label3.Text = "Check-in Date:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(134, 145);
            label2.Name = "label2";
            label2.Size = new Size(115, 20);
            label2.TabIndex = 16;
            label2.Text = "Check-out Date:";
            // 
            // lblTotalReservationsCount
            // 
            lblTotalReservationsCount.AutoSize = true;
            lblTotalReservationsCount.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalReservationsCount.Location = new Point(134, 33);
            lblTotalReservationsCount.Name = "lblTotalReservationsCount";
            lblTotalReservationsCount.Size = new Size(108, 20);
            lblTotalReservationsCount.TabIndex = 15;
            lblTotalReservationsCount.Text = "Reservation ID:";
            // 
            // txtReservationID
            // 
            txtReservationID.Font = new Font("Segoe UI", 9.75F);
            txtReservationID.Location = new Point(273, 34);
            txtReservationID.Name = "txtReservationID";
            txtReservationID.Size = new Size(222, 25);
            txtReservationID.TabIndex = 19;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Font = new Font("Segoe UI", 9.75F);
            txtCustomerName.Location = new Point(273, 63);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(222, 25);
            txtCustomerName.TabIndex = 20;
            // 
            // dtpCheckInDate
            // 
            dtpCheckInDate.Font = new Font("Segoe UI", 9.75F);
            dtpCheckInDate.Location = new Point(273, 112);
            dtpCheckInDate.Name = "dtpCheckInDate";
            dtpCheckInDate.Size = new Size(222, 25);
            dtpCheckInDate.TabIndex = 21;
            // 
            // dtpCheckOutDate
            // 
            dtpCheckOutDate.Font = new Font("Segoe UI", 9.75F);
            dtpCheckOutDate.Location = new Point(273, 145);
            dtpCheckOutDate.Name = "dtpCheckOutDate";
            dtpCheckOutDate.Size = new Size(222, 25);
            dtpCheckOutDate.TabIndex = 22;
            // 
            // a
            // 
            a.AutoSize = true;
            a.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            a.Location = new Point(134, 215);
            a.Name = "a";
            a.Size = new Size(54, 20);
            a.TabIndex = 23;
            a.Text = "Adults:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(329, 217);
            label6.Name = "label6";
            label6.Size = new Size(40, 20);
            label6.TabIndex = 25;
            label6.Text = "Kids:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(134, 273);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 26;
            label5.Text = "Room Type:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(134, 304);
            label7.Name = "label7";
            label7.Size = new Size(102, 20);
            label7.TabIndex = 27;
            label7.Text = "Total Amount:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(134, 398);
            label8.Name = "label8";
            label8.Size = new Size(133, 20);
            label8.TabIndex = 29;
            label8.Text = "Reservation Status:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(134, 367);
            label9.Name = "label9";
            label9.Size = new Size(112, 20);
            label9.TabIndex = 28;
            label9.Text = "Payment Status:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(548, 37);
            label10.Name = "label10";
            label10.Size = new Size(51, 20);
            label10.TabIndex = 30;
            label10.Text = "Notes:";
            // 
            // btnSaveReservation
            // 
            btnSaveReservation.BackColor = Color.FromArgb(35, 40, 45);
            btnSaveReservation.FlatAppearance.BorderSize = 0;
            btnSaveReservation.FlatStyle = FlatStyle.Popup;
            btnSaveReservation.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveReservation.ForeColor = Color.White;
            btnSaveReservation.Location = new Point(524, 412);
            btnSaveReservation.Name = "btnSaveReservation";
            btnSaveReservation.Size = new Size(232, 37);
            btnSaveReservation.TabIndex = 35;
            btnSaveReservation.Text = "Save Changes";
            btnSaveReservation.UseVisualStyleBackColor = false;
            // 
            // btnCancelEdit
            // 
            btnCancelEdit.BackColor = Color.FromArgb(35, 40, 45);
            btnCancelEdit.FlatAppearance.BorderSize = 0;
            btnCancelEdit.FlatStyle = FlatStyle.Popup;
            btnCancelEdit.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelEdit.ForeColor = Color.White;
            btnCancelEdit.Location = new Point(791, 412);
            btnCancelEdit.Name = "btnCancelEdit";
            btnCancelEdit.Size = new Size(232, 37);
            btnCancelEdit.TabIndex = 36;
            btnCancelEdit.Text = "Cancel";
            btnCancelEdit.UseVisualStyleBackColor = false;
            // 
            // nudNumAdults
            // 
            nudNumAdults.Font = new Font("Segoe UI", 9.75F);
            nudNumAdults.Location = new Point(198, 215);
            nudNumAdults.Name = "nudNumAdults";
            nudNumAdults.Size = new Size(120, 25);
            nudNumAdults.TabIndex = 37;
            // 
            // nudNumKids
            // 
            nudNumKids.Font = new Font("Segoe UI", 9.75F);
            nudNumKids.Location = new Point(375, 217);
            nudNumKids.Name = "nudNumKids";
            nudNumKids.Size = new Size(120, 25);
            nudNumKids.TabIndex = 38;
            // 
            // cboRoomType
            // 
            cboRoomType.Font = new Font("Segoe UI", 9.75F);
            cboRoomType.FormattingEnabled = true;
            cboRoomType.Items.AddRange(new object[] { "Standard Room", "Deluxe Room", "Family Suite" });
            cboRoomType.Location = new Point(273, 273);
            cboRoomType.Name = "cboRoomType";
            cboRoomType.Size = new Size(222, 25);
            cboRoomType.TabIndex = 39;
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Font = new Font("Segoe UI", 9.75F);
            txtTotalAmount.Location = new Point(273, 305);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.Size = new Size(222, 25);
            txtTotalAmount.TabIndex = 40;
            // 
            // cboPaymentStatus
            // 
            cboPaymentStatus.Font = new Font("Segoe UI", 9.75F);
            cboPaymentStatus.FormattingEnabled = true;
            cboPaymentStatus.Items.AddRange(new object[] { "Pending", "Paid", "Refunded" });
            cboPaymentStatus.Location = new Point(273, 368);
            cboPaymentStatus.Name = "cboPaymentStatus";
            cboPaymentStatus.Size = new Size(222, 25);
            cboPaymentStatus.TabIndex = 41;
            // 
            // cboReservationStatus
            // 
            cboReservationStatus.Font = new Font("Segoe UI", 9.75F);
            cboReservationStatus.FormattingEnabled = true;
            cboReservationStatus.Items.AddRange(new object[] { "Pending", "Confirmed", "Cancelled" });
            cboReservationStatus.Location = new Point(273, 399);
            cboReservationStatus.Name = "cboReservationStatus";
            cboReservationStatus.Size = new Size(222, 25);
            cboReservationStatus.TabIndex = 42;
            // 
            // txtNotes
            // 
            txtNotes.Font = new Font("Segoe UI", 9.75F);
            txtNotes.Location = new Point(623, 37);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(312, 321);
            txtNotes.TabIndex = 43;
            // 
            // ReservationDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1070, 533);
            Controls.Add(sidebar);
            Controls.Add(txtNotes);
            Controls.Add(cboReservationStatus);
            Controls.Add(cboPaymentStatus);
            Controls.Add(txtTotalAmount);
            Controls.Add(cboRoomType);
            Controls.Add(nudNumKids);
            Controls.Add(nudNumAdults);
            Controls.Add(btnCancelEdit);
            Controls.Add(btnSaveReservation);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(a);
            Controls.Add(dtpCheckOutDate);
            Controls.Add(dtpCheckInDate);
            Controls.Add(txtCustomerName);
            Controls.Add(txtReservationID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblTotalReservationsCount);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReservationDetailsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form5";
            Load += ReservationDetailsForm_Load;
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
            ((System.ComponentModel.ISupportInitialize)nudNumAdults).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNumKids).EndInit();
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
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lblTotalReservationsCount;
        private TextBox txtReservationID;
        private TextBox txtCustomerName;
        private DateTimePicker dtpCheckInDate;
        private DateTimePicker dtpCheckOutDate;
        private Label a;
        private Label label6;
        private Label label5;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button btnSaveReservation;
        private Button btnCancelEdit;
        private NumericUpDown nudNumAdults;
        private NumericUpDown nudNumKids;
        private ComboBox cboRoomType;
        private TextBox txtTotalAmount;
        private ComboBox cboPaymentStatus;
        private ComboBox cboReservationStatus;
        private TextBox txtNotes;
    }
}