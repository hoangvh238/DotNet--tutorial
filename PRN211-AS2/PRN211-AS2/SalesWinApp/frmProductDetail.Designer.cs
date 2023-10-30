namespace SalesWinApp
{
    partial class frmProductDetail
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
            txtProductID = new System.Windows.Forms.TextBox();
            lbProductID = new System.Windows.Forms.Label();
            lbWeight = new System.Windows.Forms.Label();
            txtWeight = new System.Windows.Forms.TextBox();
            txtUnitPrice = new System.Windows.Forms.TextBox();
            txtUnitsInStock = new System.Windows.Forms.TextBox();
            txtProductName = new System.Windows.Forms.TextBox();
            lbUnitPrice = new System.Windows.Forms.Label();
            lbUnitsInStock = new System.Windows.Forms.Label();
            lbProductName = new System.Windows.Forms.Label();
            lbTitle = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            lbCategoryID = new System.Windows.Forms.Label();
            txtCategoryID = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // txtProductID
            // 
            txtProductID.Location = new System.Drawing.Point(190, 143);
            txtProductID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new System.Drawing.Size(233, 31);
            txtProductID.TabIndex = 46;
            // 
            // lbProductID
            // 
            lbProductID.AutoSize = true;
            lbProductID.Location = new System.Drawing.Point(56, 153);
            lbProductID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbProductID.Name = "lbProductID";
            lbProductID.Size = new System.Drawing.Size(97, 25);
            lbProductID.TabIndex = 45;
            lbProductID.Text = "Product ID";
            // 
            // lbWeight
            // 
            lbWeight.AutoSize = true;
            lbWeight.Location = new System.Drawing.Point(86, 227);
            lbWeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbWeight.Name = "lbWeight";
            lbWeight.Size = new System.Drawing.Size(68, 25);
            lbWeight.TabIndex = 44;
            lbWeight.Text = "Weight";
            // 
            // txtWeight
            // 
            txtWeight.Location = new System.Drawing.Point(190, 227);
            txtWeight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new System.Drawing.Size(233, 31);
            txtWeight.TabIndex = 43;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new System.Drawing.Point(190, 308);
            txtUnitPrice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new System.Drawing.Size(233, 31);
            txtUnitPrice.TabIndex = 41;
            // 
            // txtUnitsInStock
            // 
            txtUnitsInStock.Location = new System.Drawing.Point(190, 267);
            txtUnitsInStock.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtUnitsInStock.Name = "txtUnitsInStock";
            txtUnitsInStock.Size = new System.Drawing.Size(233, 31);
            txtUnitsInStock.TabIndex = 40;
            // 
            // txtProductName
            // 
            txtProductName.Location = new System.Drawing.Point(190, 185);
            txtProductName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new System.Drawing.Size(233, 31);
            txtProductName.TabIndex = 39;
            // 
            // lbUnitPrice
            // 
            lbUnitPrice.AutoSize = true;
            lbUnitPrice.Location = new System.Drawing.Point(66, 314);
            lbUnitPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbUnitPrice.Name = "lbUnitPrice";
            lbUnitPrice.Size = new System.Drawing.Size(86, 25);
            lbUnitPrice.TabIndex = 38;
            lbUnitPrice.Text = "Unit Price";
            // 
            // lbUnitsInStock
            // 
            lbUnitsInStock.AutoSize = true;
            lbUnitsInStock.Location = new System.Drawing.Point(33, 267);
            lbUnitsInStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbUnitsInStock.Name = "lbUnitsInStock";
            lbUnitsInStock.Size = new System.Drawing.Size(119, 25);
            lbUnitsInStock.TabIndex = 36;
            lbUnitsInStock.Text = "Units in Stock";
            // 
            // lbProductName
            // 
            lbProductName.AutoSize = true;
            lbProductName.Location = new System.Drawing.Point(30, 185);
            lbProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbProductName.Name = "lbProductName";
            lbProductName.Size = new System.Drawing.Size(126, 25);
            lbProductName.TabIndex = 35;
            lbProductName.Text = "Product Name";
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbTitle.Location = new System.Drawing.Point(30, 27);
            lbTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new System.Drawing.Size(292, 54);
            lbTitle.TabIndex = 67;
            lbTitle.Text = "Product Details";
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.Red;
            button1.Location = new System.Drawing.Point(282, 499);
            button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(117, 37);
            button1.TabIndex = 69;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = System.Drawing.Color.Lime;
            btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnSave.Location = new System.Drawing.Point(86, 499);
            btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(117, 37);
            btnSave.TabIndex = 68;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lbCategoryID
            // 
            lbCategoryID.AutoSize = true;
            lbCategoryID.Location = new System.Drawing.Point(45, 358);
            lbCategoryID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbCategoryID.Name = "lbCategoryID";
            lbCategoryID.Size = new System.Drawing.Size(107, 25);
            lbCategoryID.TabIndex = 70;
            lbCategoryID.Text = "Category ID";
            // 
            // txtCategoryID
            // 
            txtCategoryID.Location = new System.Drawing.Point(190, 355);
            txtCategoryID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.Size = new System.Drawing.Size(227, 31);
            txtCategoryID.TabIndex = 71;
            // 
            // frmProductDetail
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(487, 577);
            Controls.Add(txtCategoryID);
            Controls.Add(lbCategoryID);
            Controls.Add(button1);
            Controls.Add(btnSave);
            Controls.Add(lbTitle);
            Controls.Add(txtProductID);
            Controls.Add(lbProductID);
            Controls.Add(lbWeight);
            Controls.Add(txtWeight);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtUnitsInStock);
            Controls.Add(txtProductName);
            Controls.Add(lbUnitPrice);
            Controls.Add(lbUnitsInStock);
            Controls.Add(lbProductName);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "frmProductDetail";
            Text = "frmProductDetail";
            Load += frmProductDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label lbProductID;
        private System.Windows.Forms.Label lbWeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtUnitsInStock;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lbUnitPrice;
        private System.Windows.Forms.Label lbUnitsInStock;
        private System.Windows.Forms.Label lbProductName;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbCategoryID;
        private System.Windows.Forms.TextBox txtCategoryID;
    }
}