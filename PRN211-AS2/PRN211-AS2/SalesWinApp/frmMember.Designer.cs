namespace SalesWinApp
{
    partial class frmMember
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
            txtMemberID = new System.Windows.Forms.TextBox();
            lbMemberID = new System.Windows.Forms.Label();
            lbCompanyName = new System.Windows.Forms.Label();
            txtCmName = new System.Windows.Forms.TextBox();
            btnDelete = new System.Windows.Forms.Button();
            btnCreate = new System.Windows.Forms.Button();
            dgvMember = new System.Windows.Forms.DataGridView();
            btnUpdate1 = new System.Windows.Forms.Button();
            lbTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dgvMember).BeginInit();
            SuspendLayout();
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new System.Drawing.Point(205, 166);
            txtMemberID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new System.Drawing.Size(233, 31);
            txtMemberID.TabIndex = 51;
            txtMemberID.TextChanged += txtMemberID_TextChanged;
            // 
            // lbMemberID
            // 
            lbMemberID.AutoSize = true;
            lbMemberID.Location = new System.Drawing.Point(25, 166);
            lbMemberID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbMemberID.Name = "lbMemberID";
            lbMemberID.Size = new System.Drawing.Size(102, 25);
            lbMemberID.TabIndex = 50;
            lbMemberID.Text = "Member ID";
            // 
            // lbCompanyName
            // 
            lbCompanyName.AutoSize = true;
            lbCompanyName.Location = new System.Drawing.Point(25, 207);
            lbCompanyName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbCompanyName.Name = "lbCompanyName";
            lbCompanyName.Size = new System.Drawing.Size(141, 25);
            lbCompanyName.TabIndex = 49;
            lbCompanyName.Text = "Company Name";
            // 
            // txtCmName
            // 
            txtCmName.Location = new System.Drawing.Point(205, 207);
            txtCmName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtCmName.Name = "txtCmName";
            txtCmName.Size = new System.Drawing.Size(233, 31);
            txtCmName.TabIndex = 48;
            txtCmName.TextChanged += txtCmName_TextChanged;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = System.Drawing.Color.Red;
            btnDelete.Location = new System.Drawing.Point(167, 466);
            btnDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(117, 37);
            btnDelete.TabIndex = 47;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = System.Drawing.Color.LimeGreen;
            btnCreate.Location = new System.Drawing.Point(167, 315);
            btnCreate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new System.Drawing.Size(127, 37);
            btnCreate.TabIndex = 44;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // dgvMember
            // 
            dgvMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMember.Location = new System.Drawing.Point(592, 31);
            dgvMember.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dgvMember.Name = "dgvMember";
            dgvMember.RowHeadersWidth = 51;
            dgvMember.RowTemplate.Height = 29;
            dgvMember.Size = new System.Drawing.Size(719, 517);
            dgvMember.TabIndex = 43;
            dgvMember.CellContentClick += dgvMember_CellContentClick;
            // 
            // btnUpdate1
            // 
            btnUpdate1.BackColor = System.Drawing.Color.Gold;
            btnUpdate1.Location = new System.Drawing.Point(167, 393);
            btnUpdate1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnUpdate1.Name = "btnUpdate1";
            btnUpdate1.Size = new System.Drawing.Size(117, 38);
            btnUpdate1.TabIndex = 52;
            btnUpdate1.Text = "Update";
            btnUpdate1.UseVisualStyleBackColor = false;
            btnUpdate1.Click += btnUpdate1_Click;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbTitle.Location = new System.Drawing.Point(167, 49);
            lbTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new System.Drawing.Size(173, 54);
            lbTitle.TabIndex = 68;
            lbTitle.Text = "Member";
            // 
            // frmMember
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1339, 563);
            Controls.Add(lbTitle);
            Controls.Add(btnUpdate1);
            Controls.Add(txtMemberID);
            Controls.Add(lbMemberID);
            Controls.Add(lbCompanyName);
            Controls.Add(txtCmName);
            Controls.Add(btnDelete);
            Controls.Add(btnCreate);
            Controls.Add(dgvMember);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "frmMember";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmMember";
            Load += frmMember_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMember).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Label lbMemberID;
        private System.Windows.Forms.Label lbCompanyName;
        private System.Windows.Forms.TextBox txtCmName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.DataGridView dgvMember;
        private System.Windows.Forms.Button btnUpdate1;
        private System.Windows.Forms.Label lbTitle;
    }
}