namespace GM_Dumago_Private_Resort_Admin_Desktop_Application
{
    partial class ChatForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatForm));
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
            lblChattingWith = new Label();
            lblTotalReservationsCount = new Label();
            tice = new Label();
            label2 = new Label();
            lstConversations = new ListBox();
            txtChatHistory = new TextBox();
            txtAdminReply = new TextBox();
            btnSend = new Button();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            // lblChattingWith
            // 
            lblChattingWith.AutoSize = true;
            lblChattingWith.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChattingWith.Location = new Point(485, 51);
            lblChattingWith.Name = "lblChattingWith";
            lblChattingWith.Size = new Size(87, 20);
            lblChattingWith.TabIndex = 50;
            lblChattingWith.Text = "User Name";
            // 
            // lblTotalReservationsCount
            // 
            lblTotalReservationsCount.AutoSize = true;
            lblTotalReservationsCount.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalReservationsCount.Location = new Point(191, 121);
            lblTotalReservationsCount.Name = "lblTotalReservationsCount";
            lblTotalReservationsCount.Size = new Size(0, 20);
            lblTotalReservationsCount.TabIndex = 49;
            // 
            // tice
            // 
            tice.AutoSize = true;
            tice.Font = new Font("Palatino Linotype", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tice.Location = new Point(101, 17);
            tice.Name = "tice";
            tice.Size = new Size(0, 32);
            tice.TabIndex = 71;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(133, 61);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 72;
            // 
            // lstConversations
            // 
            lstConversations.BackColor = SystemColors.Control;
            lstConversations.BorderStyle = BorderStyle.None;
            lstConversations.Font = new Font("Segoe UI", 11.25F);
            lstConversations.FormattingEnabled = true;
            lstConversations.ItemHeight = 20;
            lstConversations.Items.AddRange(new object[] { "  John Doe (New)", "  Jane Smith", "  Bob Johnson" });
            lstConversations.Location = new Point(117, 106);
            lstConversations.Name = "lstConversations";
            lstConversations.Size = new Size(227, 400);
            lstConversations.TabIndex = 73;
            lstConversations.SelectedIndexChanged += lstConversations_SelectedIndexChanged;
            // 
            // txtChatHistory
            // 
            txtChatHistory.BackColor = Color.FromArgb(224, 224, 224);
            txtChatHistory.BorderStyle = BorderStyle.FixedSingle;
            txtChatHistory.Font = new Font("Segoe UI", 11.25F);
            txtChatHistory.Location = new Point(371, 98);
            txtChatHistory.Multiline = true;
            txtChatHistory.Name = "txtChatHistory";
            txtChatHistory.Size = new Size(685, 410);
            txtChatHistory.TabIndex = 74;
            txtChatHistory.TextChanged += txtChatHistory_TextChanged;
            // 
            // txtAdminReply
            // 
            txtAdminReply.BackColor = SystemColors.Control;
            txtAdminReply.BorderStyle = BorderStyle.FixedSingle;
            txtAdminReply.Font = new Font("Segoe UI", 11.25F);
            txtAdminReply.Location = new Point(392, 459);
            txtAdminReply.Multiline = true;
            txtAdminReply.Name = "txtAdminReply";
            txtAdminReply.Size = new Size(601, 34);
            txtAdminReply.TabIndex = 75;
            txtAdminReply.TextChanged += txtAdminReply_TextChanged;
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.FromArgb(35, 40, 45);
            btnSend.FlatAppearance.BorderSize = 0;
            btnSend.FlatStyle = FlatStyle.Popup;
            btnSend.Font = new Font("Arial", 9.75F);
            btnSend.ForeColor = Color.White;
            btnSend.Image = (Image)resources.GetObject("btnSend.Image");
            btnSend.Location = new Point(1002, 459);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(35, 34);
            btnSend.TabIndex = 85;
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(117, 44);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(242, 37);
            textBox1.TabIndex = 86;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(127, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 87;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(409, 34);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(61, 55);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 88;
            pictureBox2.TabStop = false;
            // 
            // ChatForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1070, 533);
            Controls.Add(sidebar);
            Controls.Add(txtAdminReply);
            Controls.Add(btnSend);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(txtChatHistory);
            Controls.Add(lstConversations);
            Controls.Add(label2);
            Controls.Add(tice);
            Controls.Add(lblChattingWith);
            Controls.Add(lblTotalReservationsCount);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChatForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form12";
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private Label lblChattingWith;
        private Label lblTotalReservationsCount;
        private Label tice;
        private Label label2;
        private ListBox lstConversations;
        private TextBox txtChatHistory;
        private TextBox txtAdminReply;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        public Button btnSend;
    }
}