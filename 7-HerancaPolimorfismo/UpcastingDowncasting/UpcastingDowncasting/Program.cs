using System;
using UpcastingDowncasting.Entitites;

namespace UpcastingDowncasting
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Fao", 0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0, 500.00);

            //UPCASTING- Conversão da subclasse para superclasse
            Account acc1 = bacc;
            Console.WriteLine(acc1);
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Ana", 0.0, 0.01);

            //DOWNCASTING- Conversão da superclasse para subclasse
            BusinessAccount acc4 = (BusinessAccount)acc2;//casting
            acc4.Loan(100.0);
            //acc2.Loan(100.00); Erro - Não aceita esse esse método, porque o objeto é do tipo Account
            //BusinessAccount acc5 = (BusinessAccount)acc3; Ocorrerá um erro pois o objeto acc3 é do tipo SavingsAccount e o objeto acc5 é BusinessAccount
            // Na verdade, o downcasting é um operação insegura, só pode ser usado quando for necessário, e testar se o objeto é instanciado de um tipo ou de outro
            if(acc3 is BusinessAccount)//se a variavel acc3 for uma instancia de BusinessAccount
            {
                
                BusinessAccount acc5 = acc3 as BusinessAccount;/// ou BusinessAccount acc5 = (BusinessAccount)acc3;
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }
            if(acc3 is SavingsAccount)
            {
                
                SavingsAccount acc5 = acc3 as SavingsAccount;//== SavingsAccount acc5 = (SavingsAccount)acc3;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
         }

        }
    }
}
