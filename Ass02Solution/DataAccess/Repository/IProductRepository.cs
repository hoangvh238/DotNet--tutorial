using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();

        void Save(Product p);
        void Update(Product pro);
        void Delete(Product pro);
        Product GetProductByID(int id);
        IEnumerable<Product> GetProductsByName(string name);
        IEnumerable<Product> GetUnitPrice(decimal UnitPrice);
        IEnumerable<Product> GetUnitStock(int UnitStock);
    }
}
