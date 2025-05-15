using System;
using System.Collections.Generic;
namespace ProjetoRelatorioPedido.Classes
{
    public class Pedido
    {
        public List<Produto> Produto { get; set; } = new List<Produto>(); // cria uma lista do tipo Classe Produto, contendo ja os atributos Nome e Preço

        public void AdicionarProdutos(Produto produto){
            Produto.Add(produto);

            Console.WriteLine($"Produto: {produto.Nome} adicionado!");
        }

        public void RemoverProduto(Produto produto){
            Produto.Remove(produto);
            Console.WriteLine($"Produto: {produto.Nome} Removido!");
        }

        public void ListarProdutos(){
            double totalPedido = 0;

            if (Produto.Count == 0)
            {
                Console.WriteLine("Nenhum produto adicionado!");
            }
            else
            {
                for (int i = 0; i < Produto.Count; i++)
                {
                    Console.WriteLine("Nome: "+Produto[i].Nome);
                    Console.WriteLine("Preço: "+Produto[i].Preco.ToString("C"));

                    totalPedido += Produto[i].Preco;
                }

                Console.WriteLine("Total do pedido: "+totalPedido.ToString("C"));
            }

        }
    }
}