using Course.Entities;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(1234, "Bob Brown", 150.00, 500.00);

            account.Deposit(150.00);
            account.WithDraw(100.00);
            account.Loan(500.00);

            Console.WriteLine(account.Balance);
        }
    }
}