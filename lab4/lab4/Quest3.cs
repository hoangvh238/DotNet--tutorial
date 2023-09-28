using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Product { 
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string[] Color { get; set; }
        public int Brand { get; set; }

        public Product(int id, string name, float price, string[] color, int brand)
        {
            Id = id;
            Name = name;
            Price = price;
            Color = color;
            Brand = brand;
        }

        public override string ToString() => $"{Id,3} {Name,12} {Price,5} {Brand,2} {string.Join(",",Color)}";
    }

    class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    class Shop
    {
        public static void Main(string[] args)
        {
            List<Brand> brands = new List<Brand>
        {
            new Brand { Id = 1, Name = "Brand A" },
            new Brand { Id = 2, Name = "Brand B" },
            new Brand { Id = 3, Name = "Brand C" }
        };

            List<Product> shopProducts = new List<Product>
        {
            new Product(1, "Product 1", 10.99f, new string[] { "Red", "Blue" }, 1),
            new Product(2, "Product 2", 20.49f, new string[] { "Green", "Yellow" }, 2),
            new Product(3, "Product 3", 5.99f, new string[] { "Black" }, 3),
            new Product(4, "Product 4", 15.79f, new string[] { "White", "Pink" }, 1),
            new Product(5, "Product 5", 8.29f, new string[] { "Orange" }, 2)
        };

            var mappingBrands = from p in shopProducts
                                join Brand in brands on p.Brand equals Brand.Id
                                select new { 
                                    name = p.Name,
                                    price = p.Price,
                                    brand = Brand.Name,    
                                };
            foreach( var brand in mappingBrands.OrderBy(brand => brand.price))
            {
                Console.WriteLine($"{brand.name,10} {brand.price,10} {brand.brand,7}");
            }

        }
    }

}
