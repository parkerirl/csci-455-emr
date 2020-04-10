namespace EMR_System
{
    partial class ModifyUsersPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelSelectUser = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelSSN = new System.Windows.Forms.Label();
            this.labelPosition = new System.Windows.Forms.Label();
            this.labelSetPassword = new System.Windows.Forms.Label();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.buttonSaveAndSubmit = new System.Windows.Forms.Button();
            this.textModifyUser = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textSetFirstName = new System.Windows.Forms.TextBox();
            this.textSetSSN = new System.Windows.Forms.TextBox();
            this.textSetAddress = new System.Windows.Forms.TextBox();
            this.textSetPhoneNumber = new System.Windows.Forms.TextBox();
            this.textSetPassword = new System.Windows.Forms.TextBox();
            this.comboSetPosition = new System.Windows.Forms.ComboBox();
            this.textSetLastName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.buttonModify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonBack.CausesValidation = false;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonBack.Location = new System.Drawing.Point(12, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(150, 52);
            this.buttonBack.TabIndex = 17;
            this.buttonBack.Text = "Main Page";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // labelSelectUser
            // 
            this.labelSelectUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectUser.ForeColor = System.Drawing.SystemColors.Control;
            this.labelSelectUser.Location = new System.Drawing.Point(383, 62);
            this.labelSelectUser.Name = "labelSelectUser";
            this.labelSelectUser.Size = new System.Drawing.Size(116, 34);
            this.labelSelectUser.TabIndex = 18;
            this.labelSelectUser.Text = "User:";
            this.labelSelectUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelFirstName
            // 
            this.labelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstName.ForeColor = System.Drawing.SystemColors.Control;
            this.labelFirstName.Location = new System.Drawing.Point(296, 112);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(203, 34);
            this.labelFirstName.TabIndex = 20;
            this.labelFirstName.Text = "First Name:";
            this.labelFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSSN
            // 
            this.labelSSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSSN.ForeColor = System.Drawing.SystemColors.Control;
            this.labelSSN.Location = new System.Drawing.Point(296, 212);
            this.labelSSN.Name = "labelSSN";
            this.labelSSN.Size = new System.Drawing.Size(203, 34);
            this.labelSSN.TabIndex = 21;
            this.labelSSN.Text = "SSN:";
            this.labelSSN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPosition
            // 
            this.labelPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPosition.ForeColor = System.Drawing.SystemColors.Control;
            this.labelPosition.Location = new System.Drawing.Point(296, 262);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(203, 34);
            this.labelPosition.TabIndex = 22;
            this.labelPosition.Text = "Position:";
            this.labelPosition.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSetPassword
            // 
            this.labelSetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSetPassword.ForeColor = System.Drawing.SystemColors.Control;
            this.labelSetPassword.Location = new System.Drawing.Point(296, 412);
            this.labelSetPassword.Name = "labelSetPassword";
            this.labelSetPassword.Size = new System.Drawing.Size(203, 34);
            this.labelSetPassword.TabIndex = 26;
            this.labelSetPassword.Text = "Password:";
            this.labelSetPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhoneNumber.ForeColor = System.Drawing.SystemColors.Control;
            this.labelPhoneNumber.Location = new System.Drawing.Point(296, 362);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(203, 34);
            this.labelPhoneNumber.TabIndex = 25;
            this.labelPhoneNumber.Text = "Phone Number:";
            this.labelPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelAddress
            // 
            this.labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.ForeColor = System.Drawing.SystemColors.Control;
            this.labelAddress.Location = new System.Drawing.Point(296, 312);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(203, 34);
            this.labelAddress.TabIndex = 24;
            this.labelAddress.Text = "Address:";
            this.labelAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonSaveAndSubmit
            // 
            this.buttonSaveAndSubmit.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonSaveAndSubmit.CausesValidation = false;
            this.buttonSaveAndSubmit.Enabled = false;
            this.buttonSaveAndSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveAndSubmit.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSaveAndSubmit.Location = new System.Drawing.Point(494, 537);
            this.buttonSaveAndSubmit.Name = "buttonSaveAndSubmit";
            this.buttonSaveAndSubmit.Size = new System.Drawing.Size(175, 68);
            this.buttonSaveAndSubmit.TabIndex = 27;
            this.buttonSaveAndSubmit.Text = "Save and Submit";
            this.buttonSaveAndSubmit.UseVisualStyleBackColor = false;
            // 
            // textModifyUser
            // 
            this.textModifyUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textModifyUser.Location = new System.Drawing.Point(505, 65);
            this.textModifyUser.Name = "textModifyUser";
            this.textModifyUser.Size = new System.Drawing.Size(209, 31);
            this.textModifyUser.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MidnightBlue;
            this.button1.CausesValidation = false;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(720, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 35);
            this.button1.TabIndex = 29;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textSetFirstName
            // 
            this.textSetFirstName.Enabled = false;
            this.textSetFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSetFirstName.Location = new System.Drawing.Point(505, 115);
            this.textSetFirstName.Name = "textSetFirstName";
            this.textSetFirstName.Size = new System.Drawing.Size(209, 31);
            this.textSetFirstName.TabIndex = 30;
            // 
            // textSetSSN
            // 
            this.textSetSSN.Enabled = false;
            this.textSetSSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSetSSN.Location = new System.Drawing.Point(505, 215);
            this.textSetSSN.Name = "textSetSSN";
            this.textSetSSN.Size = new System.Drawing.Size(209, 31);
            this.textSetSSN.TabIndex = 31;
            // 
            // textSetAddress
            // 
            this.textSetAddress.Enabled = false;
            this.textSetAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSetAddress.Location = new System.Drawing.Point(505, 317);
            this.textSetAddress.Name = "textSetAddress";
            this.textSetAddress.Size = new System.Drawing.Size(209, 31);
            this.textSetAddress.TabIndex = 33;
            // 
            // textSetPhoneNumber
            // 
            this.textSetPhoneNumber.Enabled = false;
            this.textSetPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSetPhoneNumber.Location = new System.Drawing.Point(505, 367);
            this.textSetPhoneNumber.Name = "textSetPhoneNumber";
            this.textSetPhoneNumber.Size = new System.Drawing.Size(209, 31);
            this.textSetPhoneNumber.TabIndex = 34;
            // 
            // textSetPassword
            // 
            this.textSetPassword.Enabled = false;
            this.textSetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSetPassword.Location = new System.Drawing.Point(505, 417);
            this.textSetPassword.Name = "textSetPassword";
            this.textSetPassword.Size = new System.Drawing.Size(209, 31);
            this.textSetPassword.TabIndex = 35;
            // 
            // comboSetPosition
            // 
            this.comboSetPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSetPosition.Enabled = false;
            this.comboSetPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSetPosition.FormattingEnabled = true;
            this.comboSetPosition.Items.AddRange(new object[] {
            "Administrator",
            "Physician",
            "Pharmacist",
            "Clerk"});
            this.comboSetPosition.Location = new System.Drawing.Point(505, 265);
            this.comboSetPosition.Name = "comboSetPosition";
            this.comboSetPosition.Size = new System.Drawing.Size(209, 33);
            this.comboSetPosition.TabIndex = 36;
            // 
            // textSetLastName
            // 
            this.textSetLastName.Enabled = false;
            this.textSetLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSetLastName.Location = new System.Drawing.Point(505, 165);
            this.textSetLastName.Name = "textSetLastName";
            this.textSetLastName.Size = new System.Drawing.Size(209, 31);
            this.textSetLastName.TabIndex = 38;
            // 
            // labelLastName
            // 
            this.labelLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastName.ForeColor = System.Drawing.SystemColors.Control;
            this.labelLastName.Location = new System.Drawing.Point(296, 162);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(203, 34);
            this.labelLastName.TabIndex = 37;
            this.labelLastName.Text = "Last Name:";
            this.labelLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonModify
            // 
            this.buttonModify.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonModify.CausesValidation = false;
            this.buttonModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModify.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonModify.Location = new System.Drawing.Point(494, 473);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(175, 45);
            this.buttonModify.TabIndex = 39;
            this.buttonModify.Text = "Modify";
            this.buttonModify.UseVisualStyleBackColor = false;
            // 
            // ModifyUsersPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1111, 617);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.textSetLastName);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.comboSetPosition);
            this.Controls.Add(this.textSetPassword);
            this.Controls.Add(this.textSetPhoneNumber);
            this.Controls.Add(this.textSetAddress);
            this.Controls.Add(this.textSetSSN);
            this.Controls.Add(this.textSetFirstName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textModifyUser);
            this.Controls.Add(this.buttonSaveAndSubmit);
            this.Controls.Add(this.labelSetPassword);
            this.Controls.Add(this.labelPhoneNumber);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelPosition);
            this.Controls.Add(this.labelSSN);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.labelSelectUser);
            this.Controls.Add(this.buttonBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ModifyUsersPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Electronic Medical Record System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelSelectUser;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelSSN;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Label labelSetPassword;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Button buttonSaveAndSubmit;
        private System.Windows.Forms.TextBox textModifyUser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textSetFirstName;
        private System.Windows.Forms.TextBox textSetSSN;
        private System.Windows.Forms.TextBox textSetAddress;
        private System.Windows.Forms.TextBox textSetPhoneNumber;
        private System.Windows.Forms.TextBox textSetPassword;
        private System.Windows.Forms.ComboBox comboSetPosition;
        private System.Windows.Forms.TextBox textSetLastName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Button buttonModify;
    }
}