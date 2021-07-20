using System;

namespace RefValor
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p;
            //Console.WriteLine(p); Erro de inicialização.
            p.X = 10;
            p.Y = 20;
            Console.WriteLine(p);
            p = new Point();
            Console.WriteLine(p);
        }
    }
}
