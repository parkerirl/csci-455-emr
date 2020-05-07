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
    public partial class LoginPage : Form
    {
        public static string userType;
        public static string userName;
        private MainPage_Admin mainPageAdmin;
        private MainPage_Doctor mainPageDoctor;
        private MainPage_Clerk mainPageClerk;
        private PatientPage patientPage;

        public LoginPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            ConnectDB EMRDatabase = new ConnectDB();
            string id = textEmployeeId.Text;
            string password = textEmployeePassword.Text;
            userName = id;
            Boolean success = false;

            if (id.Equals("admin") || id.Equals("62501"))
            {
                if (password.Equals("admin"))
                {
                    userType = "Administrator";
                    this.Hide();
                    mainPageAdmin = new MainPage_Admin();
                    mainPageAdmin.Show();
                    success = true;
                }
            }
            else
            {
                userType = EMRDatabase.ValidateLogin(id, password);

                if (userType == "Administrator")
                {
                    this.Hide();
                    mainPageAdmin = new MainPage_Admin();
                    mainPageAdmin.Show();
                    success = true;
                }
                else if (userType == "Physician")
                {
                    this.Hide();
                    mainPageDoctor = new MainPage_Doctor();
                    mainPageDoctor.Show();
                    success = true;
                }
                else if (userType == "Pharmacist")
                {
                    this.Hide();
                    mainPageDoctor = new MainPage_Doctor();
                    mainPageDoctor.Show();
                    success = true;
                }
                else if (userType == "Clerk")
                {
                    this.Hide();
                    mainPageClerk = new MainPage_Clerk();
                    mainPageClerk.Show();
                    success = true;
                }
                else
                {
                    success = false;
                }
            }

            //if (id.Equals("doctor") || id.Equals("62502"))
            //{
            //    if (password.Equals("doctor"))
            //    {
            //        this.Hide();
            //        mainPageDoctor = new MainPage_Doctor();
            //        mainPageDoctor.Show();
            //        success = true;
            //    }
            //}

            //if (id.Equals("pharmacist") || id.Equals("62503"))
            //{
            //    if (password.Equals("pharmacist"))
            //    {
            //        this.Hide();
            //        mainPageDoctor = new MainPage_Doctor();
            //        mainPageDoctor.Show();
            //        success = true;
            //    }
            //}

            //if (id.Equals("clerk") || id.Equals("62504"))
            //{
            //    if (password.Equals("patient"))
            //    {
            //        this.Hide();
            //        mainPageClerk = new MainPage_Clerk();
            //        mainPageClerk.Show();
            //        success = true;
            //    }
            //}

            //if (id.Equals("patient") || id.Equals("62505"))
            //{
            //    this.Hide();
            //    patientPage = new PatientPage();
            //    patientPage.Show();
            //    success = true;
            //}

            if (!success) {
                textEmployeePassword.Text = "";
                if (userType == "Inactive")
                {
                    labelBadLogin.Text = "Inactive account. Please try again.";
                }
                else labelBadLogin.Text = "Invalid login. Please try again.";
            }

        }

        private void TextEmployeeId_TextChanged(object sender, EventArgs e)
        {
            labelBadLogin.Text = "";
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            labelBadLogin.Text = "";
        }
    }
}
