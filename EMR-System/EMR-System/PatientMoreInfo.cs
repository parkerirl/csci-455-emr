﻿using System;
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
    }
}