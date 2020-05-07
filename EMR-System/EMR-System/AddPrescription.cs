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
            string frequency = comboFrequency.Text;
            string renew = comboRenew.Text;

            if (name.Trim().Equals("") || dosage.Trim().Equals("") || frequency.Trim().Equals("") || renew.Trim().Equals(""))
            {
                labelErrorText.Visible = true;
            } else
            {
                this.Close();
            }

            
        }

        private void onClicked(object sender, EventArgs e)
        {
            labelErrorText.Visible = false;
        }
    }
}
