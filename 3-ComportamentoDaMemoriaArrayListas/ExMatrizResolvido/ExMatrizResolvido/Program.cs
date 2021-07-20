using System;

namespace ExMatrizResolvido
{
    class Program
    {
        //Fazer um programa para ler um número inteiro N e uma matriz de
        //ordem N contendo números inteiros.Em seguida, mostrar a diagonal
        //principal e a quantidade de valores negativos da matriz.
        static void Main(string[] args)
        {
            Console.Write("Digite o lado da matriz quadrada : ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                Console.Write("Digite 3 numeros : ");
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Diagonal : ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        Console.Write($"MATRIZ {i} + {j} : " + mat[i, j]+ " ");
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine(" Valor menor que 0: ");
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        Console.Write($"MATRIZ {i} + {j} : " + mat[i, j]+"  ");
                        count++;
                    }
                }
            }
            Console.WriteLine(" Total de números negativos : "+count);
        }


        /*foreach (int obj in mat)
        {
            Console.Write($"{i} , {i} ");
            obj = int.Parse(Console.ReadLine());

            i++;
        }*/

    }
}
 