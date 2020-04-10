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

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textPatientNameSearch.Text.Equals("Drew"))
            {
                text1a.Text = "Pesall, Drew";
                text1b.Text = "03/29/1998";
                text1c.Text = "Health Partners";

                text2a.Text = "Smith, Andrew";
                text2b.Text = "11/20/1994";
                text2c.Text = "Anthem";
            }
            
            buttonRow1.Enabled = (text1a.Text.Length > 1) ? true : false;
            buttonRow2.Enabled = (text2a.Text.Length > 1) ? true : false;
            buttonRow3.Enabled = (text3a.Text.Length > 1) ? true : false;
            buttonRow4.Enabled = (text4a.Text.Length > 1) ? true : false;
            buttonRow5.Enabled = (text5a.Text.Length > 1) ? true : false;
            buttonRow6.Enabled = (text6a.Text.Length > 1) ? true : false;
            buttonRow7.Enabled = (text7a.Text.Length > 1) ? true : false;

            if (text1a.Text.Length > 1)
            {
                buttonRow1.Enabled = true;
            }
        }

        private void setRowColors(int rowNumber)
        {
            text1a.BackColor = SystemColors.Control; text1b.BackColor = SystemColors.Control; text1c.BackColor = SystemColors.Control;
            text2a.BackColor = SystemColors.Control; text2b.BackColor = SystemColors.Control; text2c.BackColor = SystemColors.Control;
            text3a.BackColor = SystemColors.Control; text3b.BackColor = SystemColors.Control; text3c.BackColor = SystemColors.Control;
            text4a.BackColor = SystemColors.Control; text4b.BackColor = SystemColors.Control; text4c.BackColor = SystemColors.Control;
            text5a.BackColor = SystemColors.Control; text5b.BackColor = SystemColors.Control; text5c.BackColor = SystemColors.Control;
            text6a.BackColor = SystemColors.Control; text6b.BackColor = SystemColors.Control; text6c.BackColor = SystemColors.Control;
            text7a.BackColor = SystemColors.Control; text7b.BackColor = SystemColors.Control; text7c.BackColor = SystemColors.Control;

            switch (rowNumber)
            {
                case 1:
                    text1a.BackColor = Color.Yellow; text1b.BackColor = Color.Yellow; text1c.BackColor = Color.Yellow;
                    break;
                case 2:
                    text2a.BackColor = Color.Yellow; text2b.BackColor = Color.Yellow; text2c.BackColor = Color.Yellow;
                    break;
                case 3:
                    text3a.BackColor = Color.Yellow; text3b.BackColor = Color.Yellow; text3c.BackColor = Color.Yellow;
                    break;
                case 4:
                    text4a.BackColor = Color.Yellow; text4b.BackColor = Color.Yellow; text4c.BackColor = Color.Yellow;
                    break;
                case 5:
                    text5a.BackColor = Color.Yellow; text5b.BackColor = Color.Yellow; text5c.BackColor = Color.Yellow;
                    break;
                case 6:
                    text6a.BackColor = Color.Yellow; text6b.BackColor = Color.Yellow; text6c.BackColor = Color.Yellow;
                    break;
                case 7:
                    text7a.BackColor = Color.Yellow; text7b.BackColor = Color.Yellow; text7c.BackColor = Color.Yellow;
                    break;

            }
        }

        private void SearchPatientPage_Load(object sender, EventArgs e)
        {

        }

        private void ButtonRow1_Click(object sender, EventArgs e)
        {
            setRowColors(1);
        }

        private void ButtonRow2_Click(object sender, EventArgs e)
        {
            setRowColors(2);

            textSetFirstName.Text = "Andrew";
            textSetLastName.Text = "Smith";
            textSetSSN.Text = "*** - ** - 8456";
            textSetAddress.Text = "476 N 32nd";
            textSetPhoneNumber.Text = "612-546-0008";
        }

        private void ButtonRow3_Click(object sender, EventArgs e)
        {
            setRowColors(3);
        }

        private void ButtonRow4_Click(object sender, EventArgs e)
        {
            setRowColors(4);
        }

        private void ButtonRow5_Click(object sender, EventArgs e)
        {
            setRowColors(5);
        }

        private void ButtonRow6_Click(object sender, EventArgs e)
        {
            setRowColors(6);
        }

        private void ButtonRow7_Click(object sender, EventArgs e)
        {
            setRowColors(7);
        }
    }
}
