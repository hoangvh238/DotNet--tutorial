using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class OrderDAO
    {
        private static OrderDAO instance;   
        public static OrderDAO Instance
        {
            get
            {
                if(instance == null) return new OrderDAO(); 
                return instance;
            }
        }

        public OrderDAO() { }

        public Order GetOrderById(decimal id)
        {
            try
            {
                using(var context = new FstoreContext())
                {
                    return context.Orders.ToList().FirstOrDefault(order => order.OrderId == id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error when get oder by id" + ex.Message);
            }
        }

        public List<Order> GetOrders()
        {
            try
            {
                using( var context = new FstoreContext())
                {
                    return context.Orders.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error when get list order"+ ex.Message);
            }
        }

        public void Add(Order order)
        {
            try
            {
                using(var context = new FstoreContext())
                {
                    context.Orders.Add(order);
                    context.SaveChanges();
                }
            }
            catch(Exception ex)
            {
                throw new Exception("Error when add order" + ex.Message);
            }
        }

        public void Update(Order order)
        {
            try
            {
                using (var context = new FstoreContext())
                {
                    context.Orders.Update(order);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error when Update order" + ex.Message);
            }
        }

        public void Delete(Order order)
        {
            try
            {
                using (var context = new FstoreContext())
                {
                    context.Orders.Remove(order);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error when Delete order" + ex.Message);
            }
        }

        public IEnumerable<Order> GetOrderByDate(DateTime from,DateTime end)
        {
            try
            {
                using(var context = new FstoreContext())
                {
                    return context.Orders.ToList().FindAll(order => order.RequiredDate <= end && order.RequiredDate >= from);
                }
            }
            catch(Exception ex)
            {
                throw new Exception("Error when get order by date" + ex.Message);
            }
        }
    }
}
