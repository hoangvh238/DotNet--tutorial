namespace SalesWinApp
{
    partial class frmMain
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
            btnUserManager = new Button();
            btnProductManager = new Button();
            btnOrderManager = new Button();
            SuspendLayout();
            // 
            // btnUserManager
            // 
            btnUserManager.Location = new Point(280, 178);
            btnUserManager.Name = "btnUserManager";
            btnUserManager.Size = new Size(234, 29);
            btnUserManager.TabIndex = 0;
            btnUserManager.Text = "User Manager";
            btnUserManager.UseVisualStyleBackColor = true;
            // 
            // btnProductManager
            // 
            btnProductManager.Location = new Point(280, 237);
            btnProductManager.Name = "btnProductManager";
            btnProductManager.Size = new Size(234, 29);
            btnProductManager.TabIndex = 1;
            btnProductManager.Text = "Product Manager";
            btnProductManager.UseVisualStyleBackColor = true;
            // 
            // btnOrderManager
            // 
            btnOrderManager.Location = new Point(280, 294);
            btnOrderManager.Name = "btnOrderManager";
            btnOrderManager.Size = new Size(234, 29);
            btnOrderManager.TabIndex = 2;
            btnOrderManager.Text = "Order Manager";
            btnOrderManager.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOrderManager);
            Controls.Add(btnProductManager);
            Controls.Add(btnUserManager);
            Name = "frmMain";
            Text = "frmMain";
            ResumeLayout(false);
        }

        #endregion

        private Button btnUserManager;
        private Button btnProductManager;
        private Button btnOrderManager;
    }
}