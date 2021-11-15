    using System;
using System.Globalization;
using ProjetoCarRental.entities;

namespace ProjetoCarRental
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do aluguel ");
            Console.WriteLine("Car model : ");
            string model = Console.ReadLine();
            Console.WriteLine("Pickup (dd/MM/yyyy HH:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.WriteLine("Return (dd/MM/yyyy HH:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            CarRental carRental = new CarRental(start,finish,new Vehicle(model));

        }
    }
}
