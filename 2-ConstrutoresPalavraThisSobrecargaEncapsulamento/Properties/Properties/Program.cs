using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            //São definiçõesde métodos encapsulados, porém expondo uma sintaxe similar a de atributos e não métodos.
            Produto p = new Produto("TV",500.00,10);
            
            p.Nome = "TV";
            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
            Console.WriteLine(p.Quantidade);
            

        }
    }
}
