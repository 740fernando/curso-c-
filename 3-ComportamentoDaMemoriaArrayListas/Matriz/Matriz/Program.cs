using System;

namespace Matriz
{
    class Program
    {
        /*Em programação, "matriz" é o nome dado a arranjos bidimensionais
            •Arranjo é uma estrutura de dados:
            •Homogênea (dados do mesmo tipo)
            •Ordenada (elementos acessados por meio de posições)
            •Alocada de uma vez só, em um bloco contíguo de memória
         Vantagens:
            •Acesso imediato aos elementos pela sua posição
         Desvantagens:
            • Tamanho fixo
            • Dificuldade para se realizar inserções e deleções
          
         */
        static void Main(string[] args)
        {
            double[,,,] mat = new double[2,3,4,5];
            Console.WriteLine(mat.Length);  //Mostra o total de elementos
            Console.WriteLine(mat.Rank);// Quantidadede linhas
            Console.WriteLine(mat.GetLength(0)); //Mostra a primeira dimensão da matriz tem tamanho 2(Mostra a quantidade de linhas)
            Console.WriteLine(mat.GetLength(1));//Mostra a segunda dimensão da matriz que tem tamanho 3(Mostra a quatidade de colunas)
            Console.WriteLine(mat.GetLength(2));
        }
    }
}
