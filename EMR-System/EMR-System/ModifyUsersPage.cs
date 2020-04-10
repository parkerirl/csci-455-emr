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
    public partial class ModifyUsersPage : Form
    {
        public ModifyUsersPage()
        {
            InitializeComponent();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            MainPage_Admin main = new MainPage_Admin();
            main.Show();
            this.Close();
        }

        private void ComboSelectUser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int userId = Int32.Parse(textModifyUser.Text);

            if (userId == 62503)
            {
                textSetFirstName.Text = "Parker";
                textSetLastName.Text = "Combs";
                textSetSSN.Text = "123-45-6789";
                comboSetPosition.SelectedIndex = 2;
                textSetAddress.Text = "1234 University Ave";
                textSetPhoneNumber.Text = "612-854-0298";
                textSetPassword.Text = "**********";
            }
        }
    }
}
