using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace ExFixacao
{
    class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }


        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }
        public ContaBancaria(int numero, string titular, double depositoInicial) : this(numero, titular)
        {
            AdicionarDeposito(depositoInicial);
            //Saldo = depositoInicial;

        }


        public void AdicionarDeposito(double dinheiro)
        {

            Saldo += dinheiro;


        }
        public void Saque(double dinheiro)
        {

            Saldo = (Saldo - dinheiro) - 5.00;

        }
        public override string ToString()
        {
            return "Conta : " + Numero + " Titular : " + Titular + " Saldo : $" + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
