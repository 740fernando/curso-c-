﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;
        public Produto()
        {

        }
        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        /*public Produto(string nome, double preco, int quantidade)
         {
             Nome = nome;
             Preco = preco;
             Quantidade = quantidade;
         }*/

    
        /*public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = 5;
        }*/

        //sintaxe alternativa para iniciar valores

       /* public Produto()
        {
            Nome = "TV";
            Preco = 500.00;
            Quantidade = 20;
        }*/
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return Nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

            
        }
    }
}