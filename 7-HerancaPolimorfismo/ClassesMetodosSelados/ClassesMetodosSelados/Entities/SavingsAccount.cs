using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesMetodosSelados.Entities
{
    //sealed class SavingsAccount: Account //sealed : evita que a classe seja herdada
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(double interestRate)
        {
            InterestRate = interestRate;
        }
        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }
        public sealed override void WithDraw(double amount) // sealed Não pode ser sobrescrita novamente em outra subclasse;
        {
            base.WithDraw(amount);
            Balance -= 2.0;
        }
    }
}
