using System;
using ProjetoRelatorioPedido.Classes;

namespace ProjetoRelatorioPedido
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Você deseja adicionar produtos ao carrinho? ");
            string opcao = Console.ReadLine()??"0";

            opcao = opcao.ToUpper();

            if (opcao == "SIM")
            {   
                Console.WriteLine("Você deseja adicionar quantos produtos: ");
                int quantidadeParaAdicionar = int.Parse(Console.ReadLine()??"0");

                Pedido pedido = new Pedido(); //cria só um pedido

                for (int i = 0; i < quantidadeParaAdicionar; i++)
                {
                    Produto NovoProduto = new Produto(); //cria um novo objeto a cada iteração

                    Console.WriteLine("Digite o nome do pedido: ");
                    NovoProduto.Nome = Console.ReadLine()??"0";

                    Console.WriteLine("Digite o preço do pedido: ");
                    NovoProduto.Preco = double.Parse(Console.ReadLine()??"0");

                    pedido.AdicionarProdutos(NovoProduto);
                }
                Console.WriteLine("------------------------");
                pedido.ListarProdutos();
                
            }
            else
            {
                Console.WriteLine("Saindo...");
            }

        }
    }
}