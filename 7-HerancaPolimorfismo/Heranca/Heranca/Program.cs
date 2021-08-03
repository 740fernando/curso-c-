using System;
using Heranca.Entitites;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            // Herança - É um tipo de associação que permite que uma classe herde dados e
            //comportamentos de outra, vai permiti o reuso de atributos e métodos

            // Relação "é um"
            //Generalização/especialização
            //Superclasse(classe base)/ subclasse(classe derivada)
            //Heranção /extensão
            //Herança é uma associação entre classe ( e não entre objetos)

            Console.WriteLine(" Implemente as classes Account e BusinessAccount e fazer alguns testes ");
            Console.WriteLine();
            BusinessAccount account = new BusinessAccount(8010, "Bob Green", 100.0, 500.00);
            Console.WriteLine(account.Balance);
            //account.Balance = 200.0;=ERRO
            account.Withdraw(50);
            Console.WriteLine(account.Balance);


        }
    }
}
