﻿using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class OrderDAO
    {
        public static List<Order> GetOrder()
        {
            var listOrder = new List<Order>();
            try
            {
                using (var db = new SalesDBContext())
                {
                    Order order = new Order();
                    listOrder = db.Orders.ToList();
                }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            return listOrder;
        }

        public static void SaveOrder(Order o)
        {
            try
            {
                using (var Context = new SalesDBContext())
                {
                    Context.Orders.Add(o);
                    Context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static void UpdateOrder(Order o)
        {
            try
            {
                using (var Context = new SalesDBContext())
                {
                    Context.Entry<Order>(o).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    Context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static void DeleteOrder(Order o)
        {
            try
            {
                using (var Context = new SalesDBContext())
                {
                    var order = Context.Orders.SingleOrDefault(c => c.OrderId == o.OrderId);
                    Context.Orders.Remove(order);
                    Context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static Order GetOrderID(int id)
        {
            using (var db = new SalesDBContext())
            {
                Order query = db.Orders.Where(p => p.OrderId == id).FirstOrDefault<Order>();
                return query;
            }
        }

        public static List<Order> GetOrderByUserID(int id)
        {
            using(var db = new SalesDBContext())
            {
                return db.Orders.ToList().FindAll(p => p.MemberId == id);   
            }
        }

        public static List<Order> RequiredDate(DateTime date1, DateTime date2)
        {
            using (var db = new SalesDBContext())
            {
                List<Order> orderDate = new List<Order>();
                orderDate = db.Orders.ToList();
                return orderDate.FindAll(Order => Order.OrderDate <= date1 && Order.OrderDate >= date2);
            }
        }


    }
}
