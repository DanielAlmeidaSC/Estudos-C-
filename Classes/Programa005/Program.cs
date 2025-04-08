using System;
using System.Globalization;
using Programa005;

Produto produto = new Produto();

Console.WriteLine("Digite o nome do produto: ");
produto.Nome = Console.ReadLine()?? "0";

Console.WriteLine("Digite o preço do produto: ");
produto.Preco = double.Parse(Console.ReadLine()?? "0", CultureInfo.InvariantCulture);

Console.WriteLine("Digite a quantidade que está em estoque: ");
produto.Quantidade = int.Parse(Console.ReadLine()?? "0");

produto.MostrarInformacoes();

Console.WriteLine("Você deseja adicionar produtos: ");
string opcao = Console.ReadLine()?? "0";


if (opcao == "sim" || opcao == "Sim")
{
    Console.WriteLine("Qual a quantidade que você deseja adicionar: ");
    int quantidadeAdicionar = int.Parse(Console.ReadLine()?? "0");

    produto.AdicionarProdutos(quantidadeAdicionar);
}

Console.WriteLine("Informações atualizadas: ");
produto.MostrarInformacoes();
