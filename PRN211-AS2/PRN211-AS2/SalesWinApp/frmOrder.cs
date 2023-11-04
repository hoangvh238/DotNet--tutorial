using BusinessObject.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmOrder : Form
    {
        IOrderRepository orderRepository = new OrderRepository();
        IOrderDetailRepository orderDetailRepository = new OrderDetailRepository();

        public frmOrder()
        {
            InitializeComponent();
        }

        public void ListOrder()
        {
            var list = orderRepository.GetOrder();
            BindingSource source = new BindingSource();
            source.DataSource = list;

            dgvOrder.DataSource = null;
            dgvOrder.DataSource = list;
        }

        public void ListOrderUser()
        {
            int? id = SessionManager.Instance.Get("id") as int?;
            if (id.HasValue)
            {
                var list = orderDetailRepository.GetOrderIDDetail(id.Value);
                BindingSource source = new BindingSource();
                source.DataSource = list;
                dgvOrder.DataSource = null;
                dgvOrder.DataSource = list;
            }
           
        }

        public Order getOrder()
        {
            Order o = null;
            try
            {
                int index = dgvOrder.CurrentCell.RowIndex;
                var dummy = (Order)dgvOrder.Rows[index].DataBoundItem;
                o = orderRepository.GetOrderID(dummy.OrderId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return o;
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            string role = SessionManager.Instance.Get("role") as string;

            if (role.Equals("admin")) ListOrder();

            else
                ListOrderUser();
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Do you really want to delete this record?", "Order Management",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (d == DialogResult.Yes)
            {
                var OrderID = getOrder();
                orderRepository.DeleteOrder(OrderID);
                ListOrder();
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmOrderDetail frmOrderDetail = new frmOrderDetail
            {
                Text = "Create Order",
                InsertOrUpdate = false,
                OrderInfor = null,
                orderRepository = orderRepository,
            };
            if (frmOrderDetail.ShowDialog() == DialogResult.OK)
            {
                ListOrder();
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmOrderDetail frmOrderDetail = new frmOrderDetail
            {
                Text = "Update Order",
                InsertOrUpdate = true,
                OrderInfor = getOrder(),
                orderRepository = orderRepository,
            };
            if (frmOrderDetail.ShowDialog() == DialogResult.OK)
            {
                ListOrder();
            }
        }

        private void dgvOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
