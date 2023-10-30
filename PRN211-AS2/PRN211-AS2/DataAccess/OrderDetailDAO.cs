using BusinessObject.Models;
using System.Collections.Generic;
using System;
using System.Linq;

namespace DataAccess
{
    internal class OrderDetailDAO
    {
        public static List<OrderDetail> GetOrderDetail()
        {
            var listOrderDetail = new List<OrderDetail>();
            try
            {
                using (var db = new SalesDBContext())
                {
                    OrderDetail orderdetail = new OrderDetail();
                    listOrderDetail = db.OrderDetails.ToList();
                }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            return listOrderDetail;
        }

        public static void SaveOrderDetail(OrderDetail o)
        {
            try
            {
                using (var Context = new SalesDBContext())
                {
                    Context.OrderDetails.Add(o);
                    Context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static void UpdateOrderDetail(OrderDetail o)
        {
            try
            {
                using (var Context = new SalesDBContext())
                {
                    Context.Entry<OrderDetail>(o).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    Context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static void DeleteOrderDetail(OrderDetail o)
        {
            try
            {
                using (var Context = new SalesDBContext())
                {
                    var order = Context.OrderDetails.SingleOrDefault(c => c.OrderId == o.OrderId);
                    Context.OrderDetails.Remove(order);
                    Context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static OrderDetail GetOrderIDDetail(int id)
        {
            using (var db = new SalesDBContext())
            {
                OrderDetail query = db.OrderDetails.Where(p => p.OrderId == id).FirstOrDefault<OrderDetail>();
                return query;
            }
        }

      /*  public static List<OrderDetail> RequiredDate(DateTime date1, DateTime date2)
        {
            using (var db = new SalesDBContext())
            {
                List<Order> orderDate = new List<Order>();
                orderDate = db.Orders.ToList();
                return orderDate.FindAll(Order => Order.OrderDate <= date1 && Order.OrderDate >= date2);
            }
        }
      */

    }
}
