using System;

namespace Programa002 {
    internal class Program {
        static void Main(string[] args) {

            Preco preco = new Preco(250.00, 50);
            Produto produto1 = new Produto("Clear", "Shampoo", preco);

            produto1.ExibirDados();
        }
    }
}