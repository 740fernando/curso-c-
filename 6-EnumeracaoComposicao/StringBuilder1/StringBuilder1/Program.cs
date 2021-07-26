using System;
using StringBuilder1.Entities;

namespace Sb
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip");
            Comment c2 = new Comment("Wow that's awesome!");
            Post p1 = new Post(DateTime.Parse("21/06/2019 13:05:44"), "Traveling to New Zeland", "I'm going to visit this wonderful country!",12);
            Post p2 = new Post(DateTime.Parse("28/07/2018 23:14:19"), "Good night guys", "See you tomorrow", 5);
            p1.AddComment(c1);
            p2.AddComment(c2);

            Console.WriteLine(p1);
            Console.WriteLine(p2);

        }
    }
}
