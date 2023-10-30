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
            SuspendLayout();
            // 
            // btnProduct
            // 
            btnProduct.BackColor = System.Drawing.SystemColors.MenuHighlight;
            btnProduct.Location = new System.Drawing.Point(73, 244);
            btnProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new System.Drawing.Size(262, 76);
            btnProduct.TabIndex = 0;
            btnProduct.Text = "Product managerment";
            btnProduct.UseVisualStyleBackColor = false;
            btnProduct.Click += btnProduct_Click;
            // 
            // btnMember
            // 
            btnMember.BackColor = System.Drawing.Color.IndianRed;
            btnMember.Location = new System.Drawing.Point(393, 244);
            btnMember.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            btnMember.Name = "btnMember";
            btnMember.Size = new System.Drawing.Size(262, 76);
            btnMember.TabIndex = 1;
            btnMember.Text = "Member Managerment";
            btnMember.UseVisualStyleBackColor = false;
            btnMember.Click += btnMember_Click;
            // 
            // btnOrder
            // 
            btnOrder.BackColor = System.Drawing.Color.Yellow;
            btnOrder.Location = new System.Drawing.Point(725, 244);
            btnOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new System.Drawing.Size(262, 76);
            btnOrder.TabIndex = 2;
            btnOrder.Text = "Order managerment";
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += btnOrder_Click;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbTitle.Location = new System.Drawing.Point(412, 28);
            lbTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new System.Drawing.Size(226, 54);
            lbTitle.TabIndex = 67;
            lbTitle.Text = "Main Menu";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1067, 562);
            Controls.Add(lbTitle);
            Controls.Add(btnOrder);
            Controls.Add(btnMember);
            Controls.Add(btnProduct);
            Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
    }
}