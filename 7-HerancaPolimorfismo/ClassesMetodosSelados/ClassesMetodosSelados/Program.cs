using System;

namespace ClassesMetodosSelados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        /*Pra quê?
            • Segurança: dependendo das regras do negócio, às vezes é desejável
            garantir que uma classe não seja herdada, ou que um método não
            seja sobreposto.
            • Geralmente convém selar métodos sobrepostos, pois sobreposições múltiplas
            podem ser uma porta de entrada para inconsistências
            • Performance: atributos de tipo de uma classe selada são analisados
            de forma mais rápida em tempo de execução.
            • Exemplo clássico: string*/
    }
}
