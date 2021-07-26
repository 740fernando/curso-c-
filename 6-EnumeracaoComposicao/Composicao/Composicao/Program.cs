using System;
using System.Globalization;
using Composicao.Entities;
using Composicao.Entities.Enum;

namespace Composicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter  department's name : ");
            string deptname = Console.ReadLine();
            Console.WriteLine("Enter worker data : ");
            Console.Write("Name : ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/Midlevel/Senior) : ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());// Enum . parse parametrizado com WorkerLevel
            Console.Write("Base Salary : ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(deptname);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.Write("How many contracts to this worker ? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter {i} contratct data ");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours) : ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);

            }
            Console.WriteLine();
            Console.Write("Enter month and yae to calculate income (MM/YYYY)");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));// Operação Substring( Posição, recorte) vai pegar a partir da posição 0 e recortar dois pedaços{0,1}
            int year = int.Parse(monthAndYear.Substring(3));
            Console.WriteLine("Name : "+worker.Name);
            Console.WriteLine("Dep: "+ worker.Department.Name);
            Console.WriteLine("Income for "+monthAndYear + " : "+ worker.Income(year,month).ToString("F2",CultureInfo.InvariantCulture));//Exibe o valor com duas casas decimais
        }
    }
}
