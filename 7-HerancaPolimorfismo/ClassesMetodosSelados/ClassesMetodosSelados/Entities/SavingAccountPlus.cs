using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesMetodosSelados.Entities
{
    class SavingAccountPlus: SavingsAccount // SE O SEALED ESTIVER NA ACCOUNT VAI OCOORER UM ERRO, POIS NÃO É POSSÍVEL HERDAR de uma classe que esteja selada, serve para proteger alguma regra de negocio
    {
        override //NÃO FUNCIONA A OPERAÇÃO WITHDRAW, PQ ESTÁ SELADA
    }
}
