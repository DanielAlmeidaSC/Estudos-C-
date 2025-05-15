using System;
using ProjetoBiblioteca.Classes;

namespace ProjetoBiblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();

            Console.WriteLine("Bem-vindo à biblioteca!");

            Console.WriteLine("Você deseja adicionar livros: ");
            string opcaoAdicionar = Console.ReadLine()??"0";

            opcaoAdicionar = opcaoAdicionar.ToLower();
            
            if (opcaoAdicionar  == "sim")
            {
                Console.WriteLine("Quantos livros você deseja adicionar: ");
                int quantidadeParaAdd = int.Parse(Console.ReadLine()??"0");

                for (int i = 0; i < quantidadeParaAdd; i++)
                {
                    Console.WriteLine("Digite o nome do {0}° livro: ", i+1);
                    string nome = Console.ReadLine()??"0";

                    Console.WriteLine("Digite o nome do {0}° autor: ", i+1);
                    string autor = Console.ReadLine()??"0";

                    biblioteca.AdicionarLivros(nome, autor);
                }    

                Console.WriteLine("Você deseja excluir livros: ");
                string opcaoRemover = Console.ReadLine()??"0";


                opcaoRemover = opcaoRemover.ToLower();

                if (opcaoRemover == "sim")
                {
                    Console.WriteLine("Quantos livros você deseja remover: ");
                    int quantidadeParaRemover = int.Parse(Console.ReadLine()??"0");

                    for (int i = 0; i < quantidadeParaRemover; i++)
                    {
                        Console.WriteLine("Digite o nome do {0}° livro: ", i+1);
                        string nome = Console.ReadLine()??"0";

                        Console.WriteLine("Digite o nome do {0}° autor: ", i+1);
                        string autor = Console.ReadLine()??"0";

                        biblioteca.RemoverLivros(nome, autor);
                    }    
                    
                }
            }
            else
            {
                Console.WriteLine("Saindo....");
            }

            biblioteca.ListarLivros();
        }
    }
}