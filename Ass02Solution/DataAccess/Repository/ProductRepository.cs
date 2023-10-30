using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class ProductRepository : IProductRepository
    {
        void IProductRepository.Delete(Product pro)
       => ProductDAO.Instance.DeleteProduct(pro);

        Product IProductRepository.GetProductByID(int id)
        => ProductDAO.Instance.GetProductById(id);

        IEnumerable<Product> IProductRepository.GetProducts()
        => ProductDAO.Instance.GetProducts();

        IEnumerable<Product> IProductRepository.GetProductsByName(string name)
       => ProductDAO.Instance.GetProductByName(name);   

        IEnumerable<Product> IProductRepository.GetUnitPrice(decimal UnitPrice)
        => ProductDAO.Instance.GetProductByPrice(UnitPrice);    

        IEnumerable<Product> IProductRepository.GetUnitStock(int UnitStock)
        => ProductDAO.Instance.GetProductByStock(UnitStock);

        void IProductRepository.Save(Product p)
        => ProductDAO.Instance.AddProduct(p);   

        void IProductRepository.Update(Product pro)
       => ProductDAO.Instance.UpdateProduct(pro);
    }
}
