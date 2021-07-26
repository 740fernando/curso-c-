
using System;
using System.Globalization;
using Ex01.Entities;
using Ex01.Entities.Enum;
using System.Collections.Generic;

namespace Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ler os dados de um pedido com N itens (N fornecido pelo usuário). Depois, mostrar um
            sumário do pedido conforme exemplo (próxima página). Nota: o instante do pedido deve ser
            o instante do sistema: DateTime.Now*/
            Console.WriteLine("Enter cliente data : ");
            Console.Write("Name : ");
            string name = Console.ReadLine();

            Console.Write("Email : ");
            string email = Console.ReadLine();

            Console.Write("Birth Date(DD/MM/YYYY : ");
            DateTime birth = DateTime.Parse(Console.ReadLine());

             
            
            Console.WriteLine();

            Console.WriteLine("Enter Order Data : ");
            Console.WriteLine();
            Console.WriteLine("Status : ");
            Console.WriteLine("0 - PendingPayment");
            Console.WriteLine("1- Processing");
            Console.WriteLine("2- Shipped");
            Console.WriteLine("3- Delivered");
            OrderStatus opc = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client cliente = new Client(name, email, birth);
            Order order = new Order(DateTime.Now, opc, cliente);

            Console.WriteLine();
            Console.Write("How many items to this order ? ");
            int n = int.Parse(Console.ReadLine());
            

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter {i} item data ");
                
                Console.Write("Product name : ");
                string nomeProduto = Console.ReadLine();
                
                Console.Write("Price : ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                Product product = new Product(nomeProduto, price);
                
                Console.Write("Quantidade : ");
                int quant = int.Parse(Console.ReadLine());
                
                OrderItem orderItem = new OrderItem(quant,price,product);
                order.AddItem(orderItem);

            }
            Console.WriteLine();
            Console.WriteLine("Order Summary : ");
            Console.WriteLine(order);
        }
    }                                
}
