namespace NewsWinApp
{
    partial class frmNewsDetail
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
            txtTitle = new TextBox();
            txtDepcriptions = new TextBox();
            lbCategory = new Label();
            lbTiltle = new Label();
            lbDepcription = new Label();
            label4 = new Label();
            cmbCategory = new ComboBox();
            ckbStatus = new CheckBox();
            btnUpdateOrCreate = new Button();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(375, 146);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(150, 27);
            txtTitle.TabIndex = 1;
            // 
            // txtDepcriptions
            // 
            txtDepcriptions.Location = new Point(375, 199);
            txtDepcriptions.Name = "txtDepcriptions";
            txtDepcriptions.Size = new Size(150, 27);
            txtDepcriptions.TabIndex = 2;
            // 
            // lbCategory
            // 
            lbCategory.AutoSize = true;
            lbCategory.Location = new Point(281, 100);
            lbCategory.Name = "lbCategory";
            lbCategory.Size = new Size(69, 20);
            lbCategory.TabIndex = 4;
            lbCategory.Text = "Category";
            // 
            // lbTiltle
            // 
            lbTiltle.AutoSize = true;
            lbTiltle.Location = new Point(281, 149);
            lbTiltle.Name = "lbTiltle";
            lbTiltle.Size = new Size(38, 20);
            lbTiltle.TabIndex = 5;
            lbTiltle.Text = "Title";
            // 
            // lbDepcription
            // 
            lbDepcription.AutoSize = true;
            lbDepcription.Location = new Point(281, 202);
            lbDepcription.Name = "lbDepcription";
            lbDepcription.Size = new Size(88, 20);
            lbDepcription.TabIndex = 6;
            lbDepcription.Text = "Depcription";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(281, 257);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 7;
            label4.Text = "Status";
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(374, 97);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(151, 28);
            cmbCategory.TabIndex = 8;
            // 
            // ckbStatus
            // 
            ckbStatus.AutoSize = true;
            ckbStatus.Checked = true;
            ckbStatus.CheckState = CheckState.Checked;
            ckbStatus.Location = new Point(374, 257);
            ckbStatus.Name = "ckbStatus";
            ckbStatus.Size = new Size(71, 24);
            ckbStatus.TabIndex = 9;
            ckbStatus.Text = "Status";
            ckbStatus.UseVisualStyleBackColor = true;
            // 
            // btnUpdateOrCreate
            // 
            btnUpdateOrCreate.Location = new Point(361, 358);
            btnUpdateOrCreate.Name = "btnUpdateOrCreate";
            btnUpdateOrCreate.Size = new Size(94, 29);
            btnUpdateOrCreate.TabIndex = 10;
            btnUpdateOrCreate.UseVisualStyleBackColor = true;
            btnUpdateOrCreate.Click += btnUpdateOrCreate_Click;
            // 
            // frmNewsDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUpdateOrCreate);
            Controls.Add(ckbStatus);
            Controls.Add(cmbCategory);
            Controls.Add(label4);
            Controls.Add(lbDepcription);
            Controls.Add(lbTiltle);
            Controls.Add(lbCategory);
            Controls.Add(txtDepcriptions);
            Controls.Add(txtTitle);
            Name = "frmNewsDetail";
            Text = "frmNewsDetail";
            Load += frmNewsDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox txtTitle;
        private TextBox txtDepcriptions;
        private Label lbCategory;
        private Label lbTiltle;
        private Label lbDepcription;
        private Label label4;
        private ComboBox cmbCategory;
        private CheckBox ckbStatus;
        private Button btnUpdateOrCreate;
        private ListBox listBox1;
    }
}