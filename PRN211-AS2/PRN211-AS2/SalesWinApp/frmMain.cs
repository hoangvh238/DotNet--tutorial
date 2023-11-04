using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            string role = SessionManager.Instance.Get("role") as string;

            if (role == "admin")
            {
                btnProduct.Enabled = true;
               
            }
            else
            {
                btnProduct.Hide();
                btnMember.Text = "My information";
                return;
            }

        }

        private void btnProduct_Click(object sender, EventArgs e)
        {



            frmProducts frmProducts = new frmProducts();
            frmProducts.MdiParent = this;


            int xOffset = 20;
            int yOffset = 20;
            frmProducts.Location = new Point(xOffset, yOffset);

            xOffset += 20;
            yOffset += 20;

            frmProducts.Show();
        }


        private void btnMember_Click(object sender, EventArgs e)
        {

            frmMember frmMember = new frmMember();
            frmMember.MdiParent = this;



            int xOffset = 20;
            int yOffset = 20;
            frmMember.Location = new Point(xOffset, yOffset);

            xOffset += 20;
            yOffset += 20;

            frmMember.Show();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            frmOrder frmOrder = new frmOrder();
            frmOrder.MdiParent = this;


            int xOffset = 100;
            int yOffset = 100;
            frmOrder.Location = new Point(xOffset, yOffset);

            xOffset += 20;
            yOffset += 20;

            frmOrder.Show(); ;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frmLogin = new frmLogin(); 
            frmLogin.ShowDialog();
            this.Close();
        }
    }
}
