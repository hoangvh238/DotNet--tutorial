using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Quest1
    {

    class Calculator<T>
        {
            public T Add(T a, T b)
            {
                dynamic x = a;
                dynamic y = b;
                return x + y;
            }

            public T Subtract(T a, T b)
            {
                dynamic x = a;
                dynamic y = b;
                return x - y;
            }

            public T Multiply(T a, T b)
            {
                dynamic x = a;
                dynamic y = b;
                return x * y;
            }

            public T Divide(T a, T b)
            {
                dynamic x = a;
                dynamic y = b;
                if (y == 0)
                {
                    throw new DivideByZeroException("Cannot divide by zero.");
                }
                return x / y;
            }
        }

    class Program
    {
        static void Main()
        {
            Calculator<int> intCalculator = new Calculator<int>();
            Console.WriteLine($"Addition: {intCalculator.Add(5, 3)}");
            Console.WriteLine($"Subtraction: {intCalculator.Subtract(5, 3)}");
            Console.WriteLine($"Multiplication: {intCalculator.Multiply(5, 3)}");
            Console.WriteLine($"Division: {intCalculator.Divide(5, 3)}");

            Calculator<double> doubleCalculator = new Calculator<double>();
            Console.WriteLine($"Addition: {doubleCalculator.Add(5.5, 3.2)}");
            Console.WriteLine($"Subtraction: {doubleCalculator.Subtract(5.5, 3.2)}");
            Console.WriteLine($"Multiplication: {doubleCalculator.Multiply(5.5, 3.2)}");
            Console.WriteLine($"Division: {doubleCalculator.Divide(5.5, 3.2)}");
        }
    }

}
}
