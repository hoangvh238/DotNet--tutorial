namespace FPTUniversityWinApp
{
    partial class frmHome
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
            lbDocterID = new Label();
            lbDocterName = new Label();
            lbSpec = new Label();
            lbAdrr = new Label();
            txtName = new TextBox();
            cmbSpec = new ComboBox();
            txtAdr = new TextBox();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dgvDoctor = new DataGridView();
            txtDocID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvDoctor).BeginInit();
            SuspendLayout();
            // 
            // lbDocterID
            // 
            lbDocterID.AutoSize = true;
            lbDocterID.Location = new Point(204, 16);
            lbDocterID.Name = "lbDocterID";
            lbDocterID.Size = new Size(77, 20);
            lbDocterID.TabIndex = 0;
            lbDocterID.Text = "Doctor ID:";
            // 
            // lbDocterName
            // 
            lbDocterName.AutoSize = true;
            lbDocterName.Location = new Point(225, 64);
            lbDocterName.Name = "lbDocterName";
            lbDocterName.Size = new Size(56, 20);
            lbDocterName.TabIndex = 1;
            lbDocterName.Text = "Name :";
            // 
            // lbSpec
            // 
            lbSpec.AutoSize = true;
            lbSpec.Location = new Point(189, 116);
            lbSpec.Name = "lbSpec";
            lbSpec.Size = new Size(105, 20);
            lbSpec.TabIndex = 2;
            lbSpec.Text = "Specialzation :";
            // 
            // lbAdrr
            // 
            lbAdrr.AutoSize = true;
            lbAdrr.Location = new Point(225, 174);
            lbAdrr.Name = "lbAdrr";
            lbAdrr.Size = new Size(69, 20);
            lbAdrr.TabIndex = 3;
            lbAdrr.Text = "Address :";
            // 
            // txtName
            // 
            txtName.Location = new Point(342, 73);
            txtName.Name = "txtName";
            txtName.Size = new Size(291, 27);
            txtName.TabIndex = 5;
            // 
            // cmbSpec
            // 
            cmbSpec.FormattingEnabled = true;
            cmbSpec.Location = new Point(342, 126);
            cmbSpec.Name = "cmbSpec";
            cmbSpec.Size = new Size(291, 28);
            cmbSpec.TabIndex = 6;
            cmbSpec.SelectedIndexChanged += txtSpec_SelectedIndexChanged;
            // 
            // txtAdr
            // 
            txtAdr.Location = new Point(342, 174);
            txtAdr.Name = "txtAdr";
            txtAdr.Size = new Size(291, 27);
            txtAdr.TabIndex = 7;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(173, 409);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(94, 29);
            btnInsert.TabIndex = 8;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(386, 409);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(565, 409);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvDoctor
            // 
            dgvDoctor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDoctor.Location = new Point(173, 228);
            dgvDoctor.Name = "dgvDoctor";
            dgvDoctor.RowHeadersWidth = 51;
            dgvDoctor.RowTemplate.Height = 29;
            dgvDoctor.Size = new Size(486, 175);
            dgvDoctor.TabIndex = 11;
            dgvDoctor.CellContentClick += dgvDoctor_CellContentClick;
            // 
            // txtDocID
            // 
            txtDocID.Location = new Point(342, 16);
            txtDocID.Name = "txtDocID";
            txtDocID.Size = new Size(125, 27);
            txtDocID.TabIndex = 12;
            txtDocID.TextChanged += txtDocID_TextChanged;
            // 
            // frmHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtDocID);
            Controls.Add(dgvDoctor);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(txtAdr);
            Controls.Add(cmbSpec);
            Controls.Add(txtName);
            Controls.Add(lbAdrr);
            Controls.Add(lbSpec);
            Controls.Add(lbDocterName);
            Controls.Add(lbDocterID);
            Name = "frmHome";
            Text = "frmHome";
            Load += frmHome_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDoctor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbDocterID;
        private Label lbDocterName;
        private Label lbSpec;
        private Label lbAdrr;
        private TextBox txtID;
        private TextBox txtName;
        private ComboBox cmbSpec;
        private TextBox txtAdr;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dgvDoctor;
        private TextBox txtDocID;
    }
}