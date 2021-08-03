
namespace SobreposicaoPalavrasvirtualOverrideBase.Entities
{
    class SavingsAccount:Account
    { 
        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance,double interestRate):base( number,  holder,  balance)
        {
            InterestRate = interestRate;
        }
        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;

        }
        /* public override void Withdraw(double amount)// método reescrito sem a taxa de 5.0
         {
             Balance -= amount;
         }*/
        /*Palavra base
        É possível chamar a implementação da superclasse usando a palavra base.

        Exemplo: suponha que a regra para saque para conta poupança seja realizar o saque
        normalmente da superclasse (Account), e depois descontar mais 2.0.*/
        public override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 2.0;
        }
    }
}
