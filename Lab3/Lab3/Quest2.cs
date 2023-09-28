using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Quest2
    {

    class Product
        {
            public string Name { get; set; }
            public double Cost { get; set; }
            public int Quantity { get; set; }

            public override string ToString()
            {
                return $"Name: {Name}, Cost: {Cost:C}, Quantity: {Quantity}";
            }
        }

    class Program
    {
        static void Main()
        {
            ArrayList productList = new ArrayList();

            productList.Add(new Product { Name = "Product 1", Cost = 10.99, Quantity = 5 });
            productList.Add(new Product { Name = "Product 2", Cost = 20.49, Quantity = 10 });
            productList.Add(new Product { Name = "Product 3", Cost = 5.99, Quantity = 3 });
            productList.Add(new Product { Name = "Product 4", Cost = 15.79, Quantity = 8 });
            productList.Add(new Product { Name = "Product 5", Cost = 8.29, Quantity = 6 });

            foreach (var product in productList)
            {
                Console.WriteLine(product);
            }
        }
    }

}
}
