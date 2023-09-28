using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory
{

    // Interface cho các loại hình học
    public interface IShape
    {
        void Draw();
    }


    // Các lớp cụ thể thực hiện interface IShape
    class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Vẽ hình tròn");
        }
    }

    class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Vẽ hình chữ nhật");
        }
    }

    class Triangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Vẽ tam giác");
        }
    }

    // Factory class để tạo đối tượng dựa trên thông số đầu vào
    abstract class ShapeFactory
    {
        public abstract IShape CreateShape();
    }


    // object factory
    class CricleFactory : ShapeFactory
    {
        public override IShape CreateShape() => new Circle();
    }
    class TriangleFactory : ShapeFactory
    {
        public override IShape CreateShape() => new Triangle();
    }
    class RactangleFactory : ShapeFactory
    {
        public override IShape CreateShape() => new Rectangle();
    }
    class Program
    {
        static void Main(string[] args) 
        {
            List<ShapeFactory> shapeFactories = new List<ShapeFactory>
            {
                new CricleFactory(),
                new TriangleFactory(),
                new RactangleFactory(),
            };

            foreach (var shapeFactory in shapeFactories) {
                shapeFactory.CreateShape().Draw();
            }
        }
    }

}
