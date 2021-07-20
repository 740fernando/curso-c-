using System;
using System.Globalization;

namespace ProgramaAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();
            Console.Write("Digite o nome do aluno: ");
            a.NomeAluno = Console.ReadLine();
            Console.WriteLine("Digite as 3 notas : ");
            a.N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.N3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Nota Final " + a.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
            if (a.Aprovado())
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado!");
                Console.WriteLine("Faltaram "
                + a.NotaRestante().ToString("F2", CultureInfo.InvariantCulture) + " Pontos");
            }
        }
    }
}

