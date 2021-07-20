using System;

namespace ModificadoresRefeOut
{
    class Program
    {
        static void Main(string[] args)
        {

            // o modificador ref referencia a varivavel declarada no programa principal
            /*
            int a = 10;
            Calculator.Triple(ref a);
            Console.WriteLine(a);
             */
            //O modificador out é similar ao ref (faz o parâmetro ser uma referência para a variável
            //original), mas não exige que a variável original seja iniciada.
            int a = 10;
            int triple;
            Calculator.Triple(a, out triple);//parametro de saida
            Console.WriteLine(triple);

            //• Diferença:
            //• A variável passada como parâmetro ref DEVE ter sido iniciada
            //• A variável passada como parâmetro out não precisa ter sido iniciada
            //• Conclusão: ambos são muito similares, mas ref é uma forma de fazer
            //o compilador obrigar o usuário a iniciar a variável.
            //• Nota: ambos são considerados "code smells"(design ruim) e devem
            //ser evitados.
}
}
}
