using System;
using System.Collections.Generic;
using SistemaFuncionario.Entitites;
using System.Globalization;
namespace SistemaFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              Uma empresa possui funcionários próprios e terceirizados.
            Para cada funcionário, deseja-se registrar nome, horas
            trabalhadas e valor por hora. Funcionários terceirizados
            possuem ainda uma despesa adicional.
            O pagamento dos funcionários corresponde ao valor da hora
            multiplicado pelas horas trabalhadas, sendo que os
            funcionários terceirizados ainda recebem um bônus
            correspondente a 110% de sua despesa adicional.
            Fazer um programa para ler os dados de N funcionários (N
            fornecido pelo usuário) e armazená-los em uma lista. Depois
            de ler todos os dados, mostrar nome e pagamento de cada
            funcionário na mesma ordem em que foram digitados.
             */

            List<Employee> list = new List<Employee>();

            Console.Write("Enter the number of employees");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Employee #{i} data : ");
                Console.Write("Outsourced (y/n) : ");
                char resp = char.Parse(Console.ReadLine());

                Console.Write("Name : ");
                string name = Console.ReadLine();

                Console.Write("Hours : ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Value per Hours : ");
                double valuePerHours = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(resp == 'y')
                {
                    Console.Write("Addional charge : ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsourcedEmployee(name, hours, valuePerHours, additionalCharge));
                }
                else
                {
                    list.Add(new Employee(name, hours, valuePerHours));
                }
            }
            Console.WriteLine();
            Console.WriteLine("PAYMENTS : ");
            foreach(Employee emp in list)// Temos a exibição de uma execução polimórfica da função pagamento(payment())
            {
                Console.WriteLine(emp.Name+ " - $ "+emp.Payment().ToString("F2"),CultureInfo.InvariantCulture);
            }
        }
    }
}
/*
  Em Programação Orientada a Objetos, polimorfismo é recurso que permite
que variáveis de um mesmo tipo mais genérico possam apontar para objetos
de tipos específicos diferentes, tendo assim comportamentos diferentes
conforme cada tipo específico.
 */
