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
        private string activeTab;
        private List<string>[] user;
        private List<string>[] userAccount;
        public ModifyUsersPage()
        {
            InitializeComponent();
            this.buttonSearch.Visible = true;
            this.labelSearch.Visible = true;
            this.textSearch.Visible = true;
            this.activeTab = "modify";
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

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            ConnectDB EMRDatabase = new ConnectDB();

            user = EMRDatabase.ViewUser(this.textSearch.Text);
            userAccount = EMRDatabase.ViewAccount(this.textSearch.Text);

            this.resetAll();

            if(user[0].Count > 0)
            {
                this.textSetSSN.Text = user[0][0];
                this.textSetFirstName.Text = user[1][0];
                this.textSetLastName.Text = user[2][0];
                this.textSetEmail.Text = user[3][0];
                this.textSetAddress.Text = user[4][0];
                this.textSetPhoneNumber.Text = user[5][0];
                this.comboSetPosition.SelectedItem = user[6][0];
            }

            if (userAccount[0].Count > 0)
            {
                this.textSetUsername.Text = userAccount[0][0];
                this.textSetPassword.Text = userAccount[1][0];
                this.comboSetPrivilege.SelectedItem = userAccount[2][0];
                this.comboSetStatus.SelectedItem = userAccount[3][0];
            }

            this.enableAll();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            this.activeTab = "add";
            this.buttonSearch.Visible = false;
            this.labelSearch.Visible = false;
            this.textSearch.Visible = false;

            this.enableAll();
            this.resetAll();
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            this.activeTab = "modify";

            this.buttonSearch.Visible = true;
            this.labelSearch.Visible = true;
            this.textSearch.Visible = true;

            this.disableAll();
            this.resetAll();
        }

        private void enableAll()
        {
            this.textSetAddress.Enabled = true;
            this.textSetFirstName.Enabled = true;
            this.textSetLastName.Enabled = true;
            this.textSetPassword.Enabled = true;
            this.textSetSSN.Enabled = true;
            this.textSetPhoneNumber.Enabled = true;
            this.textSetUsername.Enabled = true;
            this.textSetEmail.Enabled = true;

            this.comboSetPosition.Enabled = true;
            this.comboSetPrivilege.Enabled = true;
            this.comboSetStatus.Enabled = true;
        }

        private void disableAll()
        {
            this.textSetAddress.Enabled = false;
            this.textSetFirstName.Enabled = false;
            this.textSetLastName.Enabled = false;
            this.textSetPassword.Enabled = false;
            this.textSetSSN.Enabled = false;
            this.textSetPhoneNumber.Enabled = false;
            this.textSetUsername.Enabled = false;
            this.textSetEmail.Enabled = false;

            this.comboSetPosition.Enabled = false;
            this.comboSetPrivilege.Enabled = false;
            this.comboSetStatus.Enabled = false;
        }

        private void resetAll()
        {
            this.textSetAddress.Text = null;
            this.textSetFirstName.Text = null;
            this.textSetLastName.Text = null;
            this.textSetPassword.Text = null;
            this.textSetSSN.Text = null;
            this.textSetPhoneNumber.Text = null;
            this.textSetUsername.Text = null;
            this.textSetEmail.Text = null;

            this.comboSetPosition.SelectedItem = null;
            this.comboSetPrivilege.SelectedItem = null;
            this.comboSetStatus.SelectedItem = null;

        }

        private bool verifyInfo()
        {
            if(this.textSetAddress.Text == null || 
            this.textSetFirstName.Text == null ||
            this.textSetLastName.Text == null ||
            this.textSetPassword.Text == null ||
            this.textSetSSN.Text == null ||
            this.textSetPhoneNumber.Text == null ||
            this.textSetUsername.Text == null || 
            this.textSetEmail.Text == null ||
            this.comboSetPosition.SelectedItem == null ||
            this.comboSetPrivilege.SelectedItem == null ||
            this.comboSetStatus.SelectedItem == null)
            {
                return false;
            }
            return true;
        }

        private void buttonSaveAndSubmit_Click(object sender, EventArgs e)
        {
            if (this.verifyInfo())
            {
                ConnectDB EMRDatabase = new ConnectDB();
                if (this.activeTab == "add")
                {
                    EMRDatabase.AddUser(this.textSetSSN.Text, this.textSetFirstName.Text, this.textSetLastName.Text, this.textSetEmail.Text, this.textSetAddress.Text, this.textSetPhoneNumber.Text, this.comboSetPosition.SelectedItem.ToString());
                    EMRDatabase.AddUserAccount(this.textSetSSN.Text, this.textSetUsername.Text, this.textSetPassword.Text, this.comboSetPrivilege.SelectedItem.ToString(), this.comboSetStatus.SelectedItem.ToString());
                }
                if (this.activeTab == "modify")
                {
                    EMRDatabase.ModifyUser(this.textSearch.Text, this.textSetSSN.Text, this.textSetFirstName.Text, this.textSetLastName.Text, this.textSetEmail.Text, this.textSetAddress.Text, this.textSetPhoneNumber.Text, this.comboSetPosition.SelectedItem.ToString());
                    EMRDatabase.ModifyUserAccount(this.textSetSSN.Text, this.textSetUsername.Text, this.textSetPassword.Text, this.comboSetPrivilege.SelectedItem.ToString(), this.comboSetStatus.SelectedItem.ToString());
                }
            }
            else
            {
                MessageBox.Show("Please fill all fields");
            }
        }

        private void comboSetPrivilege_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboSetPosition_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
