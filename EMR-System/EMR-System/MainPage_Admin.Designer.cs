namespace EMR_System
{
    partial class MainPage_Admin
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
            this.buttonPatientSearch = new System.Windows.Forms.Button();
            this.buttonCreateRecord = new System.Windows.Forms.Button();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.labelLoggedInAs = new System.Windows.Forms.Label();
            this.labelCurrentUserName = new System.Windows.Forms.Label();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.labelStatusType = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonReportBug = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPatientSearch
            // 
            this.buttonPatientSearch.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonPatientSearch.CausesValidation = false;
            this.buttonPatientSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPatientSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonPatientSearch.Location = new System.Drawing.Point(118, 146);
            this.buttonPatientSearch.Name = "buttonPatientSearch";
            this.buttonPatientSearch.Size = new System.Drawing.Size(241, 146);
            this.buttonPatientSearch.TabIndex = 0;
            this.buttonPatientSearch.Text = "Search for Patient";
            this.buttonPatientSearch.UseVisualStyleBackColor = false;
            this.buttonPatientSearch.Click += new System.EventHandler(this.ButtonPatientSearch_Click);
            // 
            // buttonCreateRecord
            // 
            this.buttonCreateRecord.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonCreateRecord.CausesValidation = false;
            this.buttonCreateRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateRecord.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonCreateRecord.Location = new System.Drawing.Point(453, 146);
            this.buttonCreateRecord.Name = "buttonCreateRecord";
            this.buttonCreateRecord.Size = new System.Drawing.Size(241, 146);
            this.buttonCreateRecord.TabIndex = 1;
            this.buttonCreateRecord.Text = "Create Patient Record";
            this.buttonCreateRecord.UseVisualStyleBackColor = false;
            this.buttonCreateRecord.Click += new System.EventHandler(this.ButtonCreateRecord_Click);
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonAddUser.CausesValidation = false;
            this.buttonAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddUser.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAddUser.Location = new System.Drawing.Point(788, 146);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(241, 146);
            this.buttonAddUser.TabIndex = 2;
            this.buttonAddUser.Text = "Modify User Privileges";
            this.buttonAddUser.UseVisualStyleBackColor = false;
            this.buttonAddUser.Click += new System.EventHandler(this.ButtonAddUser_Click);
            // 
            // labelLoggedInAs
            // 
            this.labelLoggedInAs.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoggedInAs.ForeColor = System.Drawing.SystemColors.Control;
            this.labelLoggedInAs.Location = new System.Drawing.Point(800, 9);
            this.labelLoggedInAs.Name = "labelLoggedInAs";
            this.labelLoggedInAs.Size = new System.Drawing.Size(76, 34);
            this.labelLoggedInAs.TabIndex = 3;
            this.labelLoggedInAs.Text = "User:";
            this.labelLoggedInAs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCurrentUserName
            // 
            this.labelCurrentUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentUserName.ForeColor = System.Drawing.SystemColors.Control;
            this.labelCurrentUserName.Location = new System.Drawing.Point(873, 9);
            this.labelCurrentUserName.Name = "labelCurrentUserName";
            this.labelCurrentUserName.Size = new System.Drawing.Size(226, 34);
            this.labelCurrentUserName.TabIndex = 4;
            this.labelCurrentUserName.Text = "<Name>";
            this.labelCurrentUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.DarkRed;
            this.buttonLogout.CausesValidation = false;
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonLogout.Location = new System.Drawing.Point(444, 482);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(261, 95);
            this.buttonLogout.TabIndex = 7;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.ButtonLogout_Click);
            // 
            // labelStatusType
            // 
            this.labelStatusType.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatusType.ForeColor = System.Drawing.SystemColors.Control;
            this.labelStatusType.Location = new System.Drawing.Point(873, 43);
            this.labelStatusType.Name = "labelStatusType";
            this.labelStatusType.Size = new System.Drawing.Size(226, 34);
            this.labelStatusType.TabIndex = 9;
            this.labelStatusType.Text = "<Access Type>";
            this.labelStatusType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelStatus
            // 
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.SystemColors.Control;
            this.labelStatus.Location = new System.Drawing.Point(788, 43);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(88, 34);
            this.labelStatus.TabIndex = 8;
            this.labelStatus.Text = "Status:";
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonReportBug
            // 
            this.buttonReportBug.BackColor = System.Drawing.Color.DimGray;
            this.buttonReportBug.CausesValidation = false;
            this.buttonReportBug.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReportBug.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonReportBug.Location = new System.Drawing.Point(12, 12);
            this.buttonReportBug.Name = "buttonReportBug";
            this.buttonReportBug.Size = new System.Drawing.Size(103, 55);
            this.buttonReportBug.TabIndex = 10;
            this.buttonReportBug.Text = "Report a Problem";
            this.buttonReportBug.UseVisualStyleBackColor = false;
            this.buttonReportBug.Click += new System.EventHandler(this.ButtonReportBug_Click);
            // 
            // MainPage_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1111, 617);
            this.Controls.Add(this.buttonReportBug);
            this.Controls.Add(this.labelStatusType);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.labelCurrentUserName);
            this.Controls.Add(this.labelLoggedInAs);
            this.Controls.Add(this.buttonAddUser);
            this.Controls.Add(this.buttonCreateRecord);
            this.Controls.Add(this.buttonPatientSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainPage_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Electronic Medical Record System";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPatientSearch;
        private System.Windows.Forms.Button buttonCreateRecord;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.Label labelLoggedInAs;
        private System.Windows.Forms.Label labelCurrentUserName;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Label labelStatusType;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button buttonReportBug;
    }
}