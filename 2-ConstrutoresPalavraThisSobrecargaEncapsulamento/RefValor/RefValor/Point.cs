
namespace RefValor
{
    struct Point
    {
        //Variáveis cujo tipo são classes não devem ser entendidas como caixas, mas sim
        //“tentáculos” (ponteiros) para caixas

        //A linguagem C# possui também tipos valor, que são os "structs". Structs são CAIXAS e
        //não ponteiros.
        public double X, Y;
        public override string ToString()
        {
            return "(" + X + "," + Y + ")";
        }
    }
}
/*Valores padrão
• Quando alocamos (new) qualquer tipo estruturado (classe, struct,
array), são atribuídos valores padrão aos seus elementos
• números: 0
• bool: False
• char: caractere código 0
• objeto: null
• Lembrando: uma variável apenas declarada, mas não instanciada,
inicia em estado "não atribuída", e o próprio compilador não permite
que ela seja acessada.*/