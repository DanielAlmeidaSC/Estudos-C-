using System;
using System.Globalization;
using ProdutoEProdutoImportado.Entities;

namespace ProdutoEProdutoImportado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome do produto: ");
            string nome = Console.ReadLine() ?? "0";

            Console.WriteLine("Digite o preço do produto: ");
            double preco = double.Parse(Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);

            Console.WriteLine("É um produto importado: ");
            string opcao = Console.ReadLine() ?? "0";

            opcao = opcao.ToLower();

            if (opcao == "sim")
            {
                Console.WriteLine("Digite a taxa de importação: ");
                double taxa = double.Parse(Console.ReadLine() ?? "0");

                taxa = taxa / 100;

                ProdutoImportado produtoImportado = new ProdutoImportado(taxa, nome, preco);
                Console.WriteLine($"Nome do produto: {produtoImportado.Nome} ");
                Console.WriteLine($"Preço do produto: {produtoImportado.ValorFinalImportacao().ToString("C")} ");
                Console.WriteLine($"Taxa de Importação: {produtoImportado.TaxaDeImportacao * 100}% ");
            }
            else if (opcao == "não")
            {
                Produto produto = new Produto(nome, preco);

                Console.WriteLine($"Nome do produto: {produto.Nome} ");
                Console.WriteLine($"Preço do produto: {produto.Preco.ToString("C")} ");
            }
            else
            {
                Console.WriteLine("Opção inválida!");
            }
        }
    }
}