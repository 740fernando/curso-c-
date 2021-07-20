//importação de depêndencias
using System;
using System.Globalization;
//Namespace da calsse
namespace camme
{
    //Nome da Classe
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("|                                                                 |");
            Console.WriteLine("|      38.Resolvendo um problema sem orientação objeto            |");
            Console.WriteLine("|                                                                 |");
            Console.WriteLine("-------------------------------------------------------------------");


            //double xA, xB, xC, yA, yB, yC;

            /* Fazer um programa para ler as medidas dos lados de dois triângulos X e Y (suponha medidas
válidas). Em seguida, mostrar o valor das áreas dos dois triângulos e dizer qual dos dois triângulos
possui a maior área.
A fórmula para calcular a área de um triângulo a partir das medidas de seus lados a, b e c é a
seguinte (fórmula de Heron):*/
            /* Console.WriteLine("Entre com as medidas do angula X");
             xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             Console.WriteLine("Entre com as medidas do angula Y: ");
             yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

             double p = (xA + xB + xC) / 2.0;
             double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));
             p = (yA + yB + yC) / 2.0;
             double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

             Console.WriteLine("Área de x = "+areaX.ToString("F4",CultureInfo.InvariantCulture));
             Console.WriteLine("Área de y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

             if (areaX > areaY)
             {
                 Console.WriteLine(" Maior área é do X");
             }
             else
             {
                 Console.WriteLine("Maior área é do Y");
             }*/
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("|                                                                 |");
            Console.WriteLine("|      39.Criando uma classe com 3 atriutos para representar      |");
            Console.WriteLine("|                       melhor o triangulo                        |");
            Console.WriteLine("-------------------------------------------------------------------");

            // classe é um tipo estrturado que pode conter (membros): atributos(dados/campos) e métodos(funções/operações)
            // também pode prover muitos outros recursos, tais como: construtores, sobrecarga, encapsulamento, herança, polimorfiemos
            //exemplos: entidades: Produto, Cliente, triangulo. Serviços: ProdutoService, ClienteService, Email Service Controladores: Produto Controller
            /*
            Triangulo x = new Triangulo();// o new é a criação da estancia
            Triangulo y = new Triangulo();
            Console.WriteLine("Entre com as medidas do angula X");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com as medidas do angula Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));
            p = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));
            Console.WriteLine("Área de x = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine(" Maior área é do X");
            }
            else
            {
                Console.WriteLine("Maior área é do Y");
            }
            */
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("|                                                                 |");
            Console.WriteLine("|                     40.Primeiros Exercicios                     |");
            Console.WriteLine("|                                                                 |");
            Console.WriteLine("-------------------------------------------------------------------");

            // EX 01 - Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais velha.
            /*
            Pessoa a, b;
            a = new Pessoa();
            b = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa: ");
            a.nome = Console.ReadLine();
            a.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa: ");
            b.nome = Console.ReadLine();
            b.idade = int.Parse(Console.ReadLine());

            if (a.idade > b.idade)
            {
                Console.WriteLine("A pessoa mais velha é "+a.nome);
            }
            else
            {
                Console.WriteLine("A pessoa mais velha é " + b.nome);
            }
            
            //EX 02 - Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário
            //médio dos funcionários.
            Funcionario a, b;
            a = new Funcionario();
            b = new Funcionario();


            Console.WriteLine("Dados do primeiro funcionario: ");
            a.nome = Console.ReadLine();
            a.salario = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionario: ");
            b.nome = Console.ReadLine();
            b.salario = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double medio = (a.salario + b.salario) / 2;
            Console.WriteLine("Salario médio = "+medio.ToString("F2",CultureInfo.InvariantCulture));
           

            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("|                                                                 |");
            Console.WriteLine("|                     41.Criando um método p/                     |");
            Console.WriteLine("|              obtermos reaproveitamento e delegação              |");
            Console.WriteLine("-------------------------------------------------------------------");
            //Agora vamos melhorar nossa classe, acrescentando nela um método para calcular área.
            // método é uma função dentro da classe

            Triangulo x = new Triangulo();// o new é a criação da estancia
            Triangulo y = new Triangulo();
            Console.WriteLine("Entre com as medidas do angula X");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com as medidas do angula Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //double p = (x.A + x.B + x.C) / 2.0; 
            //double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));// deveria está no programa principal
            double areaX = x.Area();
            //p = (y.A + y.B + y.C) / 2.0;
            //double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));
            double areaY = y.Area();
            Console.WriteLine("Área de x = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine(" Maior área é do X");
            }
            else
            {
                Console.WriteLine("Maior área é do Y");
            }*/
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("|                                                                 |");
            Console.WriteLine("|              42.Começando a resolver um                         |");
            Console.WriteLine("|              segundo problema exemplo                           |");
            Console.WriteLine("-------------------------------------------------------------------");
            /*Fazer um programa para ler os dados de um produto em estoque (nome, preço e
quantidade no estoque). Em seguida:
        • Mostrar os dados do produto (nome, preço, quantidade no estoque, valor total no
        estoque)
        • Realizar uma entrada no estoque e mostrar novamente os dados do produto
        • Realizar uma saída no estoque e mostrar novamente os dados do produto*/


            Produto p = new Produto();
            Console.Write("Entre os dados do produto: ");
            Console.Write("Nome : ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço : ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade em estoque : ");
            p.Quantidade = int.Parse(Console.ReadLine());



            /*Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("|                                                                 |");
            Console.WriteLine("|              43.Object e toString                               |");
            Console.WriteLine("|                                                                 |");
            Console.WriteLine("-------------------------------------------------------------------");*/
            //Console.WriteLine("Dados do produto: " + p);// exibiu camme.Produto
            // Console.WriteLine("Dados do produto: " + p.Nome + ", $" + p.Preco);//maneira obsoleta e dificil implementação

            // Toda classe em C# é uma subclasse da classe Object
            /* Ojbect possui os seguintes métodos:
             * GetType= retorna o tipo do objeto
             * Equals = Compara se o objeto é igual a outro
             * GetHashCode- reotrna um códgio hash do objeto
             * ToString - Converte o objeto para string*/
            Console.WriteLine("Dados do produto: " + p);// Após implemntação do método to tring

            /*Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("|                                                                 |");
            Console.WriteLine("|              43.Terminando de construir                         |");
            Console.WriteLine("|                    o programa                                   |");
            Console.WriteLine("-------------------------------------------------------------------");*/

            Console.Write("Digite o número a ser adicionado ao estoque :");
            int qte =int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte); // recebe o valor e modifca o valor armazenado no objeto p
            Console.WriteLine("Dados atualizado : "+p);
            Console.WriteLine("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine("Dados atualiados : "+p);

        }
    }
}



