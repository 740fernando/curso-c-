using System;
using System.Globalization;

namespace ProgramaSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();

            Console.Write("Digite o seu nome : ");
            f.Nome = Console.ReadLine();
            Console.Write("Digite o salário bruto : ");
            f.SalarioBruto = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write(" Digite o valor do imposto : ");
            f.Imposto = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            f.SalarioLiquido();
            Console.WriteLine(f);

            Console.Write("Digite a porcentagem para aumentar o salário : ");
            double p = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f.AumentarSalario(p);
            Console.WriteLine("Dados Atualizados: "+f);
        }
    }
}
