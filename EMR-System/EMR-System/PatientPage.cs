using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EMR_System
{
    public partial class PatientPage : Form
    {
        private String[] PatientsMoreInfo = new string[12];
        private List<string>[] Patients;
        private String SSN;

        public PatientPage(String ssnFromLogin)
        {
            InitializeComponent();
            ConnectDB EMRDatabase = new ConnectDB();
            SSN = ssnFromLogin;
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

        private void buttonPatientSearch_Click(object sender, EventArgs e)
        {
            ConnectDB EMRDatabase = new ConnectDB();
            Patients = EMRDatabase.Select(SSN);  //retrieve by SSN

            PatientsMoreInfo[0] = Patients[0][0];
            PatientsMoreInfo[1] = Patients[1][0];
            PatientsMoreInfo[2] = Patients[11][0];
            PatientsMoreInfo[3] = Patients[4][0];
            PatientsMoreInfo[4] = Patients[6][0];
            PatientsMoreInfo[5] = Patients[5][0];
            PatientsMoreInfo[6] = Patients[7][0];
            PatientsMoreInfo[7] = Patients[2][0];
            PatientsMoreInfo[8] = Patients[9][0];
            PatientsMoreInfo[9] = Patients[8][0];
            PatientsMoreInfo[10] = Patients[3][0];
            PatientsMoreInfo[11] = Patients[10][0];
            PatientMoreInfo moreInfo = new PatientMoreInfo(PatientsMoreInfo, true);
            moreInfo.Show();
        }
    }
}
