using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOrderDetailRepository
    {
        void SaveOrderDetail(OrderDetail o);
        void UpdateOrderDetail(OrderDetail o);
        void DeleteOrderDetail(OrderDetail o);
        OrderDetail GetOrderIDDetail(int id);
        List<OrderDetail> RequiredDate(DateTime date1, DateTime date2);
        List<OrderDetail> GetOrdersByUserId(int userId);
       
    }
}
