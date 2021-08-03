using System;


namespace Prj_Reserva_v2.Entities
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
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }
        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);//Timespan= Tipo duração tempo Subtract= Tira a diferença entre um time e outro
            return (int)duration.TotalDays;
        }
        public string UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            
            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
                return "Reservation dates for update must be future dates ";
            }
            if (checkOut <= checkIn)
            {
                return " Check-out date must be after check in date ";
            }
            CheckIn = checkIn;
            CheckOut = checkOut;
            return null;// O retorna nullo signica que nao houve erros
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