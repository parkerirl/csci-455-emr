namespace EMR_System
{
    partial class AddPrescription
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
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelPrescription = new System.Windows.Forms.Label();
            this.labelDosage = new System.Windows.Forms.Label();
            this.labelFrequency = new System.Windows.Forms.Label();
            this.textSetPrescriptionName = new System.Windows.Forms.TextBox();
            this.textDosage = new System.Windows.Forms.TextBox();
            this.comboFrequency = new System.Windows.Forms.ComboBox();
            this.labelRecurring = new System.Windows.Forms.Label();
            this.comboRenew = new System.Windows.Forms.ComboBox();
            this.labelErrorText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonSubmit.CausesValidation = false;
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSubmit.Location = new System.Drawing.Point(591, 378);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(213, 85);
            this.buttonSubmit.TabIndex = 97;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonCancel.CausesValidation = false;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonCancel.Location = new System.Drawing.Point(12, 378);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(213, 85);
            this.buttonCancel.TabIndex = 98;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // labelPrescription
            // 
            this.labelPrescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrescription.ForeColor = System.Drawing.SystemColors.Control;
            this.labelPrescription.Location = new System.Drawing.Point(128, 76);
            this.labelPrescription.Name = "labelPrescription";
            this.labelPrescription.Size = new System.Drawing.Size(274, 34);
            this.labelPrescription.TabIndex = 99;
            this.labelPrescription.Text = "Prescription Name:";
            this.labelPrescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelDosage
            // 
            this.labelDosage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDosage.ForeColor = System.Drawing.SystemColors.Control;
            this.labelDosage.Location = new System.Drawing.Point(128, 154);
            this.labelDosage.Name = "labelDosage";
            this.labelDosage.Size = new System.Drawing.Size(274, 34);
            this.labelDosage.TabIndex = 100;
            this.labelDosage.Text = "Dosage:";
            this.labelDosage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelFrequency
            // 
            this.labelFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFrequency.ForeColor = System.Drawing.SystemColors.Control;
            this.labelFrequency.Location = new System.Drawing.Point(128, 227);
            this.labelFrequency.Name = "labelFrequency";
            this.labelFrequency.Size = new System.Drawing.Size(274, 34);
            this.labelFrequency.TabIndex = 101;
            this.labelFrequency.Text = "Frequency:";
            this.labelFrequency.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textSetPrescriptionName
            // 
            this.textSetPrescriptionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSetPrescriptionName.Location = new System.Drawing.Point(408, 79);
            this.textSetPrescriptionName.Name = "textSetPrescriptionName";
            this.textSetPrescriptionName.Size = new System.Drawing.Size(244, 31);
            this.textSetPrescriptionName.TabIndex = 102;
            this.textSetPrescriptionName.Click += new System.EventHandler(this.onClicked);
            // 
            // textDosage
            // 
            this.textDosage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDosage.Location = new System.Drawing.Point(408, 157);
            this.textDosage.Name = "textDosage";
            this.textDosage.Size = new System.Drawing.Size(244, 31);
            this.textDosage.TabIndex = 103;
            this.textDosage.Click += new System.EventHandler(this.onClicked);
            // 
            // comboFrequency
            // 
            this.comboFrequency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboFrequency.FormattingEnabled = true;
            this.comboFrequency.Items.AddRange(new object[] {
            "Once",
            "1 Hour",
            "2 Hours",
            "4 Hours",
            "6 Hours",
            "8 Hours",
            "12 Hours",
            "24 Hours",
            "48 Hours",
            "72 Hours"});
            this.comboFrequency.Location = new System.Drawing.Point(408, 230);
            this.comboFrequency.Name = "comboFrequency";
            this.comboFrequency.Size = new System.Drawing.Size(244, 33);
            this.comboFrequency.TabIndex = 104;
            this.comboFrequency.Click += new System.EventHandler(this.onClicked);
            // 
            // labelRecurring
            // 
            this.labelRecurring.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecurring.ForeColor = System.Drawing.SystemColors.Control;
            this.labelRecurring.Location = new System.Drawing.Point(128, 296);
            this.labelRecurring.Name = "labelRecurring";
            this.labelRecurring.Size = new System.Drawing.Size(274, 34);
            this.labelRecurring.TabIndex = 105;
            this.labelRecurring.Text = "Renew:";
            this.labelRecurring.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboRenew
            // 
            this.comboRenew.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRenew.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboRenew.FormattingEnabled = true;
            this.comboRenew.Items.AddRange(new object[] {
            "Never",
            "Once",
            "Twice",
            "Continually"});
            this.comboRenew.Location = new System.Drawing.Point(408, 299);
            this.comboRenew.Name = "comboRenew";
            this.comboRenew.Size = new System.Drawing.Size(244, 33);
            this.comboRenew.TabIndex = 106;
            this.comboRenew.Click += new System.EventHandler(this.onClicked);
            // 
            // labelErrorText
            // 
            this.labelErrorText.BackColor = System.Drawing.Color.Transparent;
            this.labelErrorText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrorText.ForeColor = System.Drawing.Color.Red;
            this.labelErrorText.Location = new System.Drawing.Point(276, 378);
            this.labelErrorText.Name = "labelErrorText";
            this.labelErrorText.Size = new System.Drawing.Size(274, 34);
            this.labelErrorText.TabIndex = 107;
            this.labelErrorText.Text = "Please enter all fields.";
            this.labelErrorText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelErrorText.Visible = false;
            // 
            // AddPrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(816, 475);
            this.Controls.Add(this.labelErrorText);
            this.Controls.Add(this.comboRenew);
            this.Controls.Add(this.labelRecurring);
            this.Controls.Add(this.comboFrequency);
            this.Controls.Add(this.textDosage);
            this.Controls.Add(this.textSetPrescriptionName);
            this.Controls.Add(this.labelFrequency);
            this.Controls.Add(this.labelDosage);
            this.Controls.Add(this.labelPrescription);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSubmit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddPrescription";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Electronic Medical Record System";
            this.Load += new System.EventHandler(this.AddPrescription_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelPrescription;
        private System.Windows.Forms.Label labelDosage;
        private System.Windows.Forms.Label labelFrequency;
        private System.Windows.Forms.TextBox textSetPrescriptionName;
        private System.Windows.Forms.TextBox textDosage;
        private System.Windows.Forms.ComboBox comboFrequency;
        private System.Windows.Forms.Label labelRecurring;
        private System.Windows.Forms.ComboBox comboRenew;
        private System.Windows.Forms.Label labelErrorText;
    }
}