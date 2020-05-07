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
    public partial class AddPrescription : Form
    {
        public AddPrescription()
        {
            InitializeComponent();
        }

        private void AddPrescription_Load(object sender, EventArgs e)
        {

        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            string name = textSetPrescriptionName.Text;
            string dosage = textDosage.Text;
            string expiration = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            if (name.Trim().Equals("") || dosage.Trim().Equals("") || expiration.Trim().Equals(""))
            {
                labelErrorText.Visible = true;
            } else
            {

                ConnectDB EMRDatabase = new ConnectDB();
                EMRDatabase.AddPrescription(SearchPatientPage.passed_SSN, dosage, name, expiration);

                this.Close();
            }

            
        }

        private void onClicked(object sender, EventArgs e)
        {
            labelErrorText.Visible = false;
        }
    }
}
