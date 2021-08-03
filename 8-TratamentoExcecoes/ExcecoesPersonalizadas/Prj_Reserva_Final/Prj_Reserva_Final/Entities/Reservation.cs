using System;
using Prj_Reserva_Final.Entities.Exceptions;


namespace Prj_Reserva_Final.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {
        }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new DomainException(" Check-out date must be after check in date ");
            }
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }
        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);//Timespan= Tipo duração tempo Subtract= Tira a diferença entre um time e outro
            return (int)duration.TotalDays;
        }
        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {

            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
                throw new DomainException( "Reservation dates for update must be future dates ");// Clausula throw lança a string para o expection
            }
            if (checkOut <= checkIn)
            {
                throw new DomainException( " Check-out date must be after check in date ");
            }
            CheckIn = checkIn;
            CheckOut = checkOut;
          
        }
        public override string ToString()
        {
            return "Room "
                + RoomNumber
                + " , check-in : "
                + CheckIn.ToString("dd/MM/yyyy ")
                + CheckOut.ToString("dd/MM/yyyy ")
                + Duration()
                + " nights";
        }
    }
}