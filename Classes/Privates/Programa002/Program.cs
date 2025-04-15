using System;
using System.Globalization;

namespace Programa002 {
    internal class Program {
        static void Main(string[] args) {
            Produto produto1 = new Produto();

            Console.WriteLine("Digite o nome do produto: ");
            string nome = Console.ReadLine()??"0";

            Console.WriteLine("Digite o preço do produto: ");
            double preco = double.Parse(Console.ReadLine()??"0", CultureInfo.InvariantCulture);

            Console.WriteLine("Digite a quantidade: ");
            int quantidade = int.Parse(Console.ReadLine()??"0");

            produto1.AlterarNome = nome;
            produto1.AlterarPreco = preco;
            produto1.AlterarQuantidade = quantidade;

            produto1.MostrarValores();

        }
    }
}