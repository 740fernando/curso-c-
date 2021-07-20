using System;

namespace FuncaoString
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * CheckList:
             * • Formatar: ToLower(), ToUpper(), Trim()
               • Buscar: IndexOf, LastIndexOf
               • Recortar: Substring(inicio), Substring(inicio, tamanho)
               • Substituir: Replace(char, char), Replace(string, string)
               • String.IsNullOrEmpty(str), String.IsNullOrWhiteSpace(str)
               • str.Split(' ')
               • Conversão para numero: int x = int.Parse(str), int x =Convert.ToInt32(str)
               • Conversão de número: str = x.ToString(), str = x.ToString("C"), str =
                x.ToString("C3"), str = x.ToString("F2")
             */
            string original = "abcde FGHIJ ABC abc DEFG  ";
            string s1 = original.ToUpper(); // A função ToUpper vai acessar o conteúdo "Original" e criar em maíusculas na variavel "S1"
            string s2 = original.ToLower(); // A função ToLower vai acessar o conteúdo " Original" e criar letras minúsculas na variavel "S2"
            string s3 = original.Trim();// A função Trim vai apagar os espaços em branco; 
            int n1 = original.IndexOf("bc"); // Mostra a primeira ocorrência do "bc"  e joga esse valor para n1
            int n2 = original.LastIndexOf("bc"); // Mostra a ultima ocorrência do "bc"  e joga esse valor para n1
            string s4 = original.Substring(3);// Recorta o string a partir de um certo ponto. O SubString tem duas sobrecargas: ou vc declara o indice inicial
            // ou indice e tamanhoq que vc quer cortar, INDICE POS 3
            string s5 = original.Substring(3,5);// indice na pos 3, cortando 5 caracteres
            string s6 = original.Replace('a','x');//substituir parte de uma string por outra
            string s7 = original.Replace("abc", "xy");
            bool b1 = string.IsNullOrEmpty(original);// testa se a string esta vazia
            bool b2 = string.IsNullOrWhiteSpace(original);//vai testar se a variável é nula ou um monte de espaço em branco
            
            
            Console.WriteLine("Original : -"+original+"- ");
            Console.WriteLine("ToUpper : -"+s1+"- ");
            Console.WriteLine("ToLower : -" + s2 + "- ");
            Console.WriteLine("Trim : -"+s3+"- ");
            Console.WriteLine("IndexOf('bc') : " + n1);// Exibi o valor 1 
            Console.WriteLine("LastIndexOf('bc') : " + n2);
            Console.WriteLine("Substring (3) : " + s4);// "cortou abc"
            Console.WriteLine("Substring (3,5) : " + s5);// "exibe 'de FG'"
            Console.WriteLine("Replace('a','x') : "+s6);// trocou a por x
            Console.WriteLine("Replace('abc', 'xy') : "+s7); // trocou todas as ocorrencias abc por xy
            Console.WriteLine("IsNullOrEmpty : "+b1);//Exibiu falso, a função não está vazia
            Console.WriteLine(".IsNullOrWhiteSpace : " + b2);// Exibiu falso, porque a string não é somente espaço branco

        }
    }
}
