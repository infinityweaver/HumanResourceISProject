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
    public partial class AdministratorHomeForm : Form
    {
        public AdministratorHomeForm()
        {
            InitializeComponent();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home.ACCOUNT_LOGGED_IN = null;
            this.Close();
        }

        private void AdministratorHomeForm_Load(object sender, EventArgs e)
        {
            this.Owner.Hide();
            this.AllHumanResourceView.DataSource = Home.MASTER_DATA.AllHumanResources;
        }

        private void AdministratorHomeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Home.ACCOUNT_LOGGED_IN = null;
        }
    }
}
