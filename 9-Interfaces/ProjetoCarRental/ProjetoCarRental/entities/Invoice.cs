using System;
using System.Globalization;

namespace ProjetoCarRental.entities
{
    class Invoice
    {
        public Double BasicPayment { get; set; }
        public Double Tax { get; set; }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }
        public double TotalPayment
        {
            get { return BasicPayment + Tax ; }
        }
        public override string ToString()
        {
            return "Pagamento básico : "
                + BasicPayment.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTaxa : "
                + Tax.ToString("F2", CultureInfo.InvariantCulture)
                + "\nPagamento total : "
                + TotalPayment.ToString("F2", CultureInfo.InvariantCulture);
        }
    }

    
}
