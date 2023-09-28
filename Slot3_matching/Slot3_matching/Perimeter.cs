using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot3_matching
{
    internal class Perimeter
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length ");
            Console.WriteLine("Enter width  ");
            float.TryParse(Console.ReadLine(), out float length);
            float.TryParse(Console.ReadLine(), out float width);

            (float perimeter, float area, float smaller) value = Calulate(length,width);

             (float perimeter , float area,float smaller ) Calulate(float length , float width) {
                return ((length + width) / 2, length * width , Math.Min(width, length) );
            }

            Console.WriteLine($"value area is {value.area}");
            Console.WriteLine($"value perimater {value.perimeter}");
            Console.WriteLine($"value min is {value.smaller}");
        }
    }
}
