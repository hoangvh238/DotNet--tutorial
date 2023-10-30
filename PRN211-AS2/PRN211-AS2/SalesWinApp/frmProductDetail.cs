using BusinessObject.Models;
using DataAccess.Repository;
using System;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmProductDetail : Form
    {
        public IProductRepository PRepository { get; set; }
        public bool InsertOrUpdate { get; set; }//False: Insert, True: Update
        public Product ProductInfor { get; set; }
        public frmProductDetail()
        {
            InitializeComponent();
        }

        private void ClearText()
        {
            txtProductID.Text = "";
            txtProductName.Text = "";
            txtUnitPrice.Text = "";
            txtUnitsInStock.Text = "";
            txtWeight.Text = "";
            txtCategoryID.Text = "";

        }



        private void frmProductDetail_Load(object sender, EventArgs e)
        {

            txtProductID.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate == true)
            {
                lbTitle.Text = "Update Member";
                txtProductID.Text = ProductInfor.ProductId.ToString();
                txtProductName.Text = ProductInfor.ProductName;
                txtUnitPrice.Text = ProductInfor.UnitPrice.ToString();
                txtUnitsInStock.Text = ProductInfor.UnitsInStock.ToString();
                txtWeight.Text = ProductInfor.Weight;
                txtCategoryID.Text = ProductInfor.CategoryId.ToString();
            }
            else
            {
                lbTitle.Text = "Create Member";
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                var product = new Product()
                {
                    ProductId = int.Parse(txtProductID.Text),
                    ProductName = txtProductName.Text,
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    UnitsInStock = int.Parse(txtUnitsInStock.Text),
                    Weight = txtWeight.Text,
                    CategoryId = int.Parse(txtCategoryID.Text),
                };
                if (InsertOrUpdate)
                {
                    PRepository.UpdateProduct(product);
                }
                else
                {
                    PRepository.SaveProduct(product);
                    ClearText();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new Product" : "Update a Product");
            }
        }

        private void button1_Click(object sender, EventArgs e) => Close();


    }
}
