using System;
using System.Globalization;

namespace Construtores
{
    class Program
    {
        static void Main(string[] args)
        {

            //É uma operação especial da classe, que executa no momento da instanciação do objeto
            //Usos comuns:
            //-Iniciar valores do atributos
            //-Permitir ou obrigar que o objeto receba dados / dependencias no momento de sua instanciação (Injeção de dependências)
            //-Se um construtor customizado não for especificado, a classe disponibiliza o construtor padrão: Produto p / = new Produto();
            //-É possível especificar mais de um construtor na mesma classe(Sobrecarga)


            //Produto p = new Produto("TV",500.0,10);
            //Console.WriteLine(p);//EXIBE 0
            //Faz sentido um produto que não tem nome?
            //com o intuito de evitar um produto sem nome e sem preço, é possível fazer com que seja obrigatorio a iniciação de valores

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());
            
            Produto p = new Produto(nome, preco, quantidade);
            
            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);


            
        }
    }
}
