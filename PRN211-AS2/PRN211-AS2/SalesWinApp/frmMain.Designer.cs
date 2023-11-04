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
            btnProduct = new System.Windows.Forms.Button();
            btnMember = new System.Windows.Forms.Button();
            btnOrder = new System.Windows.Forms.Button();
            lbTitle = new System.Windows.Forms.Label();
            btnLogout = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // btnProduct
            // 
            btnProduct.BackColor = System.Drawing.SystemColors.MenuHighlight;
            btnProduct.Location = new System.Drawing.Point(58, 195);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new System.Drawing.Size(210, 61);
            btnProduct.TabIndex = 0;
            btnProduct.Text = "Product managerment";
            btnProduct.UseVisualStyleBackColor = false;
            btnProduct.Click += btnProduct_Click;
            // 
            // btnMember
            // 
            btnMember.BackColor = System.Drawing.Color.IndianRed;
            btnMember.Location = new System.Drawing.Point(314, 195);
            btnMember.Name = "btnMember";
            btnMember.Size = new System.Drawing.Size(210, 61);
            btnMember.TabIndex = 1;
            btnMember.Text = "Member Managerment";
            btnMember.UseVisualStyleBackColor = false;
            btnMember.Click += btnMember_Click;
            // 
            // btnOrder
            // 
            btnOrder.BackColor = System.Drawing.Color.Yellow;
            btnOrder.Location = new System.Drawing.Point(580, 195);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new System.Drawing.Size(210, 61);
            btnOrder.TabIndex = 2;
            btnOrder.Text = "Order managerment";
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += btnOrder_Click;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbTitle.Location = new System.Drawing.Point(330, 22);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new System.Drawing.Size(191, 46);
            lbTitle.TabIndex = 67;
            lbTitle.Text = "Main Menu";
            // 
            // btnLogout
            // 
            btnLogout.Location = new System.Drawing.Point(370, 347);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new System.Drawing.Size(94, 29);
            btnLogout.TabIndex = 69;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(854, 450);
            Controls.Add(btnLogout);
            Controls.Add(lbTitle);
            Controls.Add(btnOrder);
            Controls.Add(btnMember);
            Controls.Add(btnProduct);
            IsMdiContainer = true;
            Name = "frmMain";
            Text = "frmMain";
            Load += frmMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnMember;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnLogout;
    }
}