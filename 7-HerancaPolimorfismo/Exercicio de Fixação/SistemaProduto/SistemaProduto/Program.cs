using System;
using System.Collections.Generic;
using System.Globalization;
using SistemaProduto.Entities;

namespace SistemaProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> p = new List<Product>();

            Console.Write("Enter the number of products : ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Product #{i + 1} : ");
                Console.Write("Common, used, or imported : (c/u/i)");
                char resp = char.Parse(Console.ReadLine());
                Console.Write("Name : ");
                string name = Console.ReadLine();
                Console.Write(" Price : ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (resp == 'c')
                {

                    p.Add(new Product(name, price));
                }
                else if (resp == 'u')
                {
                    Console.Write("Manufacture Date (DD/MM/YYYY) : ");
                    DateTime used = DateTime.Parse(Console.ReadLine());
                    p.Add(new UsedProduct(name, price, used));
                }
                else if (resp == 'i')
                {
                    Console.Write("Customs fee : ");
                    double fee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    p.Add(new ImportedProduct(name, price, fee));
                }
            }
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS : ");
            foreach (Product product in p)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}
