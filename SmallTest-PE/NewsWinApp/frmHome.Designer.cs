namespace NewsWinApp
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
            txtSearch = new TextBox();
            btnSearch = new Button();
            dgvNews = new DataGridView();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            cmbStudent = new ComboBox();
            ckbStatus = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvNews).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(133, 133);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(290, 27);
            txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(488, 131);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // dgvNews
            // 
            dgvNews.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNews.Location = new Point(40, 180);
            dgvNews.Name = "dgvNews";
            dgvNews.RowHeadersWidth = 51;
            dgvNews.RowTemplate.Height = 29;
            dgvNews.ShowCellErrors = false;
            dgvNews.Size = new Size(716, 214);
            dgvNews.TabIndex = 2;
            dgvNews.CellContentClick += dgvNews_CellContentClick;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(176, 409);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(329, 409);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(469, 409);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(133, 24);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(133, 76);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 7;
            // 
            // cmbStudent
            // 
            cmbStudent.FormattingEnabled = true;
            cmbStudent.Location = new Point(488, 23);
            cmbStudent.Name = "cmbStudent";
            cmbStudent.Size = new Size(151, 28);
            cmbStudent.TabIndex = 8;
            cmbStudent.SelectedIndexChanged += cmbStudent_SelectedIndexChanged;
            // 
            // ckbStatus
            // 
            ckbStatus.AutoSize = true;
            ckbStatus.Location = new Point(488, 66);
            ckbStatus.Name = "ckbStatus";
            ckbStatus.Size = new Size(94, 24);
            ckbStatus.TabIndex = 9;
            ckbStatus.Text = "ckbStatus";
            ckbStatus.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 31);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 10;
            label1.Text = "StudentName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 76);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 11;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 136);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 12;
            label3.Text = "label3";
            // 
            // frmHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ckbStatus);
            Controls.Add(cmbStudent);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dgvNews);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Name = "frmHome";
            Text = "frmHome";
            Load += frmHome_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNews).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearch;
        private Button btnSearch;
        private DataGridView dgvNews;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox cmbStudent;
        private CheckBox ckbStatus;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}