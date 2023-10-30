using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ProductDAO
    {
        private static ProductDAO instance;

        private ProductDAO()
        {
        }

        public static ProductDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ProductDAO();
                }
                return instance;
            }
        }

        public IEnumerable<Product> GetProducts()
        {
            try
            {
                using (var context = new FstoreContext())
                {
                    IEnumerable<Product> products = context.Products.ToList();
                    return products;
                }
            }   
            catch(Exception ex)
            {
                throw new Exception("Error Get prouducts list :" + ex.Message);
            }
        }

        public void AddProduct(Product product)
        {
            try
            {
                using (var context = new FstoreContext())
                {
                    context.Products.Add(product);
                    context.SaveChanges();
                }
            }
            catch(Exception ex)
            {
                throw new Exception("Error when Add new product"+ex.Message);
            }
        }

        public void DeleteProduct(Product product)
        {
            try
            {
                using(var context = new FstoreContext())
                {
                    context.Products.Remove(product);
                    context.SaveChanges();
                }
            }
            catch(Exception ex)
            {
                throw new Exception("Error when delete product" + ex.Message);
            }
        }

        public void UpdateProduct(Product product)
        {
            try
            {
                using (var context = new FstoreContext())
                {
                    context.Products.Update(product);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error when update product" + ex.Message);
            }
        }

        public Product GetProductById(int id)
        {
            try
            {
                using(var context = new FstoreContext())
                {
                    return context.Products.Where(pro => pro.ProductId == id).FirstOrDefault<Product>();
                }
            }
            catch(Exception ex)
            {
                throw new Exception("Error when find product by ID" + ex.Message);
            }
        }

        public IEnumerable<Product> GetProductByName(string name)
        {
            try
            {
                using(var context = new FstoreContext())
                {
                    return context.Products.ToList().FindAll(product => product.ProductName.Contains(name,StringComparison.CurrentCultureIgnoreCase));
                }
            }
            catch(Exception ex)
            {
                throw new Exception("Error when find product by Name" + ex.Message);
            }
        }

        public IEnumerable<Product> GetProductByPrice(decimal price)
        {
            try
            {
                using( var context = new FstoreContext())
                {
                    return context.Products.ToList().FindAll(product => product.UnitPrice <= price);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error when searnch by price" + ex.Message);
            }
        }

        public IEnumerable<Product> GetProductByStock(decimal stock)
        {
            try
            {
                using(var context = new FstoreContext())
                {
                    return context.Products.ToList().FindAll(product => product.UnitslnStock < stock);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error when search by stock"+ex.Message);
            }
        }
            

    }


}
