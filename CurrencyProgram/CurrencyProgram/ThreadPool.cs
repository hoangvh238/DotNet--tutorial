using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyProgram
{
    class Printer
    {
        private object threadLock = new object();
        public void PrintNumbers()
        {
            Monitor.Enter(threadLock); 
            {
                try
                {
                    Console.WriteLine("Thread id is " + Thread.CurrentThread.ManagedThreadId);
                    for (int i = 0; i < 5; i++)
                    {
                        Random r = new Random();
                        Thread.Sleep(500 * r.Next(5));
                        Console.WriteLine("Value " + "is " + i);

                    };
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
                finally { Monitor.Exit(threadLock); }

            }
        }

        

    }

    class Test
    {   
        static void Print(object states)
        {
            Printer printer = (Printer)states;
            printer.PrintNumbers();
        }
        static void Main(string[] args)
        {
            Printer printer = new Printer();

             WaitCallback wait = new WaitCallback((object? states) =>
             {
                 if (states is Printer printer)
                 {
                     printer.PrintNumbers();
                 }
             });
            

            for (int i = 0;i < 10;i++) {
                ThreadPool.QueueUserWorkItem(wait, printer);
            };
           
        }
    }


}
