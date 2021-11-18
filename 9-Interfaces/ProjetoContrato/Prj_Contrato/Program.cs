using System;
using System.Globalization;

namespace Prj_Contrato
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data ");
            Console.Write("Number");
            int code = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy) : ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract Value : ");
            Double contract = Double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments : ");
            int installments = int.Parse(Console.ReadLine());


        }
    }
}
