

using System;

namespace Prj_Reserva_Final.Entities.Exceptions
{
    class DomainException : ApplicationException // DomainException é um subclasse do AplicationExpection
    {
        // O modelo de tratamento de exceções permite que erros sejam tratados de forma consistente e flexível, usando boas práticas
        //Vantagens:
        // - Lógica delegada
        // - Construtores podem ter exceções
        // - Código mais simples. Não há aninhamento de condicionais : a qualquer momento quee uma  exceção for disparada, a execução é interrompida e cai no
        // bloco catch correspondente
        // - É possível capturar inclusive outras exceções de sistemas
        public DomainException(string message) : base(message) //construtor
        {

        }
    }
}

