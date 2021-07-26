

using System.Globalization;

namespace Ex01.Entities
{
    class OrderItem
    {
        public int Quantidade { get; set; }
        public double Price { get; set;  }
        public Product Produto { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(int quantidade, double price, Product produto)
        {
            Quantidade = quantidade;
            Price = price;
            Produto = produto;
        }

        public double SubTotal()
        {
            return Quantidade * Price;
        }
        public override string ToString()
        {
            return " , $ " + Price.ToString("F2", CultureInfo.InvariantCulture)
                + " , Quantify : "
                +Quantidade
                + ", Subtotal: $"
                + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
