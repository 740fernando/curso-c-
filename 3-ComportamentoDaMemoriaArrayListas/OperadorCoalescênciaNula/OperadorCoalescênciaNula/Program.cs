using System;

namespace OperadorCoalescênciaNula
{
    class Program
    {
        static void Main(string[] args)
        {
            double? x = null; // variavel x do tipo double nullable
            double? y = 10; // variavel y do tipo double  nullable

            //Coalescência =Este operador é "??", vc tem uma variavel  x  do tipo double nullable. Se o valor de x não for nulo, ele jogar o valor de x.
            // mas se o valor de x for nulo, ele joga o valor da direita, ou seja, 5.
            double a = x ?? 5; // variavel a do tipo double
            double b = y??5;   // variavel b do tipo double
            Console.WriteLine(a);// exibiu o valor de 5, por x é nulo
            Console.WriteLine(b);// exibiu o valor de y, ou seja 10, pq y não é nulo
        }
    }
}
