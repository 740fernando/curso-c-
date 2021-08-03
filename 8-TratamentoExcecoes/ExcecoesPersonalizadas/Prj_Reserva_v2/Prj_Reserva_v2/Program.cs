using System;
using Prj_Reserva_v2.Entities;

namespace Prj_Reserva_v2
{
    class Program
    {
        //Solução Ruim : Retorna String, A semantica da operação é prejudicada : Retornar string não tem nada haver com a atualização da reserva
        // Ainda não é possível tratar exceções em construtores
        // A lógica fica estruturada em condicionais aninhadas
        static void Main(string[] args)
        {
            Console.Write("Room number : ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Check-in date(dd/MM/yyyy)");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out date (dd/MM/yyyy) : ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());
            
            if (checkOut <= checkIn)
            {
                Console.WriteLine("Error in reservation: Check-out date must be after check-in date");
            }
            else
            {
                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation : " + reservation);
                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation : ");
                Console.Write("Check-in date(dd/MM/yyyy)");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy) : ");
                checkOut = DateTime.Parse(Console.ReadLine());
                string error = reservation.UpdateDates(checkIn, checkOut); //Se retornar alguem erro, a variavel irá armazenar
                if (error != null)
                {
                    Console.WriteLine("Error in reservation : "+error);
                }
                else
                {
                    Console.WriteLine("Reservation : " + reservation);
                }
            }

        }
    }
}
