using System;
using System.Collections.Generic;//Biblioteca que contem a List

namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<string> list = new List<string>();
            List<string> list2 = new List<string> { "Maria", "Alex" };
            Console.WriteLine(list2);
            foreach(string obj in list2)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("---------------------------------------------");
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Ana");
            list.Insert(2, "Marco"); // O comando insert voce escolhe uma posição em que a informação vai ficar
            foreach(string obj2 in list)
            {
                Console.WriteLine(obj2);
            }
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("List Count:"+list.Count);// Conta o numero de obj na lista
            Console.WriteLine("-----------------------------------------------------------");
            //Encontrar primeiro ou último elementos da lista que satisfaça um predicado:
            //string s1 =list.Find(Test);//predicado é uma função que pega um valor, e retorna true ou false dependendo da logica implementada
            
            string s1 = list.Find(x => x[0] == 'A');//Expressão Lambda, conhecida como função anonima
            Console.WriteLine(" First A : " + s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A' : "+s2);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A' : "+ pos1);
            Console.WriteLine();
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A' : " + pos2);
            Console.WriteLine(" ");
            Console.WriteLine("Apenas nomes que contem 5 caracteres");
            List<string> list3 = list.FindAll(x => x.Length == 5);
            foreach(string obj in list3)
            {
               
                Console.WriteLine(obj);
            }
            Console.WriteLine("========================================================== ");

            Console.WriteLine("  ");
            //list.Remove("Alex");
            //list.RemoveAt(3);// remove o elemento pela posição
            list.RemoveRange(2, 2);//posição e contagem
            foreach (string obj in list)
            {
                
                Console.WriteLine(obj);
            }
            Console.WriteLine();

            //list.RemoveAll(x => x[0] == 'M');
            
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            
            Console.WriteLine("---------------------------------------------------------");

            
        }
       /* static bool Test(string s)
        {
            return s[0] == 'A';
        }
       */
    }
}
