using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOrderRepository
    {
        IEnumerable<Order> GetOrder();
        void Save(Order o);
        void Update(Order o);
        void Delete(Order o);
        Order GetOrderByID(int id);
        IEnumerable<Order> GetOrdersByDate(DateTime from, DateTime end);
    }
}
