using System;
using System.Globalization;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("|                    Tipos de dados                              |");
            Console.WriteLine("|                                                                |");
            Console.WriteLine("------------------------------------------------------------------");
            /*byte bt = 126;
            int nt = 1000;
            int nt2 = 2147483647;
            long nt4 = 2147483648L;
            bool completo = false;
            char gnr = 'm';
            char ltr = '\u0040';
            float nt5 = 4.5f;
            double nt6 = 4.2;
            string nm = "fernando";
            object obj2 = 1.2;
            int _x = int.MinValue;
            int _y = int.MaxValue;
            sbyte _z = sbyte.MinValue;
            decimal _w = decimal.MaxValue;
            double _saldo = 500.156789;
            int _idade = 29;

            Console.WriteLine(" Byte : " + bt);
            Console.WriteLine("int: " + nt);
            Console.WriteLine("numero max de int: " + nt2);
            Console.WriteLine(" Long : " + nt4);
            Console.WriteLine(" Booleana: " + completo);
            Console.WriteLine(" char: " + gnr);
            Console.WriteLine(" char utilizando cod" + ltr);
            Console.WriteLine("float: " + nt5);
            Console.WriteLine(" Double: " + nt6);
            Console.WriteLine("string= " + nm);
            Console.WriteLine("Objeto: " + obj2);
            Console.WriteLine("");
            Console.WriteLine(" Funções para valores minimos e maximos");
            Console.WriteLine("");
            Console.WriteLine("  Valor minimo de int: " + _x);
            Console.WriteLine("  Valor maximo de int: " + _y);
            Console.WriteLine("  Valor minimo de sbyte: " + _z);
            Console.WriteLine("  Valor maximo de decimal: " + _w);

            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("|                    Placeholder,interpolação e                  |");
            Console.WriteLine("|                           Concatenação                         |");
            Console.WriteLine("------------------------------------------------------------------");

            Console.WriteLine("----------------------");
            Console.Write("Bom dia");
            Console.WriteLine("Boa tarde");
            Console.WriteLine("Boa noite");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2} reais", nm, _idade, _saldo);// modo placeholders, n subst as variaveis
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nm, _idade, _saldo);// F determina o numero de casas
            Console.WriteLine($"{nm} tem {_idade} anos e tem saldo igual a {_saldo:F2} reais"); //interpolação
            Console.WriteLine("nome: " + nm + " Idade: " + _idade + " Saldo :" + _saldo);
            Console.WriteLine("nome: " + nm + " Idade: " + _idade + " Saldo :" + _saldo.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(_saldo.ToString("F2")); // PARAMETRO PARA DETERMINAR QUANTAS CASAS DECIMAIS VAI TER
            Console.WriteLine(_saldo.ToString("F4"));
            Console.WriteLine(_saldo.ToString("F4", CultureInfo.InvariantCulture)); //manter o ponto, independente do sistema

            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("|                     Exercício Aula 00                          |");
            Console.WriteLine("|                                                                |");
            Console.WriteLine("------------------------------------------------------------------");
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos");
            Console.WriteLine($"{produto1}, cujo preço é {preco1}");
            Console.WriteLine("{0}, cujo preço é {1}", produto2, preco2);
            Console.WriteLine("Registro: " + idade + ", código " + codigo + " e gênero: " + genero);
            Console.WriteLine($"Medida com oito casas decimais {medida:F8}");
            Console.WriteLine("Arredondando (três casas decimais): {0:F3} ", medida);
            Console.WriteLine(" Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("|                     Exercício  01                              |");
            Console.WriteLine("|                                                                |");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma mensagem explicativa, conforme exemplos.");
            int x = 10;
            int y = 30;
            int x1 = -30;
            int y1 = 10;
            int x2 = 0;
            int y2 = 0;
            int soma = x + y;
            Console.WriteLine("A soma de " + x + " e " + y + " é " + (x + y));
            Console.WriteLine("A soma de " + x1 + " e " + y1 + " é " + (x1 + y1));
            Console.WriteLine("A soma de " + x2 + " e " + y2 + " é " + (x2 + y2));
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("|                     Exercício  02                              |");
            Console.WriteLine("|                                                                |");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro");
            Console.WriteLine("casas decimais conforme exemplos.");
            Console.WriteLine("Fórmula da área: area = π.raio2");
            Console.WriteLine("Considere o valor de π = 3.14159");
            Console.WriteLine("");
            double raio1 = 2.00;
            double raio2 = 100.64;
            double raio3 = 150.00;
            double pi = 3.14159;
            double area1 = pi * (raio1 * raio1);
            double area2 = pi * (raio2 * raio2);
            double area3 = pi * (raio3 * raio3);


            Console.WriteLine("Área 1 : " + area1.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área 2 : " + area2.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área 3 : " + area3.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("|                     Exercício  03                              |");
            Console.WriteLine("|                                                                |");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a");
            Console.WriteLine("diferença do produtode A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D)");

            int a = 5;
            int b = 6;
            int c = 7;
            int c1 = -7;
            int d = 8;
            int dif = (a * b) - (c * d);
            int dif2 = (a * b) - (c1 * d);

            Console.WriteLine(" A diferença de A * B + C * D : " + dif);
            Console.WriteLine(" A diferença de A * B + C * D : " + dif2);
            Console.WriteLine("");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("|                     Exercício  04                              |");
            Console.WriteLine("|                                                                |");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por");
            Console.WriteLine("hora e calcula o salário desse funcionário.A seguir, mostre o número e o salário do funcionário, com duas casas");
            Console.WriteLine("decimais.");
            Console.WriteLine("");
            int nFuncionario = 25;
            int hrTrabalho = 100;
            double valorHora = 5.50;
            double salario = hrTrabalho * valorHora;
            Console.WriteLine("Numero de funcionarios: " + nFuncionario + " Salario : " + salario.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("|                     Exercício  05                              |");
            Console.WriteLine("|                                                                |");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o");
            Console.WriteLine("código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2.Calcule e mostre o valor a ser pago");

            int codpeca = 12;
            int nrpeca = 1;
            double vlpeca = 5.30;

            int codpeca2 = 16;
            int nrpeca2 = 2;
            double vlpeca2 = 5.10;

            double total = nrpeca * vlpeca;
            double total2 = nrpeca2 * vlpeca2;

            int codpeca3 = 13;
            int nrpeca3 = 2;
            double vlpeca3 = 15.30;

            int codpeca4 = 161;
            int nrpeca4 = 4;
            double vlpeca4 = 5.20;

            double total3 = nrpeca3 * vlpeca3;
            double total4 = nrpeca4 * vlpeca4;

            int codpeca5 = 1;
            int nrpeca5 = 1;
            double vlpeca5 = 15.10;

            int codpeca6 = 2;
            int nrpeca6 = 1;
            double vlpeca6 = 15.10;

            double total5 = nrpeca5 * vlpeca5;
            double total6 = nrpeca6 * vlpeca6;

            Console.WriteLine("");
            Console.WriteLine("Valor a pagar : " + (total + total2));
            Console.WriteLine("Valor a pagar : " + (total3 + total4));
            Console.WriteLine("Valor a pagar : " + (total5 + total6));
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("|                     Exercício  06                              |");
            Console.WriteLine("|                                                                |");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e");
            Console.WriteLine("mostre:");
            Console.WriteLine("a) a área do triângulo retângulo que tem A por base e C por altura.");
            Console.WriteLine("b) a área do círculo de raio C. (pi = 3.14159)");
            Console.WriteLine("c) a área do trapézio que tem A e B por bases e C por altura.");
            Console.WriteLine("d) a área do quadrado que tem lado B.");
            Console.WriteLine("e) a área do retângulo que tem lados A e B.");
            Console.WriteLine("");
            double xis = 3.0;
            double ipisolon = 4.0;
            double ze = 5.2;
            double triangulo = (xis * ze) / 2;
            double circulo = (pi * (ze * ze));
            double trapezio = ((xis + ipisolon) * ze) / 2;
            double quadrado = (ipisolon * ipisolon);
            double retangulo = xis * ipisolon;
            Console.WriteLine("Triangulo: " + triangulo);
            Console.WriteLine("Círculo: " + circulo);
            Console.WriteLine("Trapézio: " + trapezio);
            Console.WriteLine("Quadrado: " + quadrado);
            Console.WriteLine("Retangulo: " + retangulo);
            double xis2 = 12.7;
            double ipisolon2 = 10.4;
            double ze2 = 15.2;
            double triangulo2 = (xis2 * ze2) / 2;
            double circulo2 = (pi * (ze2 * ze2));
            double trapezio2 = ((xis2 + ipisolon2) * ze2) / 2;
            double quadrado2 = (ipisolon2 * ipisolon2);
            double retangulo2 = xis2 * ipisolon2;
            Console.WriteLine("");
            Console.WriteLine("Triangulo: " + triangulo2);
            Console.WriteLine("Círculo: " + circulo2);
            Console.WriteLine("Trapézio: " + trapezio2);
            Console.WriteLine("Quadrado: " + quadrado2);
            Console.WriteLine("Retangulo: " + retangulo2);
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("|                                                                 |");
            Console.WriteLine("|            Aula 19- Operadores de atribuição                    |");
            Console.WriteLine("|                                                                 |");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("O valor de a : " + a);
            a += 2;
            Console.WriteLine("+2 " + a);
            a *= 2;
            Console.WriteLine("* 2 " + a);
            a++;
            Console.WriteLine(" a ++ " + a);
            Console.WriteLine("O valor de b:" + b);
            b = ++a;
            Console.WriteLine("b recebendo a ++ " + b);
            string teste = "abc";
            Console.WriteLine(teste);
            teste += "def";
            Console.WriteLine(teste);
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            Console.WriteLine("|                                                                                                |");
            Console.WriteLine("| Aula 20- Conversão implícita entre tipos e Casting:conversão explicita entre tipos compativeis |");
            Console.WriteLine("|                                                                                                |");
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            // não é possivel converter double para float, somente de float para double
            double l;
            float f;

            f = 4.5f;
            l = f;
            Console.WriteLine("O double consegue receber float: " + l);
            //ao contratario 
            l = 5.1;
            //f = l; vai dar erro, ou seja, float nao recebe double
            f = (float)l; //agora eu to falando para o compilador jogar conteudo de l que é de 8 bytes no conteudo de f que é 4 bytes, eu me responsabilizo por eventuais perdas
            Console.WriteLine(f);
            // agora vamos fazer uma variavel int receber o valor de l que do tipo double
            int m;
            m = (int)l;
            Console.WriteLine("O valor de m: " + m);
            // nesta etapa iremos fazer uma variavel double receber um valor int
            a = 5;
            b = 2;
            Console.WriteLine(" O valor de a : " + a);
            Console.WriteLine("O  valor de b : " + b);
            l = a / b;
            Console.WriteLine(" O resultado de a dividido por b é : " + l);
            // para tornar possível a divisão é necessario converter a e b por float
            l = (float)a / b;
            Console.WriteLine(" O resultado de a dividido por b ( após a conversão de tipo) : " + l);
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("|                                                                 |");
            Console.WriteLine("|                   Aula 21- Operadores aritméticos               |");
            Console.WriteLine("|                                                                 |");
            Console.WriteLine("-------------------------------------------------------------------");
            // + adiçao - sub * mult /div % resto da divisão
            //1)* / % tem precedencia maior que + -
            //2) exemplos: 3+4*2= 11 (3+4)*2=14
            //3) pode ser usar parentesis a vontade
            //4) exemplos com mod: 17%3 o resto da divisão é 2
            int n1 = 3 + 4 * 2;
            int n2 = (3 + 4) * 2;
            int n3 = 17 % 3;
            int n4 = 10 / 8;
            double n5 = 10 / 8; // compilador entende que vc quer um result inteiro
            double n6 = (double)10 / 8;// compilador entende que vc quer um numero quebrado
            double n7 = 10.0 / 8;// colocando .o o compliador entende que é um n flutuante
            Console.WriteLine("3 + 4 * 2 = " + n1);
            Console.WriteLine("(3 + 4) * 2 = " + n2);
            Console.WriteLine("17 % 3 = " + n3);
            Console.WriteLine("int n4 = 10 / 8 = " + n4);
            Console.WriteLine("double n5 = 10 / 8 = " + n5);
            Console.WriteLine("double n7 = 10.0 / 8 = " + n7);
            Console.WriteLine("");
            Console.WriteLine("Fórmula de Bhaskara ");
            Console.WriteLine(" ");

            double r = 1.0, s = -3.0, t = -4.0;

            double delta = Math.Pow(s, 2) - 4.0 * r * t;
            double positivo = (-s + Math.Sqrt(delta)) / (2.0 * r);
            double negativo = (-s - Math.Sqrt(delta)) / (2.0 * r);

            Console.WriteLine(" O valor de delta é : " + delta);
            Console.WriteLine("O valor de x1 é " + positivo + ". O valor de x2 é " + negativo);

            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("|                                                                 |");
            Console.WriteLine("|                   Aula 22- Entrada de dados                     |");
            Console.WriteLine("|                                                                 |");
            Console.WriteLine("-------------------------------------------------------------------");
            //Console.readLine() Lê da entrada padrão até a quebra de linha. Retorna os dados lidos na forma de string
            //string frase = Console.ReadLine();
            // string frase1 = Console.ReadLine();
            // string frase2 = Console.ReadLine();
            //string frase3 = Console.ReadLine();

            //Console.WriteLine("Voce digitou: " + frase);
            //Console.WriteLine(frase1);
            //Console.WriteLine(frase2);
            // Console.WriteLine(frase3);

            //Comando Split = Vams supor que vc quer digitar batata tomate e abacaxi. Se digitarmos o Console.ReadLine()
            //vamos armazenar todas em uma mesma váriavel,um jeito de guardar cada palavra em uma váriavel diferente
            // usamos o split. O split é função que serve para recortar o string em vários pedacinhos, conforme
            // o caractere indicado entre paresenteses, no caso do exemplo abaixo é o espaço em branco

            // Ler 3 palavras na mesma linha, separadas por espaço, armazenando cada uma em uma váriavel.
            // Amarelo Laranja e Cinza

            //Primeira
            //string slt = Console.ReadLine();
            //string[] vet = slt.Split(' ');

            //Segunda 
            //string[] vet = Console.ReadLine().Split(' ');

            //string p1 = vet[0];
            //string p2 = vet[1];
            //string p3 = vet[2];
            //Console.WriteLine(p1);
            //Console.WriteLine(p2);
            //Console.WriteLine(p3);

            //Entrada de dados parte 2

            // Ler um numero inteiro
            //int _n1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Inteiro: "+_n1);

            //ler um char
            //char ch = char.Parse(Console.ReadLine());
            // Console.WriteLine("Char: "+ ch);

            //ler um double

            //double _n2 = double.Parse(Console.ReadLine()); // Não reconhece ponto

            // Console.Write("Digite o double: ");
            // double _n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);// culture para ler o ponto

            //Console.WriteLine("Double: " + _n2);

            // Console.WriteLine("Double: "+ _n2.ToString("F2",CultureInfo.InvariantCulture));//O comando f2 para colocar
            //2 casas decimais, e culture para ficar com ponto na exibição

            //LER UM NOME, SEXO, IDADE, ALTURA NA MESMA LINHA, ARMAZENANDO EM 4 VARIAVEIS DIFERENTES

            //string[] _vet = Console.ReadLine().Split(' ');
            //string _nome = _vet[0];
            //char _sexo = char.Parse(_vet[1]);
            //int _idade2 = int.Parse(_vet[2]);
            //double _altura = double.Parse(_vet[3], CultureInfo.InvariantCulture);

            //Console.WriteLine("Você digitou: ");
            //Console.WriteLine(_nome);
            //Console.WriteLine(_sexo);
            //Console.WriteLine(_idade2);
            //Console.WriteLine(_altura.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("|                                                                 |");
            Console.WriteLine("|                   Exercício de fixação                          |");
            Console.WriteLine("|                                                                 |");
            Console.WriteLine("-------------------------------------------------------------------");

            //Fazer um programa para executar a seguinte interação com o usuário, Lendo os valores destacados
            // em vermelho, depois mostrador os dados na tela:

            /*Console.Write("Digite seu nome:  obs:string ");
            string _nome = Console.ReadLine();


            Console.Write(" Quantos quartos tem na sua casa? obs:inteiro ");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com um preço de um produto:  obs:double ");
            double produto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre seu ultimo nome, idade e altura( na mesma linha");
            string[] saida = Console.ReadLine().Split(' ');
            string ultNome = saida[0];
            int idade_ = int.Parse(saida[1]);
            double altura = double.Parse(saida[2],CultureInfo.InvariantCulture);

            Console.WriteLine(" Saída: ");
            Console.WriteLine(_nome);
            Console.WriteLine(quartos);
            Console.WriteLine(produto.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(ultNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString(CultureInfo.InvariantCulture)); 

            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("|                                                                 |");
            Console.WriteLine("|                   Aula 26- Operadores Lógicos                   |");
            Console.WriteLine("|                                                                 |");
            Console.WriteLine("-------------------------------------------------------------------");
            // 
            bool _c1 = 2 > 3 || 4 != 5; // true
            bool c2 = !(2 > 3) && 4 != 5; //true

            Console.WriteLine(_c1);
            Console.WriteLine(c2);
            Console.WriteLine("----------------------------------------------------------------");
            bool c3 = 10 < 5; //false

            bool _c4 = _c1 || c2 && c3; // true

            Console.WriteLine("c3 é : " + c3);
            Console.WriteLine(" c4 é : " + _c4);
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("|                                                                 |");
            Console.WriteLine("|                   Aula 27- Estrutura Condicional                |");
            Console.WriteLine("|                                                                 |");
            Console.WriteLine("-------------------------------------------------------------------");

            //SIMPLES
            // Console.WriteLine(" Bom dia ");

            //int _xis = 10;
            //if (_xis < 5) // condição falsa, o programa pulou essa parte do código
            //{
            //    Console.WriteLine(" Boa tarde ");
            //}
            //Console.WriteLine(" Boa noite ");

            /*COMPOSTA
            Console.WriteLine("Digite um numero inteiro");
            int _xis = int.Parse(Console.ReadLine());
            if (_xis % 2 == 0)
            {
                Console.WriteLine("Par");
            }
            else
            {
                Console.WriteLine("Impar");
            }*/
            //ENCADEAMENTOS


            //Console.WriteLine("Qual é hora atual: ");
            //int hrAtual = int.Parse(Console.ReadLine());

            /*if (hrAtual < 12)
            //{
                Console.WriteLine("Bom dia");
            }
            //if hrAtual >= 12 && hrAtual <= 18) ou
            else if (hrAtual >= 12 && hrAtual <= 18)
            {
                Console.WriteLine("Boa tarde");
            }
            //else if (hrAtual >= 18) ou
            else
            {
                Console.WriteLine("Boa noite");
            }

            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("|                                                                 |");
            Console.WriteLine("|                   Aula 28- Escopo e inicialização               |");
            Console.WriteLine("|                                                                 |");
            Console.WriteLine("-------------------------------------------------------------------");

            /* Escopo de uma váriavel: é a região do programa onde a váriavel é válida, ou seja,
             * onde ela pode ser referenciad
             * Uma variável não pode ser usada se não for iniciada
             * Falaremos de escpo de me´todos no Capítulo " Comportamentos de memória, arrays, listas*/

            /*double preco = double.Parse(Console.ReadLine());
            //double _desconto se a condição não for atendida, a variavel desconto não será inicializada, por isso é necessário atribuir um valor
            double _desconto = 0.0;
            if (preco > 100.0)
            {
                //double desconto = preco * 0.1; se a var preco fosse criada no if, só existiria dentro desse escopo
                _desconto = preco * 0.1;
            }
            Console.WriteLine(_desconto);

            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("|                                                                 |");
            Console.WriteLine("|      Exercícios sobre Estrutura Condicional (if-else)           |");
            Console.WriteLine("|                        Exercicio 01                             |");
            Console.WriteLine("-------------------------------------------------------------------");

            /*Console.WriteLine("Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.");

            int nInteiro = int.Parse(Console.ReadLine());
            if ( nInteiro<0)
            {
                Console.WriteLine("Negativo");
            }
            else
            {
                Console.WriteLine("Não negativo");
            }
            Console.WriteLine("Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.");
            int nInteiro = int.Parse(Console.ReadLine());
            if (nInteiro % 2 == 0)
            {
                Console.WriteLine("Par");
            }
            else
            {
                Console.WriteLine("Impar");

            }
            Console.WriteLine("Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem 'Sao Multiplos' ou 'Nao sao");
            Console.WriteLine("Multiplos, indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em");
            Console.WriteLine("ordem crescente ou decrescente.");

            int _a = int.Parse(Console.ReadLine());
            int _b = int.Parse(Console.ReadLine());

            if ( _a%_b==0 || _b%_a==0)
            {
                Console.WriteLine(" São múltiplos");
            }
            else
            {
                Console.WriteLine("Não são múltiplos");
            }*/
            //Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode
            //começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.

            /*string[] valores = Console.ReadLine().Split(' ');
            int hrInicial = int.Parse(valores[0]);
            int hrFinal = int.Parse(valores[1]);
            int duracao;
            if (hrInicial < hrFinal)
            {
                duracao = hrFinal - hrInicial;
            }
            else
            {   
                duracao = 24 - hrInicial + hrFinal;
            }
            Console.WriteLine("A duração foi de :"+duracao);

            //Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A
            //seguir, calcule e mostre o valor da conta a pagar.

            Console.WriteLine("Faça seu pedido: cod+desc");
            string [] tabela = Console.ReadLine().Split(' ');
            int cod = int.Parse(tabela[0]);
            string desc = tabela[1];
       
            int quantidade = int.Parse(Console.ReadLine());
            double _total;
            if (cod == 1)
            {
                _total = quantidade * 4.00;
            }else if (cod == 2)
            {
                total = quantidade * 4.50;
            }else if (cod == 3)
            {
                total = quantidade * 5.00;
            }else if (cod == 4)
            {
                total = quantidade * 2.00;
            }else if (cod == 5)
            {
                total= quantidade *1.50;
            }
            Console.WriteLine("O seu pedido foi: "+ quantidade+" "+desc+" total de : "+ total.ToString("F2", CultureInfo.InvariantCulture));
            
            //Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos
            //seguintes intervalos([0,25], (25, 50], (50, 75], (75, 100]) este valor se encontra. Obviamente se o valor não estiver em
            //nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.


            double a1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 

            if ( a1 < 0.0 || a1 > 100.00) 
            {
                Console.WriteLine("FORA DE INTERVALO");
            }else if (a1<= 25.00)
            {
                Console.WriteLine("Intervalo [0,25]");
            }else if (a1<=50.00)
            {
                Console.WriteLine("Intervalo [25,50]");
            }else if (a1<=75)
            {
                Console.WriteLine("Intervalo [50,75]");
            } else
            {
                Console.WriteLine(" Intervalo [75,100]");
            }
            */
            /*Leia 2 valores com uma casa decimal(x e y), que devem representar as coordenadas
de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o
ponto, ou se está sobre um dos eixos cartesianos ou na origem(x = y = 0).
Se o ponto estiver na origem, escreva a mensagem “Origem”.
Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a
situação
            string[] valores = Console.ReadLine().Split(' ');
            double a1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double b1 = double.Parse(valores[1], CultureInfo.InvariantCulture);

            if (a1 == 0.0 && b1 == 0.0)
            {
                Console.WriteLine("origem");
            }
            else if (x == 0.0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (y == 0.0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (a1 > 0 && b1 > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (a1 > 0 && b1 > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (a1 < 0 && b1 < 0)
            {
                Console.WriteLine("Q3");
            }
            else
            {
                Console.WriteLine("Q4");
            }

            Em um país imaginário denominado Lisarb, todos os habitantes ficam felizes em pagar seus impostos, pois sabem
que nele não existem políticos corruptos e os recursos arrecadados são utilizados em benefício da população, sem
qualquer desvio. A moeda deste país é o Rombus, cujo símbolo é o R$.
Leia um valor com duas casas decimais, equivalente ao salário de uma pessoa de Lisarb. Em seguida, calcule e
mostre o valor que esta pessoa deve pagar de Imposto de Renda, segundo a tabela abaixo.
Lembre que, se o salário for R$ 3002.00, a taxa que incide é de 8% apenas sobre R$ 1000.00, pois a faixa de
salário que fica de R$ 0.00 até R$ 2000.00 é isenta de Imposto de Renda. No exemplo fornecido (abaixo), a taxa é
de 8% sobre R$ 1000.00 + 18% sobre R$ 2.00, o que resulta em R$ 80.36 no total. O valor deve ser impresso com
duas casas decimais.


            double _salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double imposto;

            if (_salario <= 2000.00)
            {
                imposto = 0.0;
            }
            else if (_salario <= 3000.00)
            {
                imposto = (_salario-2000.00)* 0.08;
            }
            else if (_salario <= 4500.00)
            {
                imposto = (_salario - 3000.00) * 0.18 + 1000.0 * 0.08;

            }
            else 
            {
                imposto = (_salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            }
            if (imposto == 0.0)
            {
                Console.WriteLine("Isento");
            }
            else
            {
                Console.WriteLine("R$ "+ imposto.ToString("F2",CultureInfo.InvariantCulture));
            }

            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("|                                                                 |");
            Console.WriteLine("|                   Aula 30- Função                               |");
            Console.WriteLine("|                                                                 |");
            Console.WriteLine("-------------------------------------------------------------------");
            //Fazer um programa para ler três números inteiros e mostrar na tela o maior deles
            //Digite três números:
            //5 8 3
            //Maior = 8
            //static void main é uma função
            // o programa pode ter várias funções
            // 
            /*int _a = int.Parse(Console.ReadLine());
            int _b = int.Parse(Console.ReadLine());
            int _c = int.Parse(Console.ReadLine());

            double resultado = Maior(_a, _b, _c);
            Console.WriteLine("Maior = " + resultado);


            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("|                                                                 |");
            Console.WriteLine("|                   Aula 31- Debugging com VS                     |");
            Console.WriteLine("|                                                                 |");
            Console.WriteLine("-------------------------------------------------------------------");

            //Para marcar o inicio do debugging, aperte F9 para marcar  o break point , F5 Para começar, F10 depois do break point
            /*
            int _a = int.Parse(Console.ReadLine());
            int _b = int.Parse(Console.ReadLine());
            int _c = int.Parse(Console.ReadLine());

            double resultado = Maior(_a, _b, _c);
            Console.WriteLine("Maior = " + resultado);
           



            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("|                                                                 |");
            Console.WriteLine("|              Aula 32- Estrutura Repetitiva While                |");
            Console.WriteLine("|                                                                 |");
            Console.WriteLine("-------------------------------------------------------------------");
            //Regra V: Executa e volta F: Pula fora


            /* Console.Write("Digite um Número ");
             double x_ = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

             while (x_ >= 0)
             {
                 double raiz = Math.Sqrt(x_);
                 Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
                 Console.Write(" Digite outro número ");
                 x_ = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             }
             Console.WriteLine("Numero negativo");
          
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("|                                                                 |");
            Console.WriteLine("|              Aula 32- Estrutura Repetitiva FOR                  |");
            Console.WriteLine("|                                                                 |");
            Console.WriteLine("-------------------------------------------------------------------");

            //Digitar um número N e depois N valores inteiros. Mostrar a somados N valores digitados
            Console.Write("Quantos numeros inteiros você vai digitar: ");
            soma = 0;
            int _n1 = int.Parse(Console.ReadLine());
            for (int i = 1; i<= _n1; i++)
            {
                Console.WriteLine("VALOR  #{0} : ", i);
                int valor = int.Parse(Console.ReadLine());
                //soma= soma +valor; ou
                soma += valor;
            }
            Console.WriteLine("Soma = "+ soma);
   */

            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("|                                                                 |");
            Console.WriteLine("|      Exercícios sobre Estrutura Repetitiva (While)              |");
            Console.WriteLine("|                                                                 |");
            Console.WriteLine("-------------------------------------------------------------------");
            /* Ex 01 -Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha
incorreta informada, escrever a mensagem "Senha Invalida". Quando a senha for informada corretamente deve ser
impressa a mensagem "Acesso Permitido" e o algoritmo encerrado. Considere que a senha correta é o valor 2002.

            Console.Write("Digite sua senha : ");
            int senha = int.Parse(Console.ReadLine());
            while (senha != 2002)
            {
                Console.WriteLine("Senha Incorreta!!!");
                senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(" ACESSO PERMITIDO!!!");*/


            /*Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema
            cartesiano. Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo
            menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma).

            Console.Write("Digite os valores de X e Y : ");
            string[] valores = Console.ReadLine().Split(' ');
            int x = int.Parse(valores[0]);
            int y = int.Parse(valores[1]);

            while( x!=0 && y!=0)
            {
                if(x>0 && y > 0)
                {
                    Console.WriteLine("Primeiro Quadrante");
                }
                else if (x<0 && y > 0)
                {
                    Console.WriteLine("Segundo Quadrante");
                }
                else if (x<0 && y<0)
                {
                    Console.WriteLine("Terceiro Quadrante");
                }else if (x>0 && y<0)
                {
                    Console.WriteLine("Quarto Quadrante");
                }
                Console.Write("Digite novamente valores de X e Y : ");
                valores = Console.ReadLine().Split(' ');
                x = int.Parse(valores[0]);
                y = int.Parse(valores[1]);

            }
            Console.WriteLine("Sem Mensagem");*/


            /*Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva
            um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel
            4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até
            que seja válido). O programa será encerrado quando o código informado for o número 4. Deve ser escrito a
            mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme
            exemplo.

            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            Console.WriteLine("1. Alcool");
            Console.WriteLine("2. Gasolina");
            Console.WriteLine("3. Diesel");
            Console.WriteLine("4. Fim");
            int escolha = int.Parse(Console.ReadLine());

            while (escolha != 4)
            {
                if (escolha == 1)
                {
                    Console.WriteLine("Alcool");
                    alcool++;
                }
                else if (escolha == 2)
                {
                    Console.WriteLine("Gasolina");
                    gasolina++;
                }
                else if (escolha == 3)
                {
                    Console.WriteLine("Diesel");
                    diesel++;
                }
                else
                {
                    Console.WriteLine("Numero incorreto");
                }
                escolha = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);

            Console.WriteLine("Fim");*/
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("|                                                                 |");
            Console.WriteLine("|      Exercícios sobre Estrutura Repetitiva (FOR)                |");
            Console.WriteLine("|                                                                 |");
            Console.WriteLine("-------------------------------------------------------------------");
            /*Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o
X, se for o caso.

            
            Console.Write(" Digite um valor inteiro : ");
            int x = int.Parse(Console.ReadLine());
            while(x<0 || x > 1000)
            {
                Console.WriteLine("Digite Novamente");
                x = int.Parse(Console.ReadLine());
            }
            for(int i=1; i <= x; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("O número {0} é par",i);
                }
            }
            Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
        Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando
        essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).
            

            int _in = 0;
            int _out = 0;
            
            
            Console.Write("Digite quantas vezes vai repetir: ");
            int valor = int.Parse(Console.ReadLine());
            for(int i =0; i<valor; i++)
            {

                Console.Write("Digite um número: ");
                int numero = int.Parse(Console.ReadLine());

                if (numero>=10 && numero <= 20)
                {
                    _in++;
                }
                else
                {
                    _out++;
                }
            }
            Console.WriteLine("Dentro de 10 a 20 : "+_in);
            Console.Write("Fora do RANGE : " + _out);

            Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste
            de 3 valores reais, cada um deles com uma casa decimal.Apresente a média ponderada para cada um destes
            conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem
            peso 5. 

            Console.WriteLine("Digite o número de casos de testes");
            double soma = 0;
            double n1 = 0;
            double n2 = 0;
            double n3 = 0;
            int teste = int.Parse(Console.ReadLine());

            for (int i = 0; i < teste; i++)
            {
                Console.WriteLine("Digite 3 numeros.");
                string[] valores = Console.ReadLine().Split(' ');
                n1 = double.Parse(valores[0],CultureInfo.InvariantCulture);
                n2 = double.Parse(valores[1],CultureInfo.InvariantCulture);
                n3 = double.Parse(valores[2],CultureInfo.InvariantCulture);

                //n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                //n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                // n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                soma = ((n1 * 2.0) + (n2 * 3) + (n3 * 5)) / 10;
                Console.WriteLine("Média: " + soma.ToString("F1", CultureInfo.InvariantCulture));
            }

            //Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo
            //segundo.Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel".

            Console.WriteLine(" Digite um número: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < x; i++)
            {
                Console.Write("Digite o primeiro núm: ");
                int n1 = int.Parse(Console.ReadLine());
                Console.Write("Digite o segundo num: ");
                int n2 = int.Parse(Console.ReadLine());
                if (n2 == 0)
                {
                    Console.WriteLine("Divisão impossível");


                }
                else
                {
                    double soma = (double)n1 / n2;
                    Console.WriteLine("A divisão é: " + soma.ToString("F1", CultureInfo.InvariantCulture));
           

            int fat = 1;
            Console.Write("Digite um número: ");
            int x = int.Parse(Console.ReadLine());

            for(int i = 1; i<=x; i++)
            {
                fat = fat * i;

            }
            Console.WriteLine("O valor de fat é :"+fat);

                }
            //Ler um número inteiro N e calcular todos os seus divisores.


            Console.Write("Digite um número: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                if (x % i == 0)
                {
                    
                    int soma= x / i;

                    Console.WriteLine("{0} /{1} = {2}",x,i,soma);
                }

            }
            Fazer um programa para ler um número inteiro positivo N. O programa deve então mostrar na tela N linhas,
começando de 1 até N. Para cada linha, mostrar o número da linha, depois o quadrado e o cubo do valor, conforme
exemplo.
             */
            Console.WriteLine("Digite um número inteiro positivo");
            int x = int.Parse(Console.ReadLine());
            while (x < 0)
            {
                Console.WriteLine("ERRO! Não digite números negativos");
                x = int.Parse(Console.ReadLine());
            }
            for(int i=1; i <= x; i++)
            {
                if( i == 1){
                Console.WriteLine("{0} {0} {0}", i);
                }
                else
                {
                    int quad=2;
                    int cubo=3;
                    Console.WriteLine(i+" "+Math.Pow(i, quad)+" "+ Math.Pow(i, cubo));
               


                }
               
            }



        }




        static int Maior(int a, int b, int c) // static? vai ser explicado na parte de orientação objeto
        {
            int m;
            if (a > b && a > c)
            {
                m = a;
            }
            else if (b > c)
            {
                m = b;
            }
            else
            {
                m = c;
            }
            return m;
        }
    }
}

