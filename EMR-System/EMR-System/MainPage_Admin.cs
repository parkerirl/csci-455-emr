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
    public partial class MainPage_Admin : Form
    {

        public MainPage_Admin()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            labelCurrentUserName.Text = LoginPage.userName;
            labelStatusType.Text = LoginPage.userType;
        }

        private void ButtonLogout_Click(object sender, EventArgs e)
        {
            LoginPage login = new LoginPage();
            login.Show();
            this.Close();
        }

        private void ButtonReportBug_Click(object sender, EventArgs e)
        {
            BugReport report = new BugReport();
            report.Show();
        }

        private void ButtonPatientSearch_Click(object sender, EventArgs e)
        {
            SearchPatientPage search = new SearchPatientPage();
            search.Show();
            this.Close();
        }

        private void ButtonCreateRecord_Click(object sender, EventArgs e)
        {
            CreatePatientRecord cpr = new CreatePatientRecord();
            cpr.Show();
            this.Close();
        }

        private void ButtonAddUser_Click(object sender, EventArgs e)
        {
            ModifyUsersPage modify = new ModifyUsersPage();
            modify.Show();
            this.Close();
        }
    }
}
