using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadoresRefeOut
{
    class Calculator
    {
        /*public static void Triple(ref int x) //quando voce coloca ref, estará mexendo direto na variável alocada no Program.
        {
            x = x * 3;
        }
        */
        public static void Triple(int origem, out int resultado)
        {
            resultado = origem * 3;
        }
    }
}
