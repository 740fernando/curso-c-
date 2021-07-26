using Composicao.Entities.Enum;
using System.Collections.Generic;

namespace Composicao.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level{get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }// associação de objetos 1..1: todo work associado com  1 department
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();// associação de objetos 1..*: todo work associado com vários contratos
        // sempre que tiver uma associação para muitos não colocar no construtor
        public Worker()
        {
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }
        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }
        public double  Income(int year , int month)
        {
            double sum = BaseSalary;
            foreach(HourContract c in Contracts)
            {
                if (c.Date.Year == year && c.Date.Month == month)
                {
                    sum += c.TotalValue();// Total Value é a operação que retorna o valor do contrato
                }
                
            }
            return sum;
        }

    }
}
