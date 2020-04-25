namespace EMR_System
{
    partial class SearchPatientPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonBack = new System.Windows.Forms.Button();
            this.textSetLastName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textSetPhoneNumber = new System.Windows.Forms.TextBox();
            this.textSetAddress = new System.Windows.Forms.TextBox();
            this.textSetSSN = new System.Windows.Forms.TextBox();
            this.textSetFirstName = new System.Windows.Forms.TextBox();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelSSN = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textPatientIdSearch = new System.Windows.Forms.TextBox();
            this.labelPatientID = new System.Windows.Forms.Label();
            this.buttonSearchPatient = new System.Windows.Forms.Button();
            this.labelPatientName = new System.Windows.Forms.Label();
            this.textPatientNameSearch = new System.Windows.Forms.TextBox();
            this.labelResults = new System.Windows.Forms.Label();
            this.buttonMoreInfo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.f_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ins_provider = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.select = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deleteButton = new System.Windows.Forms.Button();
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
            this.buttonBack.Size = new System.Drawing.Size(150, 52);
            this.buttonBack.TabIndex = 18;
            this.buttonBack.Text = "Main Page";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // textSetLastName
            // 
            this.textSetLastName.Enabled = false;
            this.textSetLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSetLastName.Location = new System.Drawing.Point(230, 422);
            this.textSetLastName.Name = "textSetLastName";
            this.textSetLastName.Size = new System.Drawing.Size(209, 31);
            this.textSetLastName.TabIndex = 48;
            // 
            // labelLastName
            // 
            this.labelLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastName.ForeColor = System.Drawing.SystemColors.Control;
            this.labelLastName.Location = new System.Drawing.Point(21, 419);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(203, 34);
            this.labelLastName.TabIndex = 47;
            this.labelLastName.Text = "Last Name:";
            this.labelLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textSetPhoneNumber
            // 
            this.textSetPhoneNumber.Enabled = false;
            this.textSetPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSetPhoneNumber.Location = new System.Drawing.Point(230, 560);
            this.textSetPhoneNumber.Name = "textSetPhoneNumber";
            this.textSetPhoneNumber.Size = new System.Drawing.Size(209, 31);
            this.textSetPhoneNumber.TabIndex = 46;
            // 
            // textSetAddress
            // 
            this.textSetAddress.Enabled = false;
            this.textSetAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSetAddress.Location = new System.Drawing.Point(230, 514);
            this.textSetAddress.Name = "textSetAddress";
            this.textSetAddress.Size = new System.Drawing.Size(209, 31);
            this.textSetAddress.TabIndex = 45;
            // 
            // textSetSSN
            // 
            this.textSetSSN.Enabled = false;
            this.textSetSSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSetSSN.Location = new System.Drawing.Point(230, 468);
            this.textSetSSN.Name = "textSetSSN";
            this.textSetSSN.Size = new System.Drawing.Size(209, 31);
            this.textSetSSN.TabIndex = 44;
            // 
            // textSetFirstName
            // 
            this.textSetFirstName.Enabled = false;
            this.textSetFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSetFirstName.Location = new System.Drawing.Point(230, 376);
            this.textSetFirstName.Name = "textSetFirstName";
            this.textSetFirstName.Size = new System.Drawing.Size(209, 31);
            this.textSetFirstName.TabIndex = 43;
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhoneNumber.ForeColor = System.Drawing.SystemColors.Control;
            this.labelPhoneNumber.Location = new System.Drawing.Point(21, 557);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(203, 34);
            this.labelPhoneNumber.TabIndex = 42;
            this.labelPhoneNumber.Text = "Phone Number:";
            this.labelPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelAddress
            // 
            this.labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.ForeColor = System.Drawing.SystemColors.Control;
            this.labelAddress.Location = new System.Drawing.Point(21, 511);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(203, 34);
            this.labelAddress.TabIndex = 41;
            this.labelAddress.Text = "Address:";
            this.labelAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSSN
            // 
            this.labelSSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSSN.ForeColor = System.Drawing.SystemColors.Control;
            this.labelSSN.Location = new System.Drawing.Point(21, 465);
            this.labelSSN.Name = "labelSSN";
            this.labelSSN.Size = new System.Drawing.Size(203, 34);
            this.labelSSN.TabIndex = 40;
            this.labelSSN.Text = "SSN:";
            this.labelSSN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelFirstName
            // 
            this.labelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstName.ForeColor = System.Drawing.SystemColors.Control;
            this.labelFirstName.Location = new System.Drawing.Point(21, 373);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(203, 34);
            this.labelFirstName.TabIndex = 39;
            this.labelFirstName.Text = "First Name:";
            this.labelFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textPatientIdSearch
            // 
            this.textPatientIdSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPatientIdSearch.Location = new System.Drawing.Point(353, 24);
            this.textPatientIdSearch.Name = "textPatientIdSearch";
            this.textPatientIdSearch.Size = new System.Drawing.Size(209, 31);
            this.textPatientIdSearch.TabIndex = 49;
            this.textPatientIdSearch.TextChanged += new System.EventHandler(this.textPatientIdSearch_TextChanged);
            // 
            // labelPatientID
            // 
            this.labelPatientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPatientID.ForeColor = System.Drawing.SystemColors.Control;
            this.labelPatientID.Location = new System.Drawing.Point(196, 22);
            this.labelPatientID.Name = "labelPatientID";
            this.labelPatientID.Size = new System.Drawing.Size(151, 34);
            this.labelPatientID.TabIndex = 50;
            this.labelPatientID.Text = "Patient ID:";
            this.labelPatientID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonSearchPatient
            // 
            this.buttonSearchPatient.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonSearchPatient.CausesValidation = false;
            this.buttonSearchPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchPatient.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSearchPatient.Location = new System.Drawing.Point(939, 22);
            this.buttonSearchPatient.Name = "buttonSearchPatient";
            this.buttonSearchPatient.Size = new System.Drawing.Size(78, 34);
            this.buttonSearchPatient.TabIndex = 51;
            this.buttonSearchPatient.Text = "Search";
            this.buttonSearchPatient.UseVisualStyleBackColor = false;
            this.buttonSearchPatient.Click += new System.EventHandler(this.Button1_Click);
            // 
            // labelPatientName
            // 
            this.labelPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPatientName.ForeColor = System.Drawing.SystemColors.Control;
            this.labelPatientName.Location = new System.Drawing.Point(567, 22);
            this.labelPatientName.Name = "labelPatientName";
            this.labelPatientName.Size = new System.Drawing.Size(151, 34);
            this.labelPatientName.TabIndex = 74;
            this.labelPatientName.Text = "Name:";
            this.labelPatientName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textPatientNameSearch
            // 
            this.textPatientNameSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPatientNameSearch.Location = new System.Drawing.Point(724, 24);
            this.textPatientNameSearch.Name = "textPatientNameSearch";
            this.textPatientNameSearch.Size = new System.Drawing.Size(209, 31);
            this.textPatientNameSearch.TabIndex = 73;
            this.textPatientNameSearch.TextChanged += new System.EventHandler(this.textPatientNameSearch_TextChanged);
            // 
            // labelResults
            // 
            this.labelResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResults.ForeColor = System.Drawing.SystemColors.Control;
            this.labelResults.Location = new System.Drawing.Point(208, 56);
            this.labelResults.Name = "labelResults";
            this.labelResults.Size = new System.Drawing.Size(118, 34);
            this.labelResults.TabIndex = 75;
            this.labelResults.Text = "Results:";
            this.labelResults.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonMoreInfo
            // 
            this.buttonMoreInfo.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonMoreInfo.CausesValidation = false;
            this.buttonMoreInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMoreInfo.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonMoreInfo.Location = new System.Drawing.Point(482, 527);
            this.buttonMoreInfo.Name = "buttonMoreInfo";
            this.buttonMoreInfo.Size = new System.Drawing.Size(179, 64);
            this.buttonMoreInfo.TabIndex = 89;
            this.buttonMoreInfo.Text = "More Details";
            this.buttonMoreInfo.UseVisualStyleBackColor = false;
            this.buttonMoreInfo.Click += new System.EventHandler(this.buttonMoreInfo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.f_name,
            this.dob,
            this.ins_provider,
            this.select});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(213, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 38;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(685, 260);
            this.dataGridView1.TabIndex = 90;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_CellClick);
            // 
            // f_name
            // 
            this.f_name.HeaderText = "First Name";
            this.f_name.Name = "f_name";
            // 
            // dob
            // 
            this.dob.HeaderText = "DOB";
            this.dob.Name = "dob";
            // 
            // ins_provider
            // 
            this.ins_provider.HeaderText = "Insurance Provider";
            this.ins_provider.Name = "ins_provider";
            // 
            // select
            // 
            this.select.HeaderText = "Select";
            this.select.Name = "select";
            this.select.Text = "Select";
            this.select.UseColumnTextForButtonValue = true;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.deleteButton.CausesValidation = false;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.SystemColors.Control;
            this.deleteButton.Location = new System.Drawing.Point(724, 527);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(179, 64);
            this.deleteButton.TabIndex = 91;
            this.deleteButton.Text = "Delete Patient";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // SearchPatientPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1111, 617);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonMoreInfo);
            this.Controls.Add(this.labelResults);
            this.Controls.Add(this.labelPatientName);
            this.Controls.Add(this.textPatientNameSearch);
            this.Controls.Add(this.buttonSearchPatient);
            this.Controls.Add(this.labelPatientID);
            this.Controls.Add(this.textPatientIdSearch);
            this.Controls.Add(this.textSetLastName);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.textSetPhoneNumber);
            this.Controls.Add(this.textSetAddress);
            this.Controls.Add(this.textSetSSN);
            this.Controls.Add(this.textSetFirstName);
            this.Controls.Add(this.labelPhoneNumber);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelSSN);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.buttonBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SearchPatientPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Electronic Medical Record System";
            this.Load += new System.EventHandler(this.SearchPatientPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.TextBox textSetLastName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textSetPhoneNumber;
        private System.Windows.Forms.TextBox textSetAddress;
        private System.Windows.Forms.TextBox textSetSSN;
        private System.Windows.Forms.TextBox textSetFirstName;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelSSN;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textPatientIdSearch;
        private System.Windows.Forms.Label labelPatientID;
        private System.Windows.Forms.Button buttonSearchPatient;
        private System.Windows.Forms.Label labelPatientName;
        private System.Windows.Forms.TextBox textPatientNameSearch;
        private System.Windows.Forms.Label labelResults;
        private System.Windows.Forms.Button buttonMoreInfo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn f_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dob;
        private System.Windows.Forms.DataGridViewTextBoxColumn ins_provider;
        private System.Windows.Forms.DataGridViewButtonColumn select;
        private System.Windows.Forms.Button deleteButton;
    }
}