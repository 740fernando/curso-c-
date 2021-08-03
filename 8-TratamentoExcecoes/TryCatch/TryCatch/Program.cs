using System;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            // Estrutura de controle, para tratar as exceções

            // Bloco try- Contém o código que representa a execução normal do trecho de código que pode
            // acarretar em uma exceção

            //Bloco catch - Contém o código a ser executado caso uma excecão ocorra, deve ser especificado o tipo da exceção tratada(upcasting é permitido)

            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException)//DividedByZeroException é uma exceção mais detalhada, subclasse de Exception
            {
                Console.WriteLine("Erro : Não pode ser dividido por 0 ");//e é uma apelido da excessão, que permite chamar métodos e propriedades
            }
            catch(FormatException e)
            {
                Console.WriteLine("Format error ! "+e.Message);
            }
            /*
             * catch(Exception e) { // Exception - pega todo tipo de excecão
                Console.WriteLine("Erro : "+e.Message);//e é uma apelido da exceção, que permite chamar métodos e propriedades
            }*/
        }
    }
}
