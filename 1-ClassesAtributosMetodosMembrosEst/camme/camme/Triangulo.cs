using System;

namespace camme
{
    class Triangulo
    {
        public double A; // o prefixo public indica que o atributo ou método pode ser usado em outros arquivos
        public double B;
        public double C;
        public double Area()//double é o tipo de dado que o método retorna(se o método não retorna nada, usa-se a palavra "void"
                            // area é o nome do método
                            //()Lista de parametros do método
        {
            double p = (A + B + C) / 2.0;//corpo do método
            return  Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

    }
   // Discussão
   /*Quais são os benefícios de se calcular a área de um triângulo por meio de um método dentro da classe triangulo?
    * 1)Reaproveitamento de código: Eu elimei o código repetido(cálculo das áreas dos triângulos x e y) no programa principal
    * 2)Delegação de responsabilidades: Quem deve ser responsável por saber como calcular a área de um triangulo é o próprio triangulo.
    * A lógica do cálculo da área não deve estar em outro lugar.*/
}
