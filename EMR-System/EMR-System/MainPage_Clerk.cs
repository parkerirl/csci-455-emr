using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMR_System
{
    public partial class MainPage_Clerk : Form
    {
        public MainPage_Clerk()
        {
            InitializeComponent();
        }

        private void MainPage_Clerk_Load(object sender, EventArgs e)
        {
            labelCurrentUserName.Text = LoginPage.userName;
            labelStatusType.Text = LoginPage.userType;
        }

        private void ButtonReportBug_Click(object sender, EventArgs e)
        {
            BugReport report = new BugReport();
            report.Show();
        }

        private void ButtonLogout_Click(object sender, EventArgs e)
        {
            LoginPage login = new LoginPage();
            login.Show();
            this.Close();
        }
    }
}
