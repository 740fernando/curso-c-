using System;
using Ex01.Entities.Enum;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Ex01.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Cliente { get; set; } = new Client();
        public List<OrderItem> Itens { get; set; } = new List<OrderItem>();
        public Order()
        {

        }

        public Order(DateTime moment, OrderStatus status, Client cliente)
        {
            Moment = moment;
            Status = status;
            Cliente = cliente;

        }
        public void AddItem(OrderItem item)
        {
            Itens.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            Itens.Remove(item);
        }
        public double TotalItem()
        {
            double sum = 0.0;
            foreach( OrderItem item in Itens)
            {
                sum += item.SubTotal();
            }
            return sum;

        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment : " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status : " + Status);
            sb.AppendLine("Cliente : " + Cliente);
            sb.AppendLine("Order items : ");
            foreach(OrderItem order in Itens)
            {
                sb.AppendLine(order.ToString());
            }
            sb.AppendLine("Total price : $" + TotalItem().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
