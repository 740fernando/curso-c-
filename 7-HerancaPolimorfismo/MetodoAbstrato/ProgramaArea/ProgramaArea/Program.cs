using System;
using System.Collections.Generic;
using System.Globalization;
using ProgramaArea.Entities;
using ProgramaArea.Entities.Enums;


namespace ProgramaArea
{
    class Program
    {
        static void Main(string[] args)
        {
            // Métodos Abstratos
            //• São métodos que não possuem implementação:

            //• Métodos precisam ser abstratos quando a classe
            //é genérica demais para conter sua implementação.

            //• Se uma classe possuir pelo menos um método
            //abstrato, então esta classe também é abstrata.
            //implementação.

            List<Shape> list = new List<Shape>();
            Console.Write("Entre the number of shapes : ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Shape #{i} data : ");
                Console.Write("Rectagle or Circle ( r/ c ) : ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Color ( Black / Blue / Red ): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                if (ch == 'r')
                {
                    Console.Write("Width : ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height : ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Rectangle(width, height, color));
                }
                else
                {
                    Console.Write("Radius : ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circle(radius, color));
                }
             
            }
            Console.WriteLine();
            Console.WriteLine("Shape Areas : ");
            foreach (Shape shape in list)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}
