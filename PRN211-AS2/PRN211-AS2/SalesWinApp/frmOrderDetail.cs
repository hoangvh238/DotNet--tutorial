using DataAccess.Repository;
using BusinessObject.Models;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmOrderDetail : Form
    {
        public frmOrderDetail()
        {
            InitializeComponent();
        }
        private void ClearText()
        {
            txtOrderID.Text = "";
            txtMemberID.Text = "";
            txtFreight.Text = "";
            dtpOrderDate.Text = "";
            dtpRequireDate.Text = "";
            dtpShippedDate.Text = "";

        }
        public IOrderRepository orderRepository { get; set; }
        public IProductRepository productRepository { get; set; }
        public IOrderDetailRepository orderDetailRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public Order OrderInfor { get; set; }

        private void frmOrderDetail_Load(object sender, EventArgs e)
        {
            txtOrderID.Enabled = !InsertOrUpdate;

            if (InsertOrUpdate == true)
            {
                lbTitle.Text = "Update Order";
                txtOrderID.Text = OrderInfor.OrderId.ToString();
                txtMemberID.Text = OrderInfor.MemberId.ToString();
                dtpOrderDate.Text = OrderInfor.OrderDate.ToString();
                dtpRequireDate.Text = OrderInfor.RequiredDate.ToString();
                dtpShippedDate.Text = OrderInfor.ShippedDate.ToString();
                txtFreight.Text = OrderInfor.Freight.ToString();
            }
            else
            {
                lbTitle.Text = "Create Order";
            }

            productRepository = new ProductRepository();
            List<Product> productList = productRepository.GetProducts(); 

            cmbProduct.Items.Clear();

            
            foreach (Product product in productList)
            {
                cmbProduct.Items.Add(product.ProductName);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var o = new Order()
                {
                    OrderId = int.Parse(txtOrderID.Text),
                    MemberId = int.Parse(txtMemberID.Text),
                    OrderDate = DateTime.Parse(dtpOrderDate.Text),
                    RequiredDate = DateTime.Parse(dtpOrderDate.Text),
                    ShippedDate = DateTime.Parse(dtpOrderDate.Text),
                    Freight = int.Parse(txtFreight.Text),
                };
                if (InsertOrUpdate)
                {
                    orderRepository.UpdateOrder(o);
                }
                else
                {
                    var oD = new OrderDetail()
                    {
                        OrderId = int.Parse(txtOrderID.Text),
                        ProductId = 1,
                        UnitPrice = 10000,
                        Quantity = 1,
                        Discount = 1

    };
                    orderDetailRepository = new OrderDetailRepository();    
                    orderDetailRepository.SaveOrderDetail(oD);
                    
                    ClearText();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new member" : "Update a member");

            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();

        private void dtpOrderDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtOrderID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMemberID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}