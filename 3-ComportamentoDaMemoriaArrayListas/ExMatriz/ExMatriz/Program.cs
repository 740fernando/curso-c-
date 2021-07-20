using System;

namespace ExMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor de M: ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de N: ");
            int n = int.Parse(Console.ReadLine());


            int[,] mat = new int[3, 4];


            for (int i = 0; i < m; i++)
            {
                //string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    //mat[i, j] = int.Parse(s[j]);
                    Console.Write($"{i} :  {j} : ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.Write("Digite o valor a ser encontrado : ");
            int values = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] == values)
                    {
                        Console.WriteLine($"Postion : {i} {j}");

                        if (j>0)
                        {
                            Console.WriteLine("Left : " + mat[i, j - 1]);
                        }
                         if (i>0)
                        {
                            Console.WriteLine("Up : " + mat[i-1, j ]);
                        }
                        
                        if (j<n-1)
                        {
                            Console.WriteLine("Right : " + mat[i, j+1]);
                        }
                        if (i<m-1)
                        {
                            Console.WriteLine("Down : " + mat[i + 1, j]);
                        }
                    }


                }
            }

        }
    }
}
