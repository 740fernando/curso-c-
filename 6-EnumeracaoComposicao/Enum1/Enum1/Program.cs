using Enum1.Entities;
using Enum1.Entities.Enums;
using System;


namespace Enum1
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };
            Console.WriteLine(order);

            //Conversão de String para Enum
            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);

            // Categorias de classes
            // Em um sitema orientado a  objetos, de modo geral "tudo" é objeto
            // Por questões de design tais como organização, flexbilidade, reuso, delegação, etc., há várias categorias de classes:
            // - Views
            // - Controllers
            // - Entities
            // - Services
            // - Repositories
        }
    }
}
