using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPTUniversityConsole
{

    public class MyGenericClass<T>
    {
        private T data;



        public T Value
        {
            get => data; set => data = value;
        }

    }

    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }

        public float UnitCost { get; set; }

        public override string? ToString()
        {
            return $"ID:{ID}- Name:{Name}- Quantity:{Quantity}-Price:{UnitCost}";
        }

    }

    public class Program
    {
        public static void Main(string[] args)
        {
            MyGenericClass<int> myGenericClass = new MyGenericClass<int>
            {
                Value = 100
            };

            Console.WriteLine("Value of intObj" + myGenericClass.Value);

            MyGenericClass<string> myGenericClass1 = new MyGenericClass<string>
            {
                Value = "Hello"
            };

            Console.WriteLine("Value of stringObj" + myGenericClass1.Value);

            MyGenericClass<Product> myGenericClass2 = new MyGenericClass<Product>
            {
                Value = new Product
                {
                    ID = 1,
                    Name = "Dell",
                    Quantity = 100,
                    UnitCost = 1200.12f
                }
            };
            Console.WriteLine("Value of Product" + myGenericClass2.Value);


        }
    }

       
}