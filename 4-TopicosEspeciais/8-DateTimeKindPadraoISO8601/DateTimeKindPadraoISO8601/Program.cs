using System;

namespace DateTimeKindPadraoIso8601
{
    class Program
    {
        static void Main(string[] args)
        {
            //DATETIMEKIND :  Tipo enumerado especial que define 3 valores possíves para a localidade da data:
            //1)Local ( fuso horário do sistema. Exemplo : São Paulo = GMT -3
            //2) UTC ( fuso horário GMT(Greenwinch Mean Time)
            //3)Unspecified
            //Boa Pratica - Armazenar em formato UTC (texto:BD/JSon/Xml)
            //instanciar e mostrar em formato local
            // Para converter um DateTime para Local ou UTC, você deve usar : myDate.ToLocalTime() e myDate.ToUniversalTime();

            DateTime d1 = new DateTime(2021, 07, 18, 18, 07, 10, 58, DateTimeKind.Local);
            DateTime d2 = new DateTime(2021, 07, 18, 18, 07, 10, 58, DateTimeKind.Utc);
            DateTime d3 = new DateTime(2021, 07, 18, 18, 07, 10, 58);
            // d1, d2 e d3 exibirá o mesmo valor, porque foi chumbado nos 3 objetos.

            Console.WriteLine("D1 : "+d1);
            Console.WriteLine("D1 KIND : "+d1.Kind);// mostra o tipo
            Console.WriteLine("D1 TO LOCAL : "+ d1.ToLocalTime());// Não muda nada, porque ja era local
            Console.WriteLine("D1 TO UTC : "+d1.ToUniversalTime());// acrescenta 3 horas na data
            Console.WriteLine();
            
            Console.WriteLine("D2 : " + d2);
            Console.WriteLine("D2 KIND : " + d2.Kind);// mostra o tipo
            Console.WriteLine("D2 TO LOCAL : " + d2.ToLocalTime());// Volta 3 horas
            Console.WriteLine("D2 TO UTC : " + d2.ToUniversalTime());// Não muda nada, porque é global
            Console.WriteLine();

            Console.WriteLine("D3 : " + d3);
            Console.WriteLine("D3 KIND : " + d3.Kind);// mostra o tipo
            Console.WriteLine("D3 TO LOCAL : " + d3.ToLocalTime());// Reduzi 3 horas
            Console.WriteLine("D3 TO UTC : " + d3.ToUniversalTime());// acrescenta 3 horas
            Console.WriteLine();
            Console.WriteLine("PADRÃO ISO 8601");
            Console.WriteLine();
            // O mais utilizado yyyy-MM-ddTHH:mm:ssZ  
            //Z* indica que a data/hora está em UTC
            DateTime d4 = DateTime.Parse("2000-08-15 13:05:58");//Não é o mais adequado
            DateTime d5 = DateTime.Parse("2000-08-15T13:05:58Z");//Padrão ISO 8601
            Console.WriteLine(d4);
            Console.WriteLine(d5);// Exibirá com horário 10:05:48, ou seja, a data armazenada está no formatado UTC, MAS a data instaciada, por padrão
            // já adaptada para o computador do usuário
            Console.WriteLine();
            Console.WriteLine("D4 : " + d4);
            Console.WriteLine("D4 KIND : " + d4.Kind);// mostra o tipo
            Console.WriteLine("D4 TO LOCAL : " + d4.ToLocalTime());// - 3 horas
            Console.WriteLine("D4 TO UTC : " + d4.ToUniversalTime());// + 3 horas
            Console.WriteLine();
            Console.WriteLine("D5 : " + d5);
            Console.WriteLine("D5 KIND : " + d5.Kind);// Como está no formato padrão ISO 8601, o C#  automaticamente instaciou uma data Local
            Console.WriteLine("D5 TO LOCAL : " + d5.ToLocalTime());// Não muda nada, porque é local
            Console.WriteLine("D5 TO UTC : "+d5.ToUniversalTime());//+3 hroas
            Console.WriteLine();
            Console.WriteLine(d5.ToString("yyyy-MM-ddTHH:mm:ssZ"));//Está errado
            Console.WriteLine(d5.ToUniversalTime().ToString("yyyy-MM-mm:ssZ"));//Para solucionar, é necessário usar o UniversalTime()
        }
    }
}
