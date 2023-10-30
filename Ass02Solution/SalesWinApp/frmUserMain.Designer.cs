namespace SalesWinApp
{
    partial class frmUserMain
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
            lbUserName = new Label();
            btnUpdate = new Button();
            btnOrders = new Button();
            btnBuy = new Button();
            SuspendLayout();
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Location = new Point(344, 57);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(0, 20);
            lbUserName.TabIndex = 0;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(316, 187);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(155, 29);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update profile";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnOrders
            // 
            btnOrders.Location = new Point(316, 244);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(155, 29);
            btnOrders.TabIndex = 2;
            btnOrders.Text = "Orders Manager";
            btnOrders.UseVisualStyleBackColor = true;
            // 
            // btnBuy
            // 
            btnBuy.Location = new Point(316, 305);
            btnBuy.Name = "btnBuy";
            btnBuy.Size = new Size(155, 29);
            btnBuy.TabIndex = 3;
            btnBuy.Text = "Buy Now";
            btnBuy.UseVisualStyleBackColor = true;
            // 
            // frmUserMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBuy);
            Controls.Add(btnOrders);
            Controls.Add(btnUpdate);
            Controls.Add(lbUserName);
            Name = "frmUserMain";
            Text = "frmUserMain";
            Load += frmUserMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbUserName;
        private Button btnUpdate;
        private Button btnOrders;
        private Button btnBuy;
    }
}