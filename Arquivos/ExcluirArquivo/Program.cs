using System;
using System.IO;

namespace ExcluirArquivo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicite ao usuário o nome de um arquivo e exclua-o se ele existir, mostrando uma mensagem de confirmação.

            Console.Write("Digite o caminho de um arquivo: ");
            string origem = Console.ReadLine() ?? "0";
            
            try
            {
                if (File.Exists(origem))
                {
                    File.Delete(origem);
                    
                    Console.WriteLine("Arquivo excluído com sucesso!");
                }
                else
                {
                    Console.WriteLine("Arquivo não encontrado!");
                }
            }
            catch (IOException e)
            {
                
                Console.WriteLine("Erro: "+e.Message);
            }
        }
    }
}