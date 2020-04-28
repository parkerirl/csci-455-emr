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
    public partial class PatientMoreInfo : Form
    {
        private List<string>[] AllergyList;
        private List<string> AllergyAllergy;
        private List<string> AllergyDoD;

        private List<string>[] PatientMedicalHistoryList;
        private List<string> PMH_Item;
        private List<string> PMH_Hospitalized;
        private List<string> PMH_Surgery;
        private List<string> PMH_Date;

        private List<string>[] FamilyMedicalHistoryList;
        private List<string> FMH_Relationship;
        private List<string> FMH_Condition;
        private List<string> FMH_Age;

        public PatientMoreInfo(String[] Patient)
        {
            InitializeComponent();
            textSetFirstName.Text           = $"{Patient[0]}";
            textSetLastName.Text            = $"{Patient[1]}";
            textSetSSN.Text                 = $"{Patient[2]}";
            textSetAddress.Text             = $"{Patient[3]}";
            textSetPhone.Text               = $"{Patient[4]}";
            textSetEmail.Text               = $"{Patient[5]}";
            textSetSex.Text                 = $"{Patient[6]}";
            textSetBirthday.Text            = $"{Patient[7]}";
            textSetBloodType.Text           = $"{Patient[8]}";
            textSetPrimaryPhysician.Text    = $"{Patient[9]}";
            textSetInsuranceProvider.Text   = $"{Patient[10]}";
            textSetInsuranceNumber.Text     = $"{Patient[11]}";
            ConnectDB EMRDatabase = new ConnectDB();
            AllergyList = EMRDatabase.ViewAllAllergies(Patient[2]);
            AllergyAllergy = AllergyList[0];
            AllergyDoD = AllergyList[1];

            for (int i = 0; i < AllergyAllergy.Count; i++)
            {
                dataGridView1.Rows.Add(AllergyAllergy[i], AllergyDoD[i]);
            }

            PatientMedicalHistoryList = EMRDatabase.ViewMedHistory(Patient[2]);
            PMH_Item = PatientMedicalHistoryList[0];
            PMH_Hospitalized = PatientMedicalHistoryList[1];
            PMH_Surgery = PatientMedicalHistoryList[2];
            PMH_Date = PatientMedicalHistoryList[3];
            for (int i = 0; i < PMH_Item.Count; i++)
            {
                dataGridView2.Rows.Add(PMH_Item[i], PMH_Hospitalized[i], PMH_Surgery[i], PMH_Date[i]);
            }


            FamilyMedicalHistoryList = EMRDatabase.ViewFamilyMedHistory(Patient[2]);
            FMH_Relationship = FamilyMedicalHistoryList[0];
            FMH_Condition = FamilyMedicalHistoryList[1];
            FMH_Age = FamilyMedicalHistoryList[2];
            for (int i = 0; i < FMH_Relationship.Count; i++)
            {
                dataGridView3.Rows.Add(FMH_Relationship[i], FMH_Condition[i], FMH_Age[i]);
            }

        }

        //go back to previous menu
        private void buttonMoreInfo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelAddress_Click(object sender, EventArgs e)
        {

        }

        private void textSetFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
