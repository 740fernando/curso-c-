using System;

namespace ModificadorParams
{
    class Program
    {
        static void Main(string[] args)
        {
            //Suponha que se queira uma calculadora para calcular a soma de uma quantidade
            //variável de valores.
            /* int s1 = Calculadora.Sum(new int []{2, 3});
            int s2 = Calculadora.Sum(new int []{2, 4, 3});*/

            //solucao certa, o params implementado na classe, faz dispensar o uso da palavra new
            int s1 = Calculadora.Sum(2, 3);
            int s2 = Calculadora.Sum(2, 4, 3);

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
