using System;
using SobreposicaoPalavrasvirtualOverrideBase.Entities;
namespace SobreposicaoPalavrasvirtualOverrideBase
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sobreposição ou sobrescrita

            //É a implementação de um método de uma superclasse na subclasse

            // Para q um método comum( não abstrato) possa ser sobreposto, deve ser incluído nele o prefixo "virtual"

            // Ao sobrescrever um método, devemos incluir nele o prefixo "override"

            /*
             * Suponha as seguintes regras para saque:
                                           
                • Conta comum: é cobrada uma taxa no valor de 5.00.
                • Conta poupança: não é cobrada taxa.

            Como resolver isso?

            Resposta: sobrescrevendo o método withdraw na subclasse   SavingsAccount*/
            /*Palavra base
           É possível chamar a implementação da superclasse usando a palavra base.

           Exemplo: suponha que a regra para saque para conta poupança seja realizar o saque
           normalmente da superclasse (Account), e depois descontar mais 2.0.*/




            Account acc1 = new Account(1001, "Alex", 500.00);
            Account acc2 = new SavingsAccount(1002, "Ana", 500.0, 0.01);
            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);
            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
        }
    }
}
