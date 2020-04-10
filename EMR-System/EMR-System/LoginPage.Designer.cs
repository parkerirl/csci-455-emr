namespace EMR_System
{
    partial class LoginPage
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
            this.labelEmployeeId = new System.Windows.Forms.Label();
            this.labelEmployeePassword = new System.Windows.Forms.Label();
            this.textEmployeeId = new System.Windows.Forms.TextBox();
            this.textEmployeePassword = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelBadLogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelEmployeeId
            // 
            this.labelEmployeeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployeeId.ForeColor = System.Drawing.SystemColors.Control;
            this.labelEmployeeId.Location = new System.Drawing.Point(199, 149);
            this.labelEmployeeId.Name = "labelEmployeeId";
            this.labelEmployeeId.Size = new System.Drawing.Size(312, 74);
            this.labelEmployeeId.TabIndex = 0;
            this.labelEmployeeId.Text = "User ID:";
            this.labelEmployeeId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelEmployeePassword
            // 
            this.labelEmployeePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployeePassword.ForeColor = System.Drawing.SystemColors.Control;
            this.labelEmployeePassword.Location = new System.Drawing.Point(199, 270);
            this.labelEmployeePassword.Name = "labelEmployeePassword";
            this.labelEmployeePassword.Size = new System.Drawing.Size(312, 55);
            this.labelEmployeePassword.TabIndex = 1;
            this.labelEmployeePassword.Text = "Password:";
            this.labelEmployeePassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textEmployeeId
            // 
            this.textEmployeeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmployeeId.Location = new System.Drawing.Point(517, 158);
            this.textEmployeeId.Name = "textEmployeeId";
            this.textEmployeeId.Size = new System.Drawing.Size(325, 56);
            this.textEmployeeId.TabIndex = 2;
            this.textEmployeeId.TextChanged += new System.EventHandler(this.TextEmployeeId_TextChanged);
            // 
            // textEmployeePassword
            // 
            this.textEmployeePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmployeePassword.Location = new System.Drawing.Point(517, 269);
            this.textEmployeePassword.Name = "textEmployeePassword";
            this.textEmployeePassword.Size = new System.Drawing.Size(325, 56);
            this.textEmployeePassword.TabIndex = 3;
            this.textEmployeePassword.UseSystemPasswordChar = true;
            this.textEmployeePassword.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonLogin.Location = new System.Drawing.Point(367, 435);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(401, 122);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Log In";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // labelBadLogin
            // 
            this.labelBadLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBadLogin.ForeColor = System.Drawing.Color.Red;
            this.labelBadLogin.Location = new System.Drawing.Point(330, 354);
            this.labelBadLogin.Name = "labelBadLogin";
            this.labelBadLogin.Size = new System.Drawing.Size(481, 55);
            this.labelBadLogin.TabIndex = 5;
            this.labelBadLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1111, 617);
            this.Controls.Add(this.labelBadLogin);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textEmployeePassword);
            this.Controls.Add(this.textEmployeeId);
            this.Controls.Add(this.labelEmployeePassword);
            this.Controls.Add(this.labelEmployeeId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Electronic Medical Record System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEmployeeId;
        private System.Windows.Forms.Label labelEmployeePassword;
        private System.Windows.Forms.TextBox textEmployeeId;
        private System.Windows.Forms.TextBox textEmployeePassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelBadLogin;
    }
}

