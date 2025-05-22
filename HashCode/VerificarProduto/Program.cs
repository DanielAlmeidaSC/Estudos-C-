using System;
using System.Collections.Generic;

namespace VerificarProduto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<Produto> produtos = new HashSet<Produto>();
            produtos.Add(new Produto(1, "Coca-cola"));

            HashSet<Produto> pepsi = new HashSet<Produto>();
            pepsi.Add(new Produto(2, "Pepsi-Cola"));

            //Console.WriteLine(Pepsi.Equals(produtos)); Verifica se são as mesmas istancias de objetos, no caso vai ser false pq Pepsi é uma instancia e Produtos é outra, apesar de ter o msm id
            Console.WriteLine(pepsi.SetEquals(produtos)); //Verifica se o conteúdo de dois objetos são iguais
            
        }
    }
}