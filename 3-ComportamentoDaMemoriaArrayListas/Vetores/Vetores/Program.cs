using System;
using System.Globalization;
namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            // Em programação, vetor é o nome dado para arranjos unidimensionais
            // Arranjo é uma estrutura de dados:
            // -Homogênea(dados do mesmo tipo)
            // -Ordena( elementos acessados por meio de posições)
            // -Alocada de uma vez só, em um bloco contíguo de memória

            //Vantagens:
            // - Acesso imediato aos elementos pela sua posição
            //Desvantagens:
            // - Tamanho fixo
            // - Dificuldade para se realizar inserções e deleções

            // Problema exemplo 1
            // Fazer um programa para ler um número inteiro N e a altura de N pessoas. Armazene as N alturas em um vetor. Em seguida, mostrar
            // a altura média dessas pessoas.

            double soma=0.0;

            Console.WriteLine("Quantidade de elementos no seu vetor:");
            int n = int.Parse(Console.ReadLine());
            double[] vect = new double[n];
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"{i+1} - Digite a altura: ");
                vect[i] = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                soma += vect[i]; 
            }
            double media = soma / n;
            Console.WriteLine("Altura média é: "+media.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
