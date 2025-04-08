using System;

namespace Programa002{
    internal class Program
    {
        static void Main()
        
        {
            Produto p1 = new Produto("Camiseta");
            Produto p2 = new Produto("Tênis", 199.99);

            Console.WriteLine("Produto 1:");
            p1.Mostrar();

            Console.WriteLine("\nProduto 2:");
            p2.Mostrar();
        }
    }
}
