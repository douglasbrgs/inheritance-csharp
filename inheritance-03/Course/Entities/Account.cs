namespace Course.Entities
{
    internal class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }
        private const double WITHDRAWL_RATE = 5.0;

        public Account()
        {

        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        //"virtual" indica que pode ser sobrescrito em uma subclasse
        public virtual void WithDraw(double amount)
        {
            Balance -= amount + WITHDRAWL_RATE;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
