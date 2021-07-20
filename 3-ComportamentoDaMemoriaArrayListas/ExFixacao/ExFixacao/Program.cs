using System;

namespace ExFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudante[] r = new Estudante[10];
            Console.Write("How many rooms will be rented ? ");
            int n = int.Parse(Console.ReadLine());
           
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(" ");
                Console.WriteLine($"Rent #{i+1}");
                Console.Write("Digite o nome : ");
                string nome = Console.ReadLine();
                Console.Write("Digite o email : ");
                string email = Console.ReadLine();
                Console.Write("Digite o seu quarto : ");
                int q = int.Parse(Console.ReadLine());
                r [q]= new Estudante (nome,email);
            }
            Console.WriteLine();
            Console.WriteLine("Quartos ocupados: ");
            for (int i = 0; i < 10; i++)
            {
                
                if (r[i] != null)
                {
                     
                    Console.WriteLine(i + " : "+ r[i]);
                   
                }
            }
        }
    }
}
