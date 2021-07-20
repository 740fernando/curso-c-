using System;
using System.Globalization;
namespace ExFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.Write("Entre o número da conta : ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta : ");
            string titular = Console.ReadLine();
            Console.Write("Haverá déposito inicial (s/n) : ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S')
            {
                Console.WriteLine("Entre o valor de depósito inicial : ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depositoInicial);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }



            Console.WriteLine("Dados da Conta: ");
            Console.WriteLine(conta);
            Console.WriteLine("Entre com o valor do deposito : ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.AdicionarDeposito(quantia);
            Console.WriteLine("Dados atualizados : " + conta);
            Console.WriteLine("Entre com o valor de saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine("Dados atualizados : ");
            Console.WriteLine(conta);


        }
    }
}
