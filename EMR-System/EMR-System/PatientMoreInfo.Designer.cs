namespace EMR_System
{
    partial class PatientMoreInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonBack = new System.Windows.Forms.Button();
            this.textSetLastName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textSetAddress = new System.Windows.Forms.TextBox();
            this.textSetSSN = new System.Windows.Forms.TextBox();
            this.textSetFirstName = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelSSN = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textSetPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textSetEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textSetInsuranceNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textSetInsuranceProvider = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textSetBirthday = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textSetPrimaryPhysician = new System.Windows.Forms.TextBox();
            this.textSetBloodType = new System.Windows.Forms.TextBox();
            this.textSetSex = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.f_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.buttonBack.Size = new System.Drawing.Size(179, 64);
            this.buttonBack.TabIndex = 90;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonMoreInfo_Click);
            // 
            // textSetLastName
            // 
            this.textSetLastName.Enabled = false;
            this.textSetLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSetLastName.Location = new System.Drawing.Point(221, 118);
            this.textSetLastName.Name = "textSetLastName";
            this.textSetLastName.Size = new System.Drawing.Size(209, 31);
            this.textSetLastName.TabIndex = 98;
            // 
            // labelLastName
            // 
            this.labelLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastName.ForeColor = System.Drawing.SystemColors.Control;
            this.labelLastName.Location = new System.Drawing.Point(12, 115);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(203, 34);
            this.labelLastName.TabIndex = 97;
            this.labelLastName.Text = "Last Name:";
            this.labelLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textSetAddress
            // 
            this.textSetAddress.Enabled = false;
            this.textSetAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSetAddress.Location = new System.Drawing.Point(221, 192);
            this.textSetAddress.Name = "textSetAddress";
            this.textSetAddress.Size = new System.Drawing.Size(209, 31);
            this.textSetAddress.TabIndex = 96;
            // 
            // textSetSSN
            // 
            this.textSetSSN.Enabled = false;
            this.textSetSSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSetSSN.Location = new System.Drawing.Point(221, 155);
            this.textSetSSN.Name = "textSetSSN";
            this.textSetSSN.Size = new System.Drawing.Size(209, 31);
            this.textSetSSN.TabIndex = 95;
            // 
            // textSetFirstName
            // 
            this.textSetFirstName.Enabled = false;
            this.textSetFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSetFirstName.Location = new System.Drawing.Point(221, 81);
            this.textSetFirstName.Name = "textSetFirstName";
            this.textSetFirstName.Size = new System.Drawing.Size(209, 31);
            this.textSetFirstName.TabIndex = 94;
            this.textSetFirstName.TextChanged += new System.EventHandler(this.textSetFirstName_TextChanged);
            // 
            // labelAddress
            // 
            this.labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.ForeColor = System.Drawing.SystemColors.Control;
            this.labelAddress.Location = new System.Drawing.Point(12, 189);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(203, 34);
            this.labelAddress.TabIndex = 93;
            this.labelAddress.Text = "Address:";
            this.labelAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelAddress.Click += new System.EventHandler(this.labelAddress_Click);
            // 
            // labelSSN
            // 
            this.labelSSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSSN.ForeColor = System.Drawing.SystemColors.Control;
            this.labelSSN.Location = new System.Drawing.Point(12, 152);
            this.labelSSN.Name = "labelSSN";
            this.labelSSN.Size = new System.Drawing.Size(203, 34);
            this.labelSSN.TabIndex = 92;
            this.labelSSN.Text = "SSN:";
            this.labelSSN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelFirstName
            // 
            this.labelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstName.ForeColor = System.Drawing.SystemColors.Control;
            this.labelFirstName.Location = new System.Drawing.Point(12, 78);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(203, 34);
            this.labelFirstName.TabIndex = 91;
            this.labelFirstName.Text = "First Name:";
            this.labelFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textSetPhone
            // 
            this.textSetPhone.Enabled = false;
            this.textSetPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSetPhone.Location = new System.Drawing.Point(221, 229);
            this.textSetPhone.Name = "textSetPhone";
            this.textSetPhone.Size = new System.Drawing.Size(209, 31);
            this.textSetPhone.TabIndex = 100;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 34);
            this.label1.TabIndex = 99;
            this.label1.Text = "Phone Number:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textSetEmail
            // 
            this.textSetEmail.Enabled = false;
            this.textSetEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSetEmail.Location = new System.Drawing.Point(221, 266);
            this.textSetEmail.Name = "textSetEmail";
            this.textSetEmail.Size = new System.Drawing.Size(209, 31);
            this.textSetEmail.TabIndex = 102;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 34);
            this.label2.TabIndex = 101;
            this.label2.Text = "Email:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textSetInsuranceNumber
            // 
            this.textSetInsuranceNumber.Enabled = false;
            this.textSetInsuranceNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSetInsuranceNumber.Location = new System.Drawing.Point(221, 488);
            this.textSetInsuranceNumber.Name = "textSetInsuranceNumber";
            this.textSetInsuranceNumber.Size = new System.Drawing.Size(209, 31);
            this.textSetInsuranceNumber.TabIndex = 114;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(7, 488);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 28);
            this.label3.TabIndex = 113;
            this.label3.Text = "Insurance Number:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textSetInsuranceProvider
            // 
            this.textSetInsuranceProvider.Enabled = false;
            this.textSetInsuranceProvider.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSetInsuranceProvider.Location = new System.Drawing.Point(221, 451);
            this.textSetInsuranceProvider.Name = "textSetInsuranceProvider";
            this.textSetInsuranceProvider.Size = new System.Drawing.Size(209, 31);
            this.textSetInsuranceProvider.TabIndex = 112;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(12, 453);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 27);
            this.label4.TabIndex = 111;
            this.label4.Text = "Insurance Provider:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textSetBirthday
            // 
            this.textSetBirthday.Enabled = false;
            this.textSetBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSetBirthday.Location = new System.Drawing.Point(221, 340);
            this.textSetBirthday.Name = "textSetBirthday";
            this.textSetBirthday.Size = new System.Drawing.Size(209, 31);
            this.textSetBirthday.TabIndex = 110;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(12, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 34);
            this.label5.TabIndex = 109;
            this.label5.Text = "Birthday:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textSetPrimaryPhysician
            // 
            this.textSetPrimaryPhysician.Enabled = false;
            this.textSetPrimaryPhysician.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSetPrimaryPhysician.Location = new System.Drawing.Point(221, 414);
            this.textSetPrimaryPhysician.Name = "textSetPrimaryPhysician";
            this.textSetPrimaryPhysician.Size = new System.Drawing.Size(209, 31);
            this.textSetPrimaryPhysician.TabIndex = 108;
            // 
            // textSetBloodType
            // 
            this.textSetBloodType.Enabled = false;
            this.textSetBloodType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSetBloodType.Location = new System.Drawing.Point(221, 377);
            this.textSetBloodType.Name = "textSetBloodType";
            this.textSetBloodType.Size = new System.Drawing.Size(209, 31);
            this.textSetBloodType.TabIndex = 107;
            // 
            // textSetSex
            // 
            this.textSetSex.Enabled = false;
            this.textSetSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSetSex.Location = new System.Drawing.Point(221, 303);
            this.textSetSex.Name = "textSetSex";
            this.textSetSex.Size = new System.Drawing.Size(209, 31);
            this.textSetSex.TabIndex = 106;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(12, 408);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 38);
            this.label6.TabIndex = 105;
            this.label6.Text = "Primary Physician:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(12, 374);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(203, 34);
            this.label7.TabIndex = 104;
            this.label7.Text = "Blood Type:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(12, 300);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(203, 34);
            this.label8.TabIndex = 103;
            this.label8.Text = "Sex:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(436, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 34);
            this.label9.TabIndex = 116;
            this.label9.Text = "Allergies:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.f_name,
            this.dob});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(571, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 38;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(528, 260);
            this.dataGridView1.TabIndex = 117;
            // 
            // f_name
            // 
            this.f_name.HeaderText = "Allergy";
            this.f_name.Name = "f_name";
            // 
            // dob
            // 
            this.dob.HeaderText = "Date Found";
            this.dob.Name = "dob";
            // 
            // PatientMoreInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1111, 617);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textSetInsuranceNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textSetInsuranceProvider);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textSetBirthday);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textSetPrimaryPhysician);
            this.Controls.Add(this.textSetBloodType);
            this.Controls.Add(this.textSetSex);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textSetEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textSetPhone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textSetLastName);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.textSetAddress);
            this.Controls.Add(this.textSetSSN);
            this.Controls.Add(this.textSetFirstName);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelSSN);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.buttonBack);
            this.Name = "PatientMoreInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Electronic Medical Record System";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.TextBox textSetLastName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textSetAddress;
        private System.Windows.Forms.TextBox textSetSSN;
        private System.Windows.Forms.TextBox textSetFirstName;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelSSN;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textSetPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textSetEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textSetInsuranceNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textSetInsuranceProvider;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textSetBirthday;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textSetPrimaryPhysician;
        private System.Windows.Forms.TextBox textSetBloodType;
        private System.Windows.Forms.TextBox textSetSex;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn f_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dob;
    }
}