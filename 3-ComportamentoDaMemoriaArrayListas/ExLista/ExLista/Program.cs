using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExLista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> list = new List<Funcionario>();

            Console.Write("Quantos colaboradores serão empregados ? ");
            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Funcionário #{i+1} ");
                Console.Write("Id : ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome : ");
                string nome = Console.ReadLine();
                Console.Write("Salario: ");
                double sal = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                list.Add(new Funcionario(id, nome, sal));
                Console.WriteLine();
            }

            Console.WriteLine(" Entre com Id do funcionario : ");
            int opc = int.Parse(Console.ReadLine());

            Funcionario f = list.Find(x => x.Id == opc);
            if (f != null)
            {
                Console.Write(" Entre com o percentual : ");
                double adj = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                f.IncreaseSalary(adj);
            }
            else
            {
                Console.WriteLine(" Código inexistente");
            }
            Console.WriteLine();
            Console.WriteLine("Dados atualizados");
            foreach (Funcionario obj in list){
                Console.WriteLine(obj);
            }  
        }
    }
}
