using System;
using Course.Entities;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(1001, "Alex", 500.0);
            Account acc2 = new SavingsAccount(1002, "Bob", 500.0, 0.01);

            acc1.WithDraw(10.0);
            acc2.WithDraw(10.0);

            //saque + 5.0 (taxa account)
            Console.WriteLine(acc1.Balance);

            // saque + 5.0 (taxa account) + 2.0 (taxa savings)
            Console.WriteLine(acc2.Balance);
        }
    }
}