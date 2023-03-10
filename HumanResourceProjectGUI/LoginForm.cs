using HumanResourceDataProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumanResourceProjectGUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.AcceptButton = loginButton;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.Owner.Hide();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Home.MASTER_DATA.AllHumanResources.Add(new Employee("Juan dela Cruz", "juan", "1234", DateTime.Now));
            if(Home.MASTER_DATA.Administrator.Account.LogIn(usernameTB.Text, passwordTB.Text))
            {
                Home.ACCOUNT_LOGGED_IN = Home.MASTER_DATA.Administrator.Account;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                foreach(HumanResource hr in Home.MASTER_DATA.AllHumanResources)
                {
                    if(hr.Account.LogIn(usernameTB.Text,passwordTB.Text))
                    {
                        Home.ACCOUNT_LOGGED_IN = hr.Account;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                        break;
                    }
                }
            }

            if(this.DialogResult != DialogResult.OK)
            {
                DialogResult res = MessageBox.Show("You have entered an invalid username-password combination.", "Login Error", MessageBoxButtons.RetryCancel);
                if(res == DialogResult.Cancel)
                {
                    this.Close();
                }
            }
        }
    }
}
