using System.Collections.Generic;

namespace SistemaCadastroProdutoComEstoqueECategorias.Entities
{
    public class Loja
    {
        public Dictionary<string, Produto> Estoque { get; set; } = new Dictionary<string, Produto>();
        public void AdicionarProdutos(string nome, string categoria, double preco, int quantidade)
        {
            if (Estoque.ContainsKey(nome)) //Verificação se o nome existe, se existir, ele só vai aumentar a quantidade
            {
                Estoque.Add(nome, new Produto(quantidade)); // só vai aumentar a quantidade se o nome digitado existir
            }
            else
            {
                Estoque.Add(nome, new Produto(nome, categoria, preco, quantidade)); // se não existir, ele vai criar um novo produto
            }
        }

        public void RemoverProdutos(string nome, int quantidade)
        {
            if (!Estoque.ContainsKey(nome))
            {
                Console.WriteLine("Erro! Produto não está no estoque.");
                return;
            }

            Produto produto = Estoque[nome];

            if (quantidade <= 0)
            {
                Console.WriteLine("Erro! Quantidade a remover deve ser maior que zero.");
                return;
            }

            if (produto.Quantidade < quantidade)
            {
                Console.WriteLine("Erro! Quantidade a remover é maior que a disponível.");
                return;
            }

            produto.Quantidade -= quantidade;

            //If para remover produto totalmente do estoque caso a quantidade for 0
            if (produto.Quantidade == 0)
            {
                Estoque.Remove(nome);
                Console.WriteLine($"Produto '{nome}' removido completamente do estoque.");
            }
            else
            {
                Console.WriteLine($"Quantidade atual do produto '{nome}': {produto.Quantidade}");
            }
        }

    }
}