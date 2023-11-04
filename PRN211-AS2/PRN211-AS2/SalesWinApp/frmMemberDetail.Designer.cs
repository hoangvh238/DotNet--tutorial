namespace SalesWinApp
{
    partial class frmMemberDetail
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
            txtPassword = new System.Windows.Forms.TextBox();
            txtMemberID = new System.Windows.Forms.TextBox();
            lbMemberID = new System.Windows.Forms.Label();
            lbCompanyName = new System.Windows.Forms.Label();
            txtCmName = new System.Windows.Forms.TextBox();
            txtCountry = new System.Windows.Forms.TextBox();
            txtCity = new System.Windows.Forms.TextBox();
            txtEmail = new System.Windows.Forms.TextBox();
            lbCountry = new System.Windows.Forms.Label();
            lbCategoryName = new System.Windows.Forms.Label();
            lbCity = new System.Windows.Forms.Label();
            lbEmail = new System.Windows.Forms.Label();
            btnSave = new System.Windows.Forms.Button();
            lbTitle = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(174, 259);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new System.Drawing.Size(187, 27);
            txtPassword.TabIndex = 64;
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new System.Drawing.Point(174, 94);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new System.Drawing.Size(187, 27);
            txtMemberID.TabIndex = 63;
            txtMemberID.TextChanged += txtMemberID_TextChanged;
            // 
            // lbMemberID
            // 
            lbMemberID.AutoSize = true;
            lbMemberID.Location = new System.Drawing.Point(67, 101);
            lbMemberID.Name = "lbMemberID";
            lbMemberID.Size = new System.Drawing.Size(84, 20);
            lbMemberID.TabIndex = 62;
            lbMemberID.Text = "Member ID";
            // 
            // lbCompanyName
            // 
            lbCompanyName.AutoSize = true;
            lbCompanyName.Location = new System.Drawing.Point(30, 160);
            lbCompanyName.Name = "lbCompanyName";
            lbCompanyName.Size = new System.Drawing.Size(116, 20);
            lbCompanyName.TabIndex = 61;
            lbCompanyName.Text = "Company Name";
            // 
            // txtCmName
            // 
            txtCmName.Location = new System.Drawing.Point(174, 160);
            txtCmName.Name = "txtCmName";
            txtCmName.Size = new System.Drawing.Size(187, 27);
            txtCmName.TabIndex = 60;
            // 
            // txtCountry
            // 
            txtCountry.Location = new System.Drawing.Point(174, 226);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new System.Drawing.Size(187, 27);
            txtCountry.TabIndex = 59;
            txtCountry.TextChanged += txtCountry_TextChanged;
            // 
            // txtCity
            // 
            txtCity.Location = new System.Drawing.Point(174, 193);
            txtCity.Name = "txtCity";
            txtCity.Size = new System.Drawing.Size(187, 27);
            txtCity.TabIndex = 58;
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(174, 127);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(187, 27);
            txtEmail.TabIndex = 57;
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new System.Drawing.Point(83, 226);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new System.Drawing.Size(60, 20);
            lbCountry.TabIndex = 56;
            lbCountry.Text = "Country";
            // 
            // lbCategoryName
            // 
            lbCategoryName.AutoSize = true;
            lbCategoryName.Location = new System.Drawing.Point(73, 259);
            lbCategoryName.Name = "lbCategoryName";
            lbCategoryName.Size = new System.Drawing.Size(70, 20);
            lbCategoryName.TabIndex = 55;
            lbCategoryName.Text = "Password";
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new System.Drawing.Point(109, 193);
            lbCity.Name = "lbCity";
            lbCity.Size = new System.Drawing.Size(34, 20);
            lbCity.TabIndex = 54;
            lbCity.Text = "City";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new System.Drawing.Point(100, 130);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new System.Drawing.Size(46, 20);
            lbEmail.TabIndex = 53;
            lbEmail.Text = "Email";
            // 
            // btnSave
            // 
            btnSave.BackColor = System.Drawing.Color.LimeGreen;
            btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnSave.Location = new System.Drawing.Point(100, 333);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(94, 29);
            btnSave.TabIndex = 65;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbTitle.Location = new System.Drawing.Point(30, 23);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new System.Drawing.Size(258, 46);
            lbTitle.TabIndex = 66;
            lbTitle.Text = "Member Details";
            lbTitle.Click += lbTitle_Click;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.Red;
            button1.Location = new System.Drawing.Point(241, 333);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(94, 29);
            button1.TabIndex = 67;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // frmMemberDetail
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(424, 417);
            Controls.Add(button1);
            Controls.Add(lbTitle);
            Controls.Add(btnSave);
            Controls.Add(txtPassword);
            Controls.Add(txtMemberID);
            Controls.Add(lbMemberID);
            Controls.Add(lbCompanyName);
            Controls.Add(txtCmName);
            Controls.Add(txtCountry);
            Controls.Add(txtCity);
            Controls.Add(txtEmail);
            Controls.Add(lbCountry);
            Controls.Add(lbCategoryName);
            Controls.Add(lbCity);
            Controls.Add(lbEmail);
            Name = "frmMemberDetail";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += frmMemberDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Label lbMemberID;
        private System.Windows.Forms.Label lbCompanyName;
        private System.Windows.Forms.TextBox txtCmName;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.Label lbCategoryName;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button button1;
    }
}