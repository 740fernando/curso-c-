using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaSalario
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            
            return SalarioBruto -= Imposto;
        }
        public void AumentarSalario(double porcentagem)
        {

            SalarioBruto += Imposto;
            porcentagem /=  100;
            SalarioBruto += (porcentagem * SalarioBruto);
            SalarioBruto -= Imposto;
        } 
        public override string ToString()
        {
            return "Nome : " + Nome +
                " $ : " + SalarioBruto;
        }
    }
}
