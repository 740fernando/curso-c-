
using System;
using System.Collections.Generic;

namespace Prj_Contrato.Entities
{
    class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public Double TotalValue { get; set; }

        public List<Installment> Installment { get; set; }

        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
        }
    }
}
