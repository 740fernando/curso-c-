using System;

namespace InferenciaDeTipoVar
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 10; // o tipo da variavel é iniciada a partir do valor, neste caso, int
            var y = 20.0;
            var z = "Maria";
            //int w = z; erro
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
        }
    }
}
