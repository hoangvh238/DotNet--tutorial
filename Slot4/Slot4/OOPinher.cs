using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot4
{
    internal class OOP_InherNew
    {
        abstract class Shape
        {
           public int Height
            {
                get;
                set;
            }

            public int weight
            {
                get;
                set;
            }

            public void Action()
            {
                Print();
                Display();
                Draw();
            }
            protected virtual void Draw()
            {
                Console.WriteLine("My shape is");
            }

            protected virtual void Print()
            {
                Console.WriteLine("hi");
            }

            protected abstract void Display();

            public void OK() {
                Console.WriteLine("loggg");
            }
        }

        class Cricle:Shape
        {
            protected override void Draw()
            {
                Console.WriteLine("i am cricle");
            }

            protected override void Display()
            {
                  Console.WriteLine("Print cricle");
            }

            protected override void Print()
            {
                Console.WriteLine("Print cricle");
            }

            public new void Action()
            {
                Console.WriteLine("hi");
            }

            public new void OK() { 
                Console.WriteLine("hiasdada"); 
            }

            
        }
        class Ractangle : Shape
        {
            protected override void Draw()
            {
                Console.WriteLine("i am Ractangle");
            }

            protected override void Display()
            {
                Console.WriteLine("Print Ractangle");
            }

            protected override void Print()
            {
                Console.WriteLine("Print Ractangle");
            }


        }
        
        class Program
        {
            static void Main(string[] args)
            {
                Shape cricle = new Cricle();
                cricle.Action();
                cricle.OK();
            }
        }
    }
}
