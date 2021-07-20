using System;
using System.Globalization;
namespace VetoresArmazenandoClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fazer um programa para ler um número inteiro N e os dados( nome e preço)
            // de N produtos, armazene os N produtos em um vetor. Em
            // seguida, mostrar o preço médio dos produtos
            double sum = 0.0;

            Console.WriteLine(" Insira quantos produtos ");
            int n = int.Parse(Console.ReadLine());

            Product[] vect = new Product[n];
            for(int i=0; i < n; i++)
            {
                Console.Write("Digite o nome do produto: ");
                string name = Console.ReadLine();
                Console.Write("Digite o preço do produto: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Product { Name = name, Price=price } ;
                sum += vect[i].Price;
            }
            double avg = sum / n;
            Console.WriteLine("Preço médio igual a : "+avg.ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}
