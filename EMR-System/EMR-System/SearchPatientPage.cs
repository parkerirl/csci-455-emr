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
    public partial class SearchPatientPage : Form
    {
        private String SSN;
        private String FirstName;

        private List<string> Fname;
        private List<string> Lname;
        private List<string> Birthday;
        private List<string> InsProvider;
        private List<string> Address;
        private List<string> Email;
        private List<string> Phone;
        private List<string> Sex;
        private List<string> PrimaryPhysician;
        private List<string> BloodType;
        private List<string> InsNumber;
        private List<string> Ssn;

        private List<string>[] Patients;
        private String[] PatientsMoreInfo = new string[12];

        public SearchPatientPage()
        {
            InitializeComponent();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            if (LoginPage.userType.Equals("admin"))
            {
                MainPage_Admin main = new MainPage_Admin();
                main.Show();
                this.Close();
            }
        }

        //Search for patient info (for now only based on SSN) AND only works with (retrieves) ONE patient
        private void Button1_Click(object sender, EventArgs e)
        {
            textSetFirstName.Text = "";
            textSetLastName.Text = "";
            textSetSSN.Text = "";
            textSetAddress.Text = "";
            textSetPhoneNumber.Text = "";

            ConnectDB EMRDatabase = new ConnectDB();

            dataGridView1.Rows.Clear();

            if (!textPatientNameSearch.Text.Equals("")) //if searching by name
            {
                Patients = EMRDatabase.SelectByName(FirstName); //retrieve list by First Name
            }

            else
            {
                Patients = EMRDatabase.Select(SSN);  //retrieve list by SSN
            }


            Fname = Patients[0];
            Lname = Patients[1];
            Birthday = Patients[2];
            InsProvider = Patients[3];
            Address = Patients[4];
            Email = Patients[5];
            Phone = Patients[6];
            Sex = Patients[7];
            PrimaryPhysician = Patients[8];
            BloodType = Patients[9];
            InsNumber = Patients[10];
            Ssn = Patients[11];

            for (int i = 0; i < Ssn.Count; i++)
            {
                dataGridView1.Rows.Add(Fname[i], Birthday[i], InsNumber[i]);
            }
        }

        private void SearchPatientPage_Load(object sender, EventArgs e)
        {

        }

        //Patient SSN to search
        private void textPatientIdSearch_TextChanged(object sender, EventArgs e)
        {
            SSN = textPatientIdSearch.Text;
        }

        //View expanded patient info on new page
        private void buttonMoreInfo_Click(object sender, EventArgs e)
        {
            if (PatientsMoreInfo != null)
            {
                PatientMoreInfo moreInfo = new PatientMoreInfo(PatientsMoreInfo);
                moreInfo.Show();
            }
        }

        private void textPatientNameSearch_TextChanged(object sender, EventArgs e)
        {
            FirstName = textPatientNameSearch.Text;
        }
        void grd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 3)
            {
                //populate boxes on page
                textSetFirstName.Text = Fname[e.RowIndex];
                textSetLastName.Text = Lname[e.RowIndex];
                textSetSSN.Text = Ssn[e.RowIndex];
                textSetAddress.Text = Address[e.RowIndex];
                textSetPhoneNumber.Text = Phone[e.RowIndex];

                //populate list to display more info
                PatientsMoreInfo[0] = Fname[e.RowIndex];
                PatientsMoreInfo[1] = Lname[e.RowIndex];
                PatientsMoreInfo[2] = Ssn[e.RowIndex];
                PatientsMoreInfo[3] = Address[e.RowIndex];
                PatientsMoreInfo[4] = Phone[e.RowIndex];
                PatientsMoreInfo[5] = Email[e.RowIndex];
                PatientsMoreInfo[6] = Sex[e.RowIndex];
                PatientsMoreInfo[7] = Birthday[e.RowIndex];
                PatientsMoreInfo[8] = BloodType[e.RowIndex];
                PatientsMoreInfo[9] = PrimaryPhysician[e.RowIndex];
                PatientsMoreInfo[10] = InsProvider[e.RowIndex];
                PatientsMoreInfo[11] = InsNumber[e.RowIndex];
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            ConnectDB EMRDatabase = new ConnectDB();

            EMRDatabase.Delete(SSN); 

        }
    }
}
