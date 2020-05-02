using System;
using System.Windows.Forms;

namespace EMR_System
{
    public partial class CreatePatientRecord : Form
    {
        //Stored variables
        private String SSN;
        private String Fname;
        private String Lname;
        private String Address;
        private String Email;
        private String Phone;
        private String Sex;
        private String Birthday;
        private String BloodType;
        private String PrimaryPhysician;
        private String InsProvider;
        private String InsNum;
        private String Allergy;
        private String AllergyDate;

        public CreatePatientRecord()
        {
            InitializeComponent();
        }

        private void CreatePatientRecord_Load(object sender, EventArgs e)
        {

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

        //Submit filled-out form to change into MySQL query
        private void button1_Click(object sender, EventArgs e)
        {
            confirmationBox.Visible = true; confirmationBox.BringToFront();
            labelConfirm.Visible = true; labelConfirm.BringToFront();
            buttonCancel.Visible = true; buttonCancel.BringToFront();
            buttonSubmit.Visible = true; buttonSubmit.BringToFront();
            

        }

        //Get values from text boxes------------------------------------
        //First Name
        private void textSetFirstName_TextChanged(object sender, EventArgs e)
        {
            Fname = textSetFirstName.Text;
        }

        //Last Name
        private void textSetLastName_TextChanged(object sender, EventArgs e)
        {
            Lname = textSetLastName.Text;
        }

        //SSN
        private void textSetSSN_TextChanged(object sender, EventArgs e)
        {
            SSN = textSetSSN.Text;
            ConnectDB EMRDatabase = new ConnectDB();
            Boolean patientExists = EMRDatabase.PatientExists(SSN);
            if (patientExists == true) button1.Text = "Update Patient";
            else button1.Text = "Create Patient";
        }

        //Address
        private void textSetAddress_TextChanged(object sender, EventArgs e)
        {
            Address = textSetAddress.Text;
        }

        //Phone Number
        private void textSetPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            Phone = textSetPhoneNumber.Text;
        }

        //Insurance Provider
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            InsProvider = textBox5.Text;
        }

        //Insurance Number
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            InsNum = textBox6.Text;
        }

        //DoB
        private void birthday_ValueChanged(object sender, EventArgs e)
        {
            Birthday = dateTimePicker1.Value.ToString("yyyy-MM-dd");
        }

        //Primary Physician
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            PrimaryPhysician = textBox4.Text;
        }

        //Email
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Email = textBox3.Text;
        }

        //Blood Type
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            BloodType = textBox2.Text;
        }

        //If MALE is checked
        private void radioMale_CheckedChanged(object sender, EventArgs e)
        {
            Sex = "M";
        }

        //Or, if FEMALE is checked
        private void radioFemale_CheckedChanged(object sender, EventArgs e)
        {
            Sex = "F";
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            Allergy = richTextBox1.Text;
        }

        //allergy date of discovery
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            AllergyDate = dateTimePicker2.Value.ToString("yyyy-MM-dd");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConnectDB EMRDatabase = new ConnectDB();
            Boolean patientExists = EMRDatabase.PatientExists(SSN);
            //if the SSN is already in the DB
            //if (patientExists == true)
            //{
            //    EMRDatabase.AddAllergiesExisting(SSN, Allergy, AllergyDate);
            //    Console.WriteLine("Patient exists, adding allergy");
            //}
            //else
            //{
                EMRDatabase.AddAllergies(SSN, Allergy, AllergyDate);
            //}
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ConnectDB EMRDatabase = new ConnectDB();
            Boolean patientExists = EMRDatabase.PatientExists(SSN);
            //if the SSN is already in the DB
            if (patientExists == true)
            {
                MedicalHistory medHistory = new MedicalHistory(SSN);
                medHistory.Show();
            }
            else { }
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            ConnectDB EMRDatabase = new ConnectDB();
            Boolean patientExists = EMRDatabase.PatientExists(SSN);
            //if the SSN is already in the DB
            if (patientExists == true)
            {
                Console.WriteLine("patient already exists!");
                EMRDatabase.UpdatePatient(SSN, Fname, Lname, Address, Email, Phone, Sex, Birthday, BloodType, PrimaryPhysician, InsProvider, InsNum);
                EMRDatabase.AddAllergiesExisting(SSN, Allergy, AllergyDate);
            }
            else
            {
                Console.WriteLine("patient doesn't exist, adding to DB...");
                EMRDatabase.InsertPatient(SSN, Fname, Lname, Address, Email, Phone, Sex, Birthday, BloodType, PrimaryPhysician, InsProvider, InsNum);
                EMRDatabase.AddAllergies(SSN, Allergy, AllergyDate);
            }
            confirmationBox.Visible = false;
            labelConfirm.Visible = false;
            buttonCancel.Visible = false;
            buttonSubmit.Visible = false;
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            confirmationBox.Visible = false;
            labelConfirm.Visible = false;
            buttonCancel.Visible = false;
            buttonSubmit.Visible = false;
        }
    }
}
