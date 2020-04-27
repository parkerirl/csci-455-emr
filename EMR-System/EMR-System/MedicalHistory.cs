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
    public partial class MedicalHistory : Form
    {
        private String PatientHistory;
        private String FamilyHistory;
        private String PatientSSN;
        private String Date;
        private bool Hospitalized; 
        private bool Surgery;
        private String FamilyRelationship;
        private String FamilyAge;

        public MedicalHistory(String ssn)
        {
            InitializeComponent();
            PatientSSN = ssn;
            label3.Text = PatientSSN;
        }

        //Go back to previous menu
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelFirstName_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        //Patient Medical History
        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            PatientHistory = richTextBox2.Text;
        }

        //Patient's family medical history
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            FamilyHistory = richTextBox1.Text;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Hospitalized YES
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                radioButton2.Checked = false;
                Hospitalized = true;
            }
            Console.WriteLine($"HOSPITALIZED? {Hospitalized}");
        }

        //Hospitalized NO
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                radioButton1.Checked = false;
                Hospitalized = false;
            }
            Console.WriteLine($"HOSPITALIZED? {Hospitalized}");
        }

        //Surgery YES
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                radioButton4.Checked = false;
                Surgery = true;
            }
            Console.WriteLine($"SURGERY? {Surgery}");
        }

        //Surgery NO
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                radioButton3.Checked = false;
                Surgery = false;
            }
            Console.WriteLine($"SURGERY? {Surgery}");
        }

        //relationship box
        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {
            FamilyRelationship = richTextBox3.Text;
        }

        //age box
        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {
            FamilyAge = richTextBox4.Text;
        }

        //Add patient history item
        private void button1_Click(object sender, EventArgs e)
        {
            ConnectDB EMRDatabase = new ConnectDB();
            EMRDatabase.AddMedHistory(PatientSSN, PatientHistory, Hospitalized, Surgery, Date);
        }

        //Add Family history item
        private void button2_Click(object sender, EventArgs e)
        {
            ConnectDB EMRDatabase = new ConnectDB();
            EMRDatabase.AddFamilyMedHistory(PatientSSN, FamilyRelationship, FamilyHistory, FamilyAge);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
