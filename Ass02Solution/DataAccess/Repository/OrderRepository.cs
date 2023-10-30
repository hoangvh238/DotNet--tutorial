using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderRepository : IOrderRepository
    {
        void IOrderRepository.Delete(Order o)
        => OrderDAO.Instance.Delete(o);

        IEnumerable<Order> IOrderRepository.GetOrder()
        => OrderDAO.Instance.GetOrders();

        Order IOrderRepository.GetOrderByID(int id)
        => OrderDAO.Instance.GetOrderById(id);

        IEnumerable<Order> IOrderRepository.GetOrdersByDate(DateTime from, DateTime end)
       => OrderDAO.Instance.GetOrderByDate(from, end);

        void IOrderRepository.Save(Order o)
        => OrderDAO.Instance.Add(o);

        void IOrderRepository.Update(Order o)
       => OrderDAO.Instance.Update(o);
    }
}
