namespace NewsWinApp
{
    partial class frmLogin
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
            btnLogin = new Button();
            lbUserName = new Label();
            lbPassword = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(378, 281);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Location = new Point(258, 157);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(93, 20);
            lbUserName.TabIndex = 1;
            lbUserName.Text = "User Name : ";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(258, 208);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(81, 20);
            lbPassword.TabIndex = 2;
            lbPassword.Text = "Password : ";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(378, 154);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(246, 27);
            txtUserName.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(378, 208);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(246, 27);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(lbPassword);
            Controls.Add(lbUserName);
            Controls.Add(btnLogin);
            Name = "frmLogin";
            Text = "frmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Label lbUserName;
        private Label lbPassword;
        private TextBox txtUserName;
        private TextBox txtPassword;
    }
}