using HumanResourceDataProject;

namespace HumanResourceProjectGUI
{
    public partial class Home : Form
    {
        public static LoginForm LOGIN_FORM = new();
        public static AdministratorHomeForm ADMIN_FORM = new();
        public static Account? ACCOUNT_LOGGED_IN;
        public static HumanResourceData MASTER_DATA = new();

        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            this.ChangingForms();
        }

        private void ChangingForms()
        {
            do
            {
                try
                {
                    if (Home.LOGIN_FORM.ShowDialog(this) == DialogResult.OK)
                    {
                        if (Home.MASTER_DATA.Administrator.Account.Equals(Home.ACCOUNT_LOGGED_IN))
                        {
                            Home.ADMIN_FORM.ShowDialog(this);
                        }
                        else if (Home.ACCOUNT_LOGGED_IN != null)
                        {
                            MessageBox.Show("You have logged in as EMPLOYEE.");
                        }
                    }
                    else
                        this.Close();
                }
                catch(Exception ex)
                {
                    break;
                }
            } while (true);
        }
    }
}