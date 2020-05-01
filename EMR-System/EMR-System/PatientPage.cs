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
    public partial class PatientPage : Form
    {
        public PatientPage()
        {
            InitializeComponent();
        }

        private void PatientPage_Load(object sender, EventArgs e)
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
    }
}
