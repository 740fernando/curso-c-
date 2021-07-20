using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversosDeMoeda
{
    class ConversorDeMoeda
    {
        static double iof = 1.06;
        public static Double Converter ( double x , double y)
        {

            return (y*x)*iof;
        }
    }
}
