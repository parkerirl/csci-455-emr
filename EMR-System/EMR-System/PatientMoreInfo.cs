using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EMR_System
{
    public partial class PatientMoreInfo : Form
    {
        private List<string>[] AllergyList;
        private List<string> AllergyAllergy;
        private List<string> AllergyDoD;

        private List<string> AllergyCBAllergy = new List<string>();
        private List<string> AllergyCBDoD = new List<string>();

        private List<string>[] PatientMedicalHistoryList;
        private List<string> PMH_Item;
        private List<string> PMH_Hospitalized;
        private List<string> PMH_Surgery;
        private List<string> PMH_Date;

        private List<string> PMHCB_Item = new List<string>();
        private List<string> PMHCB_Hospitalized = new List<string>();
        private List<string> PMHCB_Surgery = new List<string>();
        private List<string> PMHCB_Date = new List<string>();

        private List<string>[] FamilyMedicalHistoryList;
        private List<string> FMH_Relationship;
        private List<string> FMH_Condition;
        private List<string> FMH_Age;

        private List<string> FMHCB_Relationship = new List<string>();
        private List<string> FMHCB_Condition = new List<string>();
        private List<string> FMHCB_Age = new List<string>();

        private String[] PatientInfo;

        public PatientMoreInfo(String[] Patient, Boolean isPatient)
        {
            InitializeComponent();

            if (isPatient == false)
            {
                button1.Visible = true; button1.BringToFront();
                button2.Visible = true; button2.BringToFront();
                button3.Visible = true; button3.BringToFront();
                button4.Visible = true; button4.BringToFront();
                button5.Visible = true; button5.BringToFront();
                button6.Visible = true; button6.BringToFront();
            } 
            else
            {
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
            }

            PatientInfo = Patient;
            textSetFirstName.Text = $"{Patient[0]}";
            textSetLastName.Text = $"{Patient[1]}";
            textSetSSN.Text = $"{Patient[2]}";
            textSetAddress.Text = $"{Patient[3]}";
            textSetPhone.Text = $"{Patient[4]}";
            textSetEmail.Text = $"{Patient[5]}";
            textSetSex.Text = $"{Patient[6]}";
            textSetBirthday.Text = $"{Patient[7]}";
            textSetBloodType.Text = $"{Patient[8]}";
            textSetPrimaryPhysician.Text = $"{Patient[9]}";
            textSetInsuranceProvider.Text = $"{Patient[10]}";
            textSetInsuranceNumber.Text = $"{Patient[11]}";

            loadData(Patient[2]);
        }

        private void loadData(String ssn)
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            dataGridView3.Rows.Clear();
            ConnectDB EMRDatabase = new ConnectDB();
            AllergyList = EMRDatabase.ViewAllAllergies(ssn);
            AllergyAllergy = AllergyList[0];
            AllergyDoD = AllergyList[1];

            for (int i = 0; i < AllergyAllergy.Count; i++)
            {
                dataGridView1.Rows.Add(AllergyAllergy[i], AllergyDoD[i]);
            }

            PatientMedicalHistoryList = EMRDatabase.ViewMedHistory(ssn);
            PMH_Item = PatientMedicalHistoryList[0];
            PMH_Hospitalized = PatientMedicalHistoryList[1];
            PMH_Surgery = PatientMedicalHistoryList[2];
            PMH_Date = PatientMedicalHistoryList[3];
            for (int i = 0; i < PMH_Item.Count; i++)
            {
                dataGridView2.Rows.Add(PMH_Item[i], PMH_Hospitalized[i], PMH_Surgery[i], PMH_Date[i]);
            }


            FamilyMedicalHistoryList = EMRDatabase.ViewFamilyMedHistory(ssn);
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



        //delete allergy
        private void button1_Click(object sender, EventArgs e)
        {
            ConnectDB EMRDatabase = new ConnectDB();
            for (int i = 0; i < AllergyCBAllergy.Count(); i++)
            {
                EMRDatabase.RemoveAllergies(PatientInfo[2], AllergyCBAllergy[i], AllergyCBDoD[i]);
            }

            List<DataGridViewRow> toDelete = new List<DataGridViewRow>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewCheckBoxCell cell = row.Cells[2] as DataGridViewCheckBoxCell;
                if ((bool)cell.EditedFormattedValue == true)
                {
                    toDelete.Add(row);
                }
            }
            foreach (DataGridViewRow row in toDelete)
            {
                dataGridView1.Rows.Remove(row);
            }
            dataGridView1.ClearSelection();
            button1.Enabled = false;
        }

        //delete patient history
        private void button2_Click(object sender, EventArgs e)
        {
            int hospitalized = 0;
            int surgery = 0;
            ConnectDB EMRDatabase = new ConnectDB();
            for (int i = 0; i < PMHCB_Item.Count(); i++)
            {
                if(PMHCB_Hospitalized[i] == "Yes")
                {
                    hospitalized = 1;
                }
                else
                {
                    hospitalized = 0;
                }
                if (PMHCB_Surgery[i] == "Yes")
                {
                    surgery = 1;
                }
                else
                {
                    surgery = 0;
                }
                EMRDatabase.RemoveMedHistory(PatientInfo[2], PMHCB_Item[i], hospitalized, surgery, PMHCB_Date[i]);
            }

            List<DataGridViewRow> toDelete = new List<DataGridViewRow>();
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                DataGridViewCheckBoxCell cell = row.Cells[4] as DataGridViewCheckBoxCell;
                if ((bool)cell.EditedFormattedValue == true)
                {
                    toDelete.Add(row);
                }
            }
            foreach (DataGridViewRow row in toDelete)
            {
                dataGridView2.Rows.Remove(row);
            }
            dataGridView2.ClearSelection();
            button2.Enabled = false;
        }

        //delete family history
        private void button3_Click(object sender, EventArgs e)
        {
            ConnectDB EMRDatabase = new ConnectDB();
            for (int i = 0; i < FMHCB_Relationship.Count(); i++)
            {
                EMRDatabase.RemoveFamilyMedHistory(PatientInfo[2], FMHCB_Relationship[i], FMHCB_Condition[i], FMHCB_Age[i]);
            }

            List<DataGridViewRow> toDelete = new List<DataGridViewRow>();
            foreach (DataGridViewRow row in dataGridView3.Rows)
            {
                DataGridViewCheckBoxCell cell = row.Cells[3] as DataGridViewCheckBoxCell;
                if ((bool)cell.EditedFormattedValue == true)
                {
                    toDelete.Add(row);
                }
            }
            foreach (DataGridViewRow row in toDelete)
            {
                dataGridView3.Rows.Remove(row);
            }
            dataGridView3.ClearSelection();
            button3.Enabled = false;
        }

        //allergy checkbox
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 2)
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[0].Value != null) AllergyCBAllergy.Add(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                if (dataGridView1.Rows[e.RowIndex].Cells[1].Value != null) AllergyCBDoD.Add(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                if (button1.Enabled == false)
                {
                    button1.Enabled = true;
                }
            }
        }

        //patient history checkbox
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 4)
            {
                if (dataGridView2.Rows[e.RowIndex].Cells[0].Value != null) PMHCB_Item.Add(dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString());
                if (dataGridView2.Rows[e.RowIndex].Cells[1].Value != null)  PMHCB_Hospitalized.Add(dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString());
                if (dataGridView2.Rows[e.RowIndex].Cells[2].Value != null)  PMHCB_Surgery.Add(dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString());
                if (dataGridView2.Rows[e.RowIndex].Cells[3].Value != null)  PMHCB_Date.Add(dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString());
                if(button2.Enabled == false)
                {
                    button2.Enabled = true;
                }
            }
        }

        //family history checkbox
        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 3)
            {
                if (dataGridView3.Rows[e.RowIndex].Cells[0].Value != null) FMHCB_Relationship.Add(dataGridView3.Rows[e.RowIndex].Cells[0].Value.ToString());
                if (dataGridView3.Rows[e.RowIndex].Cells[1].Value != null) FMHCB_Condition.Add(dataGridView3.Rows[e.RowIndex].Cells[1].Value.ToString());
                if (dataGridView3.Rows[e.RowIndex].Cells[2].Value != null) FMHCB_Age.Add(dataGridView3.Rows[e.RowIndex].Cells[2].Value.ToString());
                if(button3.Enabled == false)
                {
                    button3.Enabled = true;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            allergy.Show();
        }

        private void cancelAllergy_Click(object sender, EventArgs e)
        {
            panel1.Show();
            allergy.Hide();
            allergyText.Text = null;
            allergyDate.Value = DateTime.Now;
        }

        private void saveAllergyBtn_Click(object sender, EventArgs e)
        {
            ConnectDB EMRDatabase = new ConnectDB();
            EMRDatabase.AddAllergies(textSetSSN.Text, allergyText.Text, allergyDate.Value.ToString("yyyy-MM-dd"));
            loadData(textSetSSN.Text);
            panel1.Show();
            allergy.Hide();
        }

        private void allergyText_TextChanged(object sender, EventArgs e)
        {
            if(allergyText.Text == null || allergyText.Text == "")
            {
                saveAllergyBtn.Enabled = false;
            }
            else
            {
                saveAllergyBtn.Enabled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (injury.Text == null || injury.Text == "")
            {
                patHistSave.Enabled = false;
            }
            else
            {
                patHistSave.Enabled = true;
            }
        }

        private void patHistCancel_Click(object sender, EventArgs e)
        {
            panel1.Show();
            patientHistory.Hide();
            injury.Text = null;
            datePatHist.Value = DateTime.Now;
            comboHospitalized.SelectedItem = null;
            comboSurgery.SelectedItem = null;
        }

        private void patHistSave_Click(object sender, EventArgs e)
        {
            bool hospitalized = false;
            bool surgery = false;

            if(comboHospitalized.SelectedItem.ToString() == "Yes")
            {
                hospitalized = true;
            }

            if (comboSurgery.SelectedItem.ToString() == "Yes")
            {
                surgery = true;
            }

            ConnectDB EMRDatabase = new ConnectDB();
            EMRDatabase.AddMedHistory(textSetSSN.Text, injury.Text, hospitalized, surgery, datePatHist.Value.ToString("yyyy-MM-dd"));
            loadData(textSetSSN.Text);
            panel1.Show();
            patientHistory.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            comboHospitalized.SelectedItem = "No";
            comboSurgery.SelectedItem = "No";
            panel1.Hide();
            patientHistory.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ConnectDB EMRDatabase = new ConnectDB();
            EMRDatabase.AddFamilyMedHistory(textSetSSN.Text, textRelaionship.Text, textDisease.Text, textAge.Text);
            loadData(textSetSSN.Text);
            panel1.Show();
            famHist.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel1.Show();
            famHist.Hide();
            textRelaionship.Text = null;
            textAge.Text = null;
            textDisease.Text = null;
        }

        private void showFamHist_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            famHist.Show();
        }
    }

}

