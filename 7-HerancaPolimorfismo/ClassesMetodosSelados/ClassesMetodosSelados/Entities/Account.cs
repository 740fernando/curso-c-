﻿

namespace ClassesMetodosSelados.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }
        public void Deposit(double amount)// public sealed void Deposit(double amount) - Exibe mensagem de erro, pois não é possivel selar uma classe que não foi sobreposta
        {
            Balance += amount;
        }

        public virtual void WithDraw(double amount)
        {
            Balance -= amount+5.0;
        }
    }
}
