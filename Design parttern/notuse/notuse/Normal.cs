using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notuse
{
    using System;

    // Các lớp cụ thể thực hiện việc tạo đối tượng trực tiếp
    class Program
    {
        public static void Main(string[] args)  
        {
            // Tạo đối tượng Circle
            Circle circle = new Circle();
            circle.Draw();

            // Tạo đối tượng Rectangle
            Rectangle rectangle = new Rectangle();
            rectangle.Draw();

            // Tạo đối tượng Triangle
            Triangle triangle = new Triangle();
            triangle.Draw();

            Console.ReadLine();
        }
    }

    class Circle
    {
        public void Draw()
        {
            Console.WriteLine("Vẽ hình tròn");
        }
    }

    class Rectangle
    {
        public void Draw()
        {
            Console.WriteLine("Vẽ hình chữ nhật");
        }
    }

    class Triangle
    {
        public void Draw()
        {
            Console.WriteLine("Vẽ tam giác");
        }
    }

}
