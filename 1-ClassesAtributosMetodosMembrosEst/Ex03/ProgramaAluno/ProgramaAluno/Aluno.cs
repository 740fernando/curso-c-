﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaAluno
{
    class Aluno
    {
        public string NomeAluno;
        public double N1;
        public double N2;
        public double N3;



        public Double NotaFinal()
        {
            return N1 + N2 + N3;

        }
        public Boolean Aprovado()
        {
            if (NotaFinal() >= 60.00)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public double NotaRestante()
        {
            if (Aprovado())
            {
                return 0.0;
            }
            else
            {
                return 60 - NotaFinal();
            }
        }



    }
}
