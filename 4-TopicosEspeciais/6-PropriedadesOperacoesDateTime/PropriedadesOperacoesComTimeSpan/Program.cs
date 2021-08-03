using System;

namespace PropriedadesOperacoesComTimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PROPRIEDADES DO DATETIME : ");
            Console.WriteLine();
            DateTime d = new DateTime(2000, 10, 15, 13, 45, 58, 275);
            Console.WriteLine(d);
            Console.WriteLine();

            Console.Write("DATE - Considera apenas a data do objeto : ");
            Console.WriteLine(d.Date);
            Console.WriteLine();

            Console.Write("DAY - Cosnidera apenas o dia do objeto : ");
            Console.WriteLine(d.Day);
            Console.WriteLine();

            Console.Write("DAYOFWEEK - ");
            Console.WriteLine(d.DayOfWeek);
            Console.WriteLine();

            Console.Write("DAYOFYEAR : ");
            Console.WriteLine(d.DayOfYear);
            Console.WriteLine();

            Console.Write("HOUR : ");
            Console.WriteLine(d.Hour);
            Console.WriteLine();

            Console.Write("KIND : TIPO LOCAL OU GLOBAL //EXIBIRÁ QUE NÃO FOI ESPECIFICADO ");
            Console.WriteLine(d.Kind);
            Console.WriteLine();

            Console.Write("MINUTE : ");
            Console.WriteLine(d.Minute);
            Console.WriteLine();

            Console.Write("MONTH : ");
            Console.WriteLine(d.Month);
            Console.WriteLine();

            Console.Write("SECOND : ");
            Console.WriteLine(d.Second);
            Console.WriteLine();

            Console.Write("TICKS : ");
            Console.WriteLine(d.Ticks);
            Console.WriteLine();

            Console.Write("TIMEOFDAY : ");
            Console.WriteLine(d.TimeOfDay);
            Console.WriteLine();

            Console.Write("YEAR : ");
            Console.WriteLine(d.Year);
            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            Console.WriteLine("FORMATAÇÃO : ");
            Console.WriteLine();
            
            Console.Write("TOLONGDATESTRING() : ");
            Console.WriteLine(d.ToLongDateString());
            Console.WriteLine();
            
            Console.Write("TOLONGTIMESTRING() : ");
            Console.WriteLine(d.ToLongTimeString());
            Console.WriteLine();

            Console.Write("TOSHORTDATESTRING() : ");
            Console.WriteLine(d.ToShortDateString());
            Console.WriteLine();

            Console.Write("TOSHORTTIMESTRING() : ");
            Console.WriteLine(d.ToShortTimeString());
            Console.WriteLine();

            Console.Write("TOSTRING() : ");
            Console.WriteLine(d.ToString());
            Console.WriteLine();

            Console.Write("TOSTRING(yyyy-MM-dd HH:mm:ss) : ");
            Console.WriteLine(d.ToString("yyyy-MM-dd HH:mm:ss"));
            Console.WriteLine();

            Console.Write("TOSTRING(yyyy-MM-dd HH:mm:ss.fff)  // mostra os milisegundos : ");
            Console.WriteLine(d.ToString("yyyy-MM-dd HH:mm:ss.fff"));
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("OPERAÇÕES");
            Console.WriteLine();

            
            Console.WriteLine("DATA : "+ d);


            DateTime d2 = d.AddHours(2);
            Console.WriteLine("Adcionando +2 HORAS : "+d2);
            Console.WriteLine("Segunda alternativa : "+d.AddHours(2));
            Console.WriteLine("Adicionando Minutos : "+d.AddMinutes(3));
            Console.WriteLine("Adicionando Meses :" + d.AddMonths(2));
            Console.WriteLine("Adicionando Segundos : "+ d.AddSeconds(30));
            Console.WriteLine();
      
            Console.WriteLine("Diferença entre datas, utliza o TimeSpan para guarda a diferença");
            DateTime d3 = new DateTime(2000, 10, 18);
            DateTime d4 = new DateTime(2000, 10, 15);
            TimeSpan t = d3.Subtract(d4);
            Console.WriteLine("A diferença é : "+t);
            





        }
    }
}
