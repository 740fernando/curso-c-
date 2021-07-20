using System;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            //double x=null;//double é um strutct que nao aceita valor nulo
            //Nullable<double> x = null; 1º opção
            double? x =  null;// 2º opção
            double? y = 10.0;
            Console.WriteLine(x.GetValueOrDefault());// Esse método fala o seguinte, pega o valor de x ou pega o valor padrão da variavel;
            Console.WriteLine(y.GetValueOrDefault());// Pega o valor que tem ou o valor nulo
            Console.WriteLine(x.HasValue);// False- pq o x não tem valor
            Console.WriteLine(y.HasValue);// True- pq tem valor
            if(x.HasValue)
                Console.WriteLine(x.Value);// Pega o valor diretamente do x
            else
                Console.WriteLine("X is null");
            if(y.HasValue)
                Console.WriteLine(y.Value);//Pega o valor diretamente de y
            else
                Console.WriteLine("Y is null");

        }
    }
}
