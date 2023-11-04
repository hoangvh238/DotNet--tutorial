using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        public void DeleteOrderDetail(OrderDetail o)
        {
            throw new NotImplementedException();
        }

        public OrderDetail GetOrderIDDetail(int id)
        {
            throw new NotImplementedException();
        }

        public List<OrderDetail> GetOrdersByUserId(int userId)
        {
            throw new NotImplementedException();
        }

        public List<OrderDetail> RequiredDate(DateTime date1, DateTime date2)
        {
            throw new NotImplementedException();
        }

        public void SaveOrderDetail(OrderDetail o)
        => OrderDetailDAO.SaveOrderDetail(o);

        public void UpdateOrderDetail(OrderDetail o)
        => OrderDetailDAO.UpdateOrderDetail(o);

    }
}
