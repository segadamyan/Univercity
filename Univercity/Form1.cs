namespace Univercity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void takeTest_Click(object sender, EventArgs e)
        {
            test testing = new test();
            testing.ShowDialog();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
        }
    }
}