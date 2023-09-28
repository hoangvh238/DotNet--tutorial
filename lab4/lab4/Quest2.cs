using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public delegate void Banker(float blance, float value);

    class Account
    {
        event Banker blanceChange;
        public float Blance { get; set; }
       /* public void Payment(float blance, float value) => Console.WriteLine("Blance new :" + (Blance = blance - value)); */
        public void Transfer(float blance, float value) => Console.WriteLine("Blance new :" + (Blance = blance + 2*value));


        public static void Main(string[] args)
        {
            Account account = new Account();
            account.blanceChange += (float blance, float value) =>
            {
                account.Blance = blance - value;
                Console.WriteLine("Blance new :" + account.Blance);
            };
            account.blanceChange += new Banker(account.Transfer);
            account.blanceChange(1000, 100);
        }
    }
}
