using System;
using System.Collections.Generic;

namespace OrdenarPorPreco
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Produto> produtos = new List<Produto>();

            produtos.Add(new Produto("Coca-Cola", 10.0));
            produtos.Add(new Produto("Pepsi-Cola", 09.0));
            produtos.Add(new Produto("Rexona", 12.0));
            produtos.Add(new Produto("AXE", 15.0));

            produtos.Sort();

            foreach (Produto produto in produtos)
            {
                Console.WriteLine("Nome: "+produto.Nome);
                Console.WriteLine("Preço: "+produto.Preco.ToString("C"));
            }
        }
    }
}