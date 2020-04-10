namespace EMR_System
{
    partial class BugReport
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
            this.labelBugTitle = new System.Windows.Forms.Label();
            this.labelBugDescription = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.labelProblemFrequency = new System.Windows.Forms.Label();
            this.labelProblemSeverity = new System.Windows.Forms.Label();
            this.buttonSubmitBug = new System.Windows.Forms.Button();
            this.comboBoxBugFrequency = new System.Windows.Forms.ComboBox();
            this.comboBoxBugSeverity = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelBugTitle
            // 
            this.labelBugTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBugTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.labelBugTitle.Location = new System.Drawing.Point(17, 28);
            this.labelBugTitle.Name = "labelBugTitle";
            this.labelBugTitle.Size = new System.Drawing.Size(233, 34);
            this.labelBugTitle.TabIndex = 0;
            this.labelBugTitle.Text = "Problem Title:";
            this.labelBugTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelBugDescription
            // 
            this.labelBugDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBugDescription.ForeColor = System.Drawing.SystemColors.Control;
            this.labelBugDescription.Location = new System.Drawing.Point(12, 71);
            this.labelBugDescription.Name = "labelBugDescription";
            this.labelBugDescription.Size = new System.Drawing.Size(238, 34);
            this.labelBugDescription.TabIndex = 1;
            this.labelBugDescription.Text = "Problem Description:";
            this.labelBugDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(256, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(298, 31);
            this.textBox1.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(41, 108);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(513, 158);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // labelProblemFrequency
            // 
            this.labelProblemFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProblemFrequency.ForeColor = System.Drawing.SystemColors.Control;
            this.labelProblemFrequency.Location = new System.Drawing.Point(12, 279);
            this.labelProblemFrequency.Name = "labelProblemFrequency";
            this.labelProblemFrequency.Size = new System.Drawing.Size(238, 34);
            this.labelProblemFrequency.TabIndex = 4;
            this.labelProblemFrequency.Text = "Problem Frequency:";
            this.labelProblemFrequency.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelProblemSeverity
            // 
            this.labelProblemSeverity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProblemSeverity.ForeColor = System.Drawing.SystemColors.Control;
            this.labelProblemSeverity.Location = new System.Drawing.Point(12, 337);
            this.labelProblemSeverity.Name = "labelProblemSeverity";
            this.labelProblemSeverity.Size = new System.Drawing.Size(238, 34);
            this.labelProblemSeverity.TabIndex = 5;
            this.labelProblemSeverity.Text = "Problem Severity:";
            this.labelProblemSeverity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonSubmitBug
            // 
            this.buttonSubmitBug.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonSubmitBug.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmitBug.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSubmitBug.Location = new System.Drawing.Point(188, 399);
            this.buttonSubmitBug.Name = "buttonSubmitBug";
            this.buttonSubmitBug.Size = new System.Drawing.Size(169, 56);
            this.buttonSubmitBug.TabIndex = 6;
            this.buttonSubmitBug.Text = "Submit";
            this.buttonSubmitBug.UseVisualStyleBackColor = false;
            this.buttonSubmitBug.Click += new System.EventHandler(this.ButtonSubmitBug_Click);
            // 
            // comboBoxBugFrequency
            // 
            this.comboBoxBugFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBugFrequency.FormattingEnabled = true;
            this.comboBoxBugFrequency.Items.AddRange(new object[] {
            "Only Once",
            "Rarely",
            "Frequently",
            "Every Time"});
            this.comboBoxBugFrequency.Location = new System.Drawing.Point(256, 281);
            this.comboBoxBugFrequency.Name = "comboBoxBugFrequency";
            this.comboBoxBugFrequency.Size = new System.Drawing.Size(259, 33);
            this.comboBoxBugFrequency.TabIndex = 7;
            // 
            // comboBoxBugSeverity
            // 
            this.comboBoxBugSeverity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBugSeverity.FormattingEnabled = true;
            this.comboBoxBugSeverity.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High"});
            this.comboBoxBugSeverity.Location = new System.Drawing.Point(256, 339);
            this.comboBoxBugSeverity.Name = "comboBoxBugSeverity";
            this.comboBoxBugSeverity.Size = new System.Drawing.Size(259, 33);
            this.comboBoxBugSeverity.TabIndex = 8;
            // 
            // BugReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(598, 484);
            this.Controls.Add(this.comboBoxBugSeverity);
            this.Controls.Add(this.comboBoxBugFrequency);
            this.Controls.Add(this.buttonSubmitBug);
            this.Controls.Add(this.labelProblemSeverity);
            this.Controls.Add(this.labelProblemFrequency);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelBugDescription);
            this.Controls.Add(this.labelBugTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BugReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report a Problem";
            this.Load += new System.EventHandler(this.BugReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBugTitle;
        private System.Windows.Forms.Label labelBugDescription;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label labelProblemFrequency;
        private System.Windows.Forms.Label labelProblemSeverity;
        private System.Windows.Forms.Button buttonSubmitBug;
        private System.Windows.Forms.ComboBox comboBoxBugFrequency;
        private System.Windows.Forms.ComboBox comboBoxBugSeverity;
    }
}