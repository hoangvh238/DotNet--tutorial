using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public delegate void Operator(int a,int b);
    
    public interface IOperator<T> 
    {
        void Add(T a,T b);
        void Sub(T a, T b);
        void Mult(T a, T b);
    }

    class MathOperations : IOperator<int>{ 
        public void Add(int a,int b) => Console.WriteLine("A+B = " + (a + b));

        public void Sub(int a, int b) => Console.WriteLine("A+B = " + (a - b));
      

        public void Mult(int a, int b) => Console.WriteLine("A+B = " + (a * b));

    }

    class Program
    {
        public static void Main(string[] args)
        {
            MathOperations mathOperations = new MathOperations();   
            Operator @operator = mathOperations.Add;
            @operator += mathOperations.Sub;
            @operator(1, 2);

        }
    }
}
