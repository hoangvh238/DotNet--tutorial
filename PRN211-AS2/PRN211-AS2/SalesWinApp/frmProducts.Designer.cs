namespace SalesWinApp
{
    partial class frmProducts
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
            btnDelete = new System.Windows.Forms.Button();
            btnCreate = new System.Windows.Forms.Button();
            dgvProduct = new System.Windows.Forms.DataGridView();
            txtUnitPrice = new System.Windows.Forms.TextBox();
            txtUnitsInStock = new System.Windows.Forms.TextBox();
            txtProductName = new System.Windows.Forms.TextBox();
            lbUnitPrice = new System.Windows.Forms.Label();
            lbUnitsInStock = new System.Windows.Forms.Label();
            lbProductName = new System.Windows.Forms.Label();
            lbProductID = new System.Windows.Forms.Label();
            txtProductID = new System.Windows.Forms.TextBox();
            lbTitle = new System.Windows.Forms.Label();
            btnUpdate2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.BackColor = System.Drawing.Color.Red;
            btnDelete.Location = new System.Drawing.Point(80, 489);
            btnDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(117, 37);
            btnDelete.TabIndex = 30;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = System.Drawing.Color.LimeGreen;
            btnCreate.Location = new System.Drawing.Point(80, 319);
            btnCreate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new System.Drawing.Size(117, 37);
            btnCreate.TabIndex = 27;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // dgvProduct
            // 
            dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Location = new System.Drawing.Point(503, 28);
            dgvProduct.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowHeadersWidth = 51;
            dgvProduct.RowTemplate.Height = 29;
            dgvProduct.Size = new System.Drawing.Size(821, 498);
            dgvProduct.TabIndex = 26;
            dgvProduct.CellContentClick += dgvProduct_CellContentClick;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new System.Drawing.Point(192, 239);
            txtUnitPrice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new System.Drawing.Size(233, 31);
            txtUnitPrice.TabIndex = 24;
            txtUnitPrice.TextChanged += txtUnitPrice_TextChanged;
            // 
            // txtUnitsInStock
            // 
            txtUnitsInStock.Location = new System.Drawing.Point(192, 198);
            txtUnitsInStock.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtUnitsInStock.Name = "txtUnitsInStock";
            txtUnitsInStock.Size = new System.Drawing.Size(233, 31);
            txtUnitsInStock.TabIndex = 23;
            txtUnitsInStock.TextChanged += txtUnitsInStock_TextChanged;
            // 
            // txtProductName
            // 
            txtProductName.Location = new System.Drawing.Point(192, 156);
            txtProductName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new System.Drawing.Size(233, 31);
            txtProductName.TabIndex = 22;
            txtProductName.TextChanged += txtProductName_TextChanged;
            // 
            // lbUnitPrice
            // 
            lbUnitPrice.AutoSize = true;
            lbUnitPrice.Location = new System.Drawing.Point(67, 239);
            lbUnitPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbUnitPrice.Name = "lbUnitPrice";
            lbUnitPrice.Size = new System.Drawing.Size(86, 25);
            lbUnitPrice.TabIndex = 20;
            lbUnitPrice.Text = "Unit Price";
            // 
            // lbUnitsInStock
            // 
            lbUnitsInStock.AutoSize = true;
            lbUnitsInStock.Location = new System.Drawing.Point(35, 198);
            lbUnitsInStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbUnitsInStock.Name = "lbUnitsInStock";
            lbUnitsInStock.Size = new System.Drawing.Size(119, 25);
            lbUnitsInStock.TabIndex = 18;
            lbUnitsInStock.Text = "Units in Stock";
            // 
            // lbProductName
            // 
            lbProductName.AutoSize = true;
            lbProductName.Location = new System.Drawing.Point(32, 156);
            lbProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbProductName.Name = "lbProductName";
            lbProductName.Size = new System.Drawing.Size(126, 25);
            lbProductName.TabIndex = 17;
            lbProductName.Text = "Product Name";
            // 
            // lbProductID
            // 
            lbProductID.AutoSize = true;
            lbProductID.Location = new System.Drawing.Point(59, 123);
            lbProductID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbProductID.Name = "lbProductID";
            lbProductID.Size = new System.Drawing.Size(97, 25);
            lbProductID.TabIndex = 33;
            lbProductID.Text = "Product ID";
            // 
            // txtProductID
            // 
            txtProductID.Location = new System.Drawing.Point(192, 114);
            txtProductID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new System.Drawing.Size(233, 31);
            txtProductID.TabIndex = 34;
            txtProductID.TextChanged += txtProductID_TextChanged;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbTitle.Location = new System.Drawing.Point(14, 28);
            lbTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new System.Drawing.Size(439, 54);
            lbTitle.TabIndex = 35;
            lbTitle.Text = "Products Managerment";
            // 
            // btnUpdate2
            // 
            btnUpdate2.BackColor = System.Drawing.Color.Gold;
            btnUpdate2.Location = new System.Drawing.Point(80, 401);
            btnUpdate2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnUpdate2.Name = "btnUpdate2";
            btnUpdate2.Size = new System.Drawing.Size(117, 38);
            btnUpdate2.TabIndex = 36;
            btnUpdate2.Text = "Update";
            btnUpdate2.UseVisualStyleBackColor = false;
            btnUpdate2.Click += btnUpdate2_Click;
            // 
            // frmProducts
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1475, 563);
            Controls.Add(btnUpdate2);
            Controls.Add(lbTitle);
            Controls.Add(txtProductID);
            Controls.Add(lbProductID);
            Controls.Add(btnDelete);
            Controls.Add(btnCreate);
            Controls.Add(dgvProduct);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtUnitsInStock);
            Controls.Add(txtProductName);
            Controls.Add(lbUnitPrice);
            Controls.Add(lbUnitsInStock);
            Controls.Add(lbProductName);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "frmProducts";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmProducts";
            Load += frmProducts_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtUnitsInStock;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lbUnitPrice;
        private System.Windows.Forms.Label lbUnitsInStock;
        private System.Windows.Forms.Label lbProductName;
        private System.Windows.Forms.Label lbProductID;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnUpdate2;
    }
}