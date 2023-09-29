/*using System;
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
            lock (threadLock)
            {
                try
                {
                    Console.WriteLine("Threadname is " + Thread.CurrentThread.Name);
                     for(int i = 0; i < 10; i++)
                    {
                        Random r = new Random();
                        Thread.Sleep(500 * r.Next(5));
                        Console.WriteLine("Value" + "is" + i);
                    };
                }
                catch(Exception e)
                {
                    Console.WriteLine(e);
                }

            }
        }


    }

    class Program { 
        public static void Main(string[] args) {
            Printer printer = new Printer();

            Thread[] threads = new Thread[5];

            for(int i = 0;i<5;i++)
            {
                threads[i] = new Thread(new ThreadStart(printer.PrintNumbers))
                {
                    Name = "Thread" + "at" + i
                };

            }
            
            foreach(Thread thread in threads)
            {
                thread.Start(); 
            }

        }
    }

}
*/