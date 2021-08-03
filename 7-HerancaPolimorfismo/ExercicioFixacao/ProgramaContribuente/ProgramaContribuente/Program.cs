using System;
using System.Collections.Generic;
using System.Globalization;
using ProgramaContribuente.Entities;
namespace ProgramaContribuente
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contribuinte> list = new List<Contribuinte>();

            Console.Write("Enter the number of tax payers : ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Tax payer #{i + 1} data :");

                Console.Write("Pessoa Física ou Jurídica (i/c) ? : ");
                char opc = char.Parse(Console.ReadLine());
                Console.Write("Nome : ");
                string name = Console.ReadLine();
                Console.Write("Renda Anual : ");
                double rendaAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (opc == 'i')
                {
                    Console.Write("Gastos Médicos : ");
                    double gastosMedicos = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new PessoaFisica(name, rendaAnual, gastosMedicos));
                }
                else if (opc == 'c')
                {
                    Console.Write("Num de Funcionários : ");
                    int nFun = int.Parse(Console.ReadLine());
                    list.Add(new PessoaJuridica(name, rendaAnual, nFun));
                }
            }
            Console.WriteLine();
            Console.WriteLine("Imposto pago : ");
            foreach (Contribuinte contribuinte in list)
            {
                Console.WriteLine(contribuinte.Name + "  $" + contribuinte.CalculoImposto().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
