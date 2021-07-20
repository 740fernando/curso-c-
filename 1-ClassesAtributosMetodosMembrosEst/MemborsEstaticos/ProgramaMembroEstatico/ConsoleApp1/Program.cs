using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        //static double Pi = 3.14;
        static void Main(string[] args)
        {
            Console.WriteLine("Métodos de clase");

            // Fazer um programa para ler um valor numérico qualquer, e daí mostrar
            //quanto seria o valor de uma circunferência e do volume de uma esfera
            //para um raio daquele valor. Informar também o valor de PI com duas
            //casas decimais.

            //Versão 1: métodos na própria classe do programa Nota: Dentro de um método estático você não pode chamar membros de instancia da mesma classe


            /*
                        Console.WriteLine("Entre com o valor do raio");
                        double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        double circ = Circuferencia(raio);
                        Console.WriteLine("Circunferência: "+circ);
                        double volume = Volume(raio);
                        Console.WriteLine("Volume : "+volume.ToString("F2",CultureInfo.InvariantCulture));
                        Console.WriteLine("Valor de Pi: "+Pi.ToString("F2",CultureInfo.InvariantCulture));
            */
            //Versão 2

            /*Calculadora calc = new Calculadora();

            Console.WriteLine("Entre com o valor do raio");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double circ = calc.Circuferencia(raio);
            Console.WriteLine("Circunferência: " + circ);
            double volume = calc.Volume(raio);
            Console.WriteLine("Volume : " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de Pi: " + calc.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }*/
            //final versao 2
            /*static double Circuferencia (double r) //Static-é UTILIZADO ESSE TERMO PARA PODER UTILIZAR A FUNÇÃO DENTRO DA CLASSE PRINCIPAL
            {
                return 2.0 * Pi * r;
            }
            static double Volume (double r)
            {
                return 4.0 / 3.0 * Pi * Math.Pow(r, 3);*/

            

            Console.WriteLine("Entre com o valor do raio");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double circ = Calculadora.Circuferencia(raio);
            Console.WriteLine("Circunferência: " + circ);
            double volume = Calculadora.Volume(raio);
            Console.WriteLine("Volume : " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de Pi: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }

    }

}