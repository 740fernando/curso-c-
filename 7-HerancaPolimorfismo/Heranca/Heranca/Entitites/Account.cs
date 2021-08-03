

namespace Heranca.Entitites
{
    class Account
    {
        public int Number { get; private set; }// private só pode acessar, não pode alterar
        public string Holder { get;private set; }
        public double Balance { get; protected set; }//protected=  Só pode alterar dentro da própria classe, ou na subclasse

        public Account()
        {
            
        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }
        public void Withdraw(double amount)
        {
            Balance -= amount;
        }
        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
