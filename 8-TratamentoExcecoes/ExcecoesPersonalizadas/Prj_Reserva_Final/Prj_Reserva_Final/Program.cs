﻿using System;
using Prj_Reserva_Final.Entities;
using Prj_Reserva_Final.Entities.Exceptions;
namespace Prj_Reserva_Final
{
    class Program
    {
        //Solução Boa 
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room number : ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Check-in date(dd/MM/yyyy)");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy) : ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());


                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation : " + reservation);
                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation : ");
                Console.Write("Check-in date(dd/MM/yyyy)");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy) : ");
                checkOut = DateTime.Parse(Console.ReadLine());
                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine("Reservation : " + reservation);
            }
            catch(DomainException e)
            {
                Console.WriteLine("Error in reservation : "+e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine("Format Error : Input string was noit in a correct format . ");
            }
            catch(Exception e)
            {
                Console.WriteLine("Unexpected error : "e.Message);
            }
        }
    }
}