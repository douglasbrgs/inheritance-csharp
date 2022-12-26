namespace Course.Entities
{
    //"sealed" evita que a classe possa ser herdada
    internal sealed class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {

        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance = Balance * InterestRate;
        }

        //"override" indica que esta sobrescrevendo um método da superclasse
        //"sealed" evita que o método seja sobrescrito novamente
        public sealed override void WithDraw(double amount)
        {
            //"base" chama a implementação do método na superclasse
            base.WithDraw(amount);
            Balance -= 2.0;
        }
    }
}
