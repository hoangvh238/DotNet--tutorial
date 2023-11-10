namespace CourseApp
{
    partial class frmStudentManager
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
            label1 = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            dgvStudents = new DataGridView();
            addBtn = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            cmbCate = new ComboBox();
            cmbStudent = new ComboBox();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(333, 19);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 0;
            label1.Text = "Student Manager";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(252, 165);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(178, 27);
            txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(446, 165);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "button1";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // dgvStudents
            // 
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(129, 198);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.RowHeadersWidth = 51;
            dgvStudents.RowTemplate.Height = 29;
            dgvStudents.Size = new Size(540, 188);
            dgvStudents.TabIndex = 3;
            dgvStudents.CellContentClick += dgvStudents_CellContentClick;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(129, 415);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(94, 29);
            addBtn.TabIndex = 4;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(353, 415);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(575, 415);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(199, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(199, 98);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 8;
            // 
            // cmbCate
            // 
            cmbCate.FormattingEnabled = true;
            cmbCate.Location = new Point(485, 55);
            cmbCate.Name = "cmbCate";
            cmbCate.Size = new Size(151, 28);
            cmbCate.TabIndex = 9;
            cmbCate.SelectedIndexChanged += cmbCate_SelectedIndexChanged;
            // 
            // cmbStudent
            // 
            cmbStudent.FormattingEnabled = true;
            cmbStudent.Location = new Point(485, 98);
            cmbStudent.Name = "cmbStudent";
            cmbStudent.Size = new Size(151, 28);
            cmbStudent.TabIndex = 10;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(346, 122);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(101, 24);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // frmStudentManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox1);
            Controls.Add(cmbStudent);
            Controls.Add(cmbCate);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(addBtn);
            Controls.Add(dgvStudents);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Name = "frmStudentManager";
            Text = "frmStudentManager";
            Load += frmStudentManager_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSearch;
        private Button btnSearch;
        private DataGridView dgvStudents;
        private Button addBtn;
        private Button btnDelete;
        private Button btnUpdate;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox cmbCate;
        private ComboBox cmbStudent;
        private CheckBox checkBox1;
    }
}