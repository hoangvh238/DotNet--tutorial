using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot3_matching
{
     class Program
    {
        static void Main(string[] args) {
            Customer customer = new Customer();
            Console.WriteLine("Enter custommer name");
            customer.Name = Console.ReadLine()!;
            Console.WriteLine("Enter custommer id");
            customer.Id = int.Parse(Console.ReadLine()!);
            customer.Print();
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Print()
        {
            Console.WriteLine($"{Id}");
            Console.WriteLine("Custommer name", this.Name);
        }
    }
}
