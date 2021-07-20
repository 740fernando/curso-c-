using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExLista
{
    class Funcionario
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public double Salario { get;  private set; }

        public Funcionario(int id, string name, double salario)
        {
            Id = id;
            Name = name;
            Salario = salario;
        }
        public void IncreaseSalary(double p)
        {
            Salario = Salario + (Salario * p);
        }

        public override string ToString()
        {
            return "Id : " + Id +
                " Nome : " + Name +
                " Salário : " + Salario.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
