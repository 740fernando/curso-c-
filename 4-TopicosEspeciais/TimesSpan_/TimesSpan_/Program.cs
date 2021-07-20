using System;

namespace TimesSpan_
{
    class Program
    {
        //Um objeto TimeSpan internamente armazena uma duração na forma de ticks(100 NANOSEGUDOS
        static void Main(string[] args)
        {
            // 
            Console.WriteLine(" Se você iniciar um objeto TimeSpan sem argumentos, ele terá valor nulo");
            TimeSpan t2 = new TimeSpan();
            Console.WriteLine(t2);
            Console.WriteLine();


            Console.WriteLine("Fazer um objeto TimeSpan com 1 construtores de 3 argumentos : hora, minuto e segundo");
            TimeSpan t1 = new TimeSpan(0, 1, 30);
            Console.WriteLine(t1);
            Console.WriteLine();

            Console.WriteLine("Método Ticks: Exibe o valor em nano segundos");
            Console.WriteLine(t1.Ticks);
            Console.WriteLine();



            Console.WriteLine("Argumento de 90000000L nanosegundo");
            TimeSpan t3 = new TimeSpan(900000000L);
            Console.WriteLine(t3);
            Console.WriteLine();

            Console.WriteLine(" 4 argumentos : dias, Hora, minuto e segundos ");
            TimeSpan t4 = new TimeSpan(1, 2, 11, 21);
            Console.WriteLine(t4);
            Console.WriteLine();

            Console.WriteLine(" 5 argumentos : dias, Hora, minuto,segundos e milesegundos ");
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);
            Console.WriteLine(t5);
            Console.WriteLine();

            Console.WriteLine("O médoto 'from' permite executar o código a partir de unidade de medida personalizada e aceita núm double");
            Console.WriteLine();

            Console.WriteLine(" Método 'FromDays' - Utiliza a  unidade Dia como passagem de parametro ");
            TimeSpan t6 = TimeSpan.FromDays(1.5);
            Console.WriteLine(t6);
            Console.WriteLine();

            Console.WriteLine("Método 'FromHours' - Utiliza a  unidade hora como passagem de parametro");
            TimeSpan t7 = TimeSpan.FromHours(1.5);
            Console.WriteLine(t7);
            Console.WriteLine();

            Console.WriteLine("Método 'FromMinutes' - Utiliza a  unidade minuto como passagem de parametro");
            TimeSpan t8 = TimeSpan.FromMinutes(1.5);
            Console.WriteLine(t8);
            Console.WriteLine();

            Console.WriteLine("Método 'FromSeconds' - Utiliza a  unidade segundo como passagem de parametro");
            TimeSpan t9 = TimeSpan.FromSeconds(1.5);
            Console.WriteLine(t9);
            Console.WriteLine();

            Console.WriteLine("Método 'FromMilliseconds' - Utiliza a  unidade milisegundo como passagem de parametro");
            TimeSpan t10 = TimeSpan.FromMilliseconds(1.5);
            Console.WriteLine(t10);
            Console.WriteLine();

            Console.WriteLine("Método 'FromTicks' - Utiliza a  unidade ticks como passagem de parametro");
            TimeSpan t11 = TimeSpan.FromTicks(900000000L);
            Console.WriteLine(t11);


        }
    }
}
