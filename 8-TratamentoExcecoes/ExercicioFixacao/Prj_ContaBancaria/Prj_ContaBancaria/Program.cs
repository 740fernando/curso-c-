using System;
using System.Globalization;
using Prj_ContaBancaria.Entities;
using Prj_ContaBancaria.Entities.Exceptions;
namespace Prj_ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Fazer um programa para ler os dados de uma conta bancária e depois realizar um
            saque nesta conta bancária, mostrando o novo saldo. Um saque não pode ocorrer
            ou se não houver saldo na conta, ou se o valor do saque for superior ao limite de
            saque da conta. Implemente a conta bancária conforme projeto abaixo:
             */
            try { 
            Console.WriteLine("Enter account data : ");
            Console.Write("Number : ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder : ");
            string holder = Console.ReadLine();
            Console.Write("Initial balance : ");
            double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Withdraw limit : ");
            double withDrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Account account = new Account(number, holder, balance, withDrawLimit);
            Console.WriteLine();
            Console.Write("Enter amount for withdraw : ");
            double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            account.WithDraw(amount);
            Console.WriteLine("New Balance : "+account.Balance.ToString("F2",CultureInfo.InvariantCulture));
            }
            catch(DomainException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine("Format Error: Input string was not in a correct format . ");
            }
  

        }
    }
}
