using System;

namespace PropriedadesOperacoesTimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Propriedades do TIMESPAN : ");
            Console.WriteLine();
            TimeSpan t1 = TimeSpan.MaxValue;
            Console.WriteLine("Duração máxima possível de ser armazena em objeto TimeSpan : "+ t1);
            Console.WriteLine();

            TimeSpan t2 = TimeSpan.MinValue;
            Console.WriteLine("Duração mínima : "+t2);
            Console.WriteLine();

            TimeSpan t3 = TimeSpan.Zero;
            Console.WriteLine("Duração ZERO : "+ t3);
            Console.WriteLine();

            TimeSpan t4 = new TimeSpan(2, 3, 5, 7, 11);
            Console.WriteLine("A data : "+ t4 + " Tem: "+t4.Days+" Dias");
            Console.WriteLine();
            Console.WriteLine("A data : " + t4 + " Tem: " + t4.Hours+ " Horas");
            Console.WriteLine();
            Console.WriteLine("A data : " + t4 + " Tem: " + t4.Minutes + " Minutos");
            Console.WriteLine();
            Console.WriteLine("A data : " + t4 + " Tem: " + t4.Seconds + " Segundos");
            Console.WriteLine();
            Console.WriteLine("A data : " + t4 + " Tem: " + t4.Ticks + " TICKS");
            Console.WriteLine();
            Console.WriteLine("TOTALDAYS : "+t4.TotalDays);
            Console.WriteLine("TOTALHOURS : " + t4.TotalHours);
            Console.WriteLine("TOTALMINUTES : " + t4.TotalMinutes);
            Console.WriteLine("TOTALSECONDS : " + t4.TotalSeconds);
            Console.WriteLine("TOTALMILLISECONDS : " + t4.TotalMilliseconds);
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Operações : ");
            Console.WriteLine();

            TimeSpan t5 = new TimeSpan(1, 30, 10);
            TimeSpan t6 = new TimeSpan(0, 10, 5);

            TimeSpan sum = t5.Add(t6);
            TimeSpan dif = t5.Subtract(t6);
            TimeSpan mult = t6.Multiply(2.0);
            TimeSpan div = t6.Divide(2.0);

            Console.WriteLine("Soma : "+sum);
            Console.WriteLine("Diferença : " + dif);
            Console.WriteLine("Multiplicação : "+mult);
            Console.WriteLine("Divisão : "+div);



        }
    }
}
