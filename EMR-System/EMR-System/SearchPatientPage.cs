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
            textSetFirstName.Text   = "";
            textSetLastName.Text    = "";
            textSetSSN.Text         = "";
            textSetAddress.Text     = "";
            textSetPhoneNumber.Text = "";

            ConnectDB EMRDatabase = new ConnectDB();
            List<string>[] Patients;
            dataGridView1.Rows.Clear();

            if (!textPatientNameSearch.Text.Equals("")) //if searching by name
            {
                Patients = EMRDatabase.SelectByName(FirstName); //retrieve list by First Name
            }

            else
            {
                Patients = EMRDatabase.Select(SSN);  //retrieve list by SSN
            }


            Fname            = Patients[0];
            Lname            = Patients[1];
            Birthday         = Patients[2];
            InsProvider      = Patients[3];
            Address          = Patients[4];
            Email            = Patients[5];
            Phone            = Patients[6];
            Sex              = Patients[7];
            PrimaryPhysician = Patients[8];
            BloodType        = Patients[9];
            InsNumber        = Patients[10];
            Ssn              = Patients[11];

            for (int i = 0; i < Ssn.Count; i++)
            {
                dataGridView1.Rows.Add(Fname[i], Birthday[i].Split(' ')[0], InsNumber[i]);
            }

            /*debug
            if (textPatientNameSearch.Text.Equals("Drew"))
            {
                text1a.Text = "Pesall, Drew";
                text1b.Text = "03/29/1998";
                text1c.Text = "Health Partners";

                text2a.Text = "Smith, Andrew";
                text2b.Text = "11/20/1994";
                text2c.Text = "Anthem";
            }
            */
        }

        private void SearchPatientPage_Load(object sender, EventArgs e)
        {

        }

        //Patient SSN to search
        private void textPatientIdSearch_TextChanged(object sender, EventArgs e)
        {
            SSN = textPatientIdSearch.Text;
        }

        private void buttonMoreInfo_Click(object sender, EventArgs e)
        {

        }

        private void textPatientNameSearch_TextChanged(object sender, EventArgs e)
        {
            FirstName = textPatientNameSearch.Text;
        }
        void grd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 3)
            {
                textSetFirstName.Text = Fname[e.RowIndex];
                textSetLastName.Text = Lname[e.RowIndex];
                textSetSSN.Text = Ssn[e.RowIndex];
                textSetAddress.Text = Address[e.RowIndex];
                textSetPhoneNumber.Text = Phone[e.RowIndex];
            }
        }
    }
}
