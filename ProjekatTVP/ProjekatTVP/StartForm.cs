namespace ProjekatTVP
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm(this);
            this.Hide();
            registrationForm.ShowDialog();
            this.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(this);
            this.Hide();
            loginForm.ShowDialog();
            this.Show();
        }

        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}