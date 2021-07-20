using System;
using System.Globalization;

namespace DataTempo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Representa um instante; Poder ser uma data ou uma data horario
            // É um tipo valor (struct);

            // Um objeto DateTime internamente armazena: O número de "Ticks"(Unidade de medida do c# que armazena 100 nanosegundos)
            // desde a meia noite do dia 1 de janeiro do ano 1 da era comun



            // Construtores
            Console.WriteLine("Construtores: ");
            Console.WriteLine();

            DateTime d1 = new DateTime(2018, 11, 25);//ano,mes e dia
            Console.WriteLine(" D1 : " + d1);


            DateTime d2 = new DateTime(2018, 11, 25, 20, 45, 3);//anos, mes, dia, hora, minuto e segundo
            Console.WriteLine("D2 : " + d2);

            DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 3, 500);//anos, mes, dia, hora, minuto, segundo e milisegundo 
            Console.WriteLine("D3 : " + d3);//obs: essa format, n exibe milis

            //parametro que pode colocar é DateTimeKind, serve para falar se a hora é local ou global, a local tem o fuso de greenwich(gmt)
            // se vc criar uma variavel local, vai utilizar a data e a hora da sua maquina

            //builders = operações ou propriedades que irão instanciar pra vc o dateTimE
            Console.WriteLine();
            Console.WriteLine("BUILDERS BÁSICOS");
            Console.WriteLine("builders = operações ou propriedades que irão instanciar pra vc o dateTimE");
            DateTime d4 = DateTime.Now; // vai ser exibido um objeto instanciado um objeto com a data e o horario atual
            DateTime d5 = DateTime.Today;//Vai gerar a data de hoje com o horario zerado
            DateTime d6 = DateTime.UtcNow; //O horaio atual do fuso gmt
            Console.WriteLine("DATETIME.NOW : " + d4);
            Console.WriteLine("DATETIME.TODAY : " + d5);
            Console.WriteLine("DATETIME.UTCNOW : " + d6);
            Console.WriteLine();
            Console.WriteLine("TICKS: " + d1.Ticks);//Quantidade de ticks que ja passaram de 1 de janeiro a meia noite da era atual até agora.
            Console.WriteLine();
            Console.WriteLine("DATETIME.PARSE - Inserir valor ao objeto date time.parse");
            DateTime d7 = DateTime.Parse("2000-08-15");
            DateTime d8 = DateTime.Parse("2000/08/15");
            DateTime d9 = DateTime.Parse("2000/08/15 13:06:50");
            DateTime d10 = DateTime.Parse("16/06/2017 19:00");
            Console.WriteLine("D7- 2000-08-15 ");
            Console.WriteLine(d7);
            Console.WriteLine();
            Console.WriteLine("D8 2000/08/15");
            Console.WriteLine(d8);
            Console.WriteLine();
            Console.WriteLine("D9 2000/08/15 13:06:50 ");
            Console.WriteLine(d9);
            Console.WriteLine();
            Console.WriteLine("D10 16/06/2017 19:00");
            Console.WriteLine(d10);
            Console.WriteLine();
            Console.WriteLine("DATETIME.PARSEEXACT -Determina um formato de data");
            Console.WriteLine();
            DateTime d11 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d12 = DateTime.ParseExact("16/06/2021 19:00:01", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);  
            Console.WriteLine(d11);
            Console.WriteLine(d12);
        }
    }
}

