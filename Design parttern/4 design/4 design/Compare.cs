using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_design
{
    class Program
    {
        static void Main(string[] args)
        {
            // Factory Method Demo
            IProductFactory factory = new ConcreteProductFactory();
            IProduct product = factory.CreateProduct();
            product.DisplayInfo();

            // Prototype Demo
            ConcretePrototype original = new ConcretePrototype("Original");
            ConcretePrototype clone = original.Clone() as ConcretePrototype;
            clone.Name = "Cloned";
            Console.WriteLine($"Original: {original.Name}");
            Console.WriteLine($"Clone: {clone.Name}");

            // Singleton Demo
            Singleton instance1 = Singleton.GetInstance();
            Singleton instance2 = Singleton.GetInstance();
            Console.WriteLine($"Are instance1 and instance2 the same instance? {instance1 == instance2}");

            // Builder Demo
            Director director = new Director();
            IBuilder builder = new ConcreteBuilder();
            director.Construct(builder);
            Product builtProduct = builder.GetResult();
            Console.WriteLine($"Product Parts: {builtProduct.Part1}, {builtProduct.Part2}, {builtProduct.Part3}");

            Console.ReadLine();
        }
    }

    // Factory Method
    interface IProduct
    {
        void DisplayInfo();
    }

    class ConcreteProduct : IProduct
    {
        public void DisplayInfo()
        {
            Console.WriteLine("This is a concrete product.");
        }
    }

    interface IProductFactory
    {
        IProduct CreateProduct();
    }

    class ConcreteProductFactory : IProductFactory
    {
        public IProduct CreateProduct()
        {
            return new ConcreteProduct();
        }
    }

    // Prototype
    interface IPrototype
    {
        IPrototype Clone();
    }

    class ConcretePrototype : IPrototype
    {
        public string Name { get; set; }

        public ConcretePrototype(string name)
        {
            Name = name;
        }

        public IPrototype Clone()
        {
            return new ConcretePrototype(Name);
        }
    }

    // Singleton
    class Singleton
    {
        private static Singleton instance;

        private Singleton() { }

        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }

    // Builder
    class Product
    {
        public string Part1 { get; set; }
        public string Part2 { get; set; }
        public string Part3 { get; set; }
    }

    interface IBuilder
    {
        void BuildPart1();
        void BuildPart2();
        void BuildPart3();
        Product GetResult();
    }

    class ConcreteBuilder : IBuilder
    {
        private Product product = new Product();

        public void BuildPart1()
        {
            product.Part1 = "Part 1 built.";
        }

        public void BuildPart2()
        {
            product.Part2 = "Part 2 built.";
        }

        public void BuildPart3()
        {
            product.Part3 = "Part 3 built.";
        }

        public Product GetResult()
        {
            return product;
        }
    }

    class Director
    {
        public void Construct(IBuilder builder)
        {
            builder.BuildPart1();
            builder.BuildPart2();
            builder.BuildPart3();
        }
    }

}
