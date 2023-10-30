using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class OderDetailDAO
    {
        private static OderDetailDAO instance;
        public static OderDetailDAO Instance
        {
            get
            {
                if(instance == null) return new OderDetailDAO();
                else return instance;
            }
        }

        public OderDetailDAO() { }

        public IEnumerable<OrderDetail> GetOrderDetails ()
        {
            try
            {
                using(var context = new FstoreContext())
                {
                    return context.OrderDetails.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error when get list order detail" + ex.Message);
            }
        }

        public void Delete(OrderDetail orderDetail)
        {
            try
            {
                using(var context = new FstoreContext())
                {
                    context.OrderDetails.Remove(orderDetail);
                    context.SaveChanges();
                }
            }
            catch(Exception ex) 
            {
                throw new Exception("Error when delete order detail" + ex.Message);
            }
        }

        public void Update(OrderDetail orderDetail) 
        {
            try
            {
                using(var context = new FstoreContext())
                {
                    context.OrderDetails.Update(orderDetail);
                    context.SaveChanges();
                }
            }
            catch(Exception ex) 
            {
                throw new Exception("Error when update order detail" + ex.Message);
            }
        }

        public void Add(OrderDetail orderDetail)
        {
            try
            {
                using(var context = new FstoreContext())
                {
                    context.OrderDetails.Add(orderDetail);
                    context.SaveChanges();  
                }
            }
            catch(Exception ex)
            {
                throw new Exception("Error when add order detail" + ex.Message);
            }
        }
    }
}
