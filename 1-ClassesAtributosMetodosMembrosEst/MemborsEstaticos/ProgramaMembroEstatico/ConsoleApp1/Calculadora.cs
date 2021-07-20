using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Calculadora
    {

        /*public double Pi = 3.14;
        public double Circuferencia(double r) //Static-é UTILIZADO ESSE TERMO PARA PODER UTILIZAR A FUNÇÃO DENTRO DA CLASSE PRINCIPAL
        {
            return 2.0 * Pi * r;
        }
        public double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3);
        }*/
        public static double Pi = 3.14;
        public static double Circuferencia(double r) //Static-é UTILIZADO ESSE TERMO PARA PODER UTILIZAR A FUNÇÃO DENTRO DA CLASSE PRINCIPAL
        {
            return 2.0 * Pi * r;
        }
        public static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3);
        }
    }
}