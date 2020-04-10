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

        public LoginPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            string id = textEmployeeId.Text;
            string password = textEmployeePassword.Text;
            userName = id;
            userType = password;
            Boolean success = false;

            if(id.Equals("admin") || id.Equals("62501")) {
                if (password.Equals("admin")) {
                    this.Hide();
                    mainPageAdmin = new MainPage_Admin();
                    mainPageAdmin.Show();
                    success = true;
                }
            }

            if (id.Equals("doctor") || id.Equals("62502"))
            {
                if (password.Equals("doctor"))
                {
                    this.Hide();
                    mainPageDoctor = new MainPage_Doctor();
                    mainPageDoctor.Show();
                    success = true;
                }
            }

            if (id.Equals("pharmacist") || id.Equals("62503"))
            {
                if (password.Equals("pharmacist"))
                {
                    this.Hide();
                    mainPageDoctor = new MainPage_Doctor();
                    mainPageDoctor.Show();
                    success = true;
                }
            }

            if (id.Equals("clerk") || id.Equals("62504"))
            {
                if (password.Equals("clerk"))
                {
                    this.Hide();
                    mainPageClerk = new MainPage_Clerk();
                    mainPageClerk.Show();
                    success = true;
                }
            }

            if (!success) {
                textEmployeePassword.Text = "";
                labelBadLogin.Text = "Invalid login. Please try again.";
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
