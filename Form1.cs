namespace GM_Dumago_Private_Resort_Admin_Desktop_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            DashboardForm dashboard = new DashboardForm();
            dashboard.FormClosed += (s, args) => this.Close();
            dashboard.Show();
            this.Hide();
        }
    }
}
