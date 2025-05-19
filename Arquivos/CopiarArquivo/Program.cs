using System;
using System.IO;

namespace CopiarArquivo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Peça ao usuário o caminho de um arquivo e um novo destino. Copie o arquivo usando File.Copy() ou FileInfo.CopyTo().

            Console.Write("Digite o caminho de um arquivo: ");
            string caminho = Console.ReadLine() ?? "0";

            Console.Write("Digite um novo destino para a cópia do arquivo: ");
            string novoCaminho = Console.ReadLine() ?? "0";

            Console.Write("Digite o nome do arquivo: ");
            string nomeArquivoNovo = Console.ReadLine()??"0";

            string novoCaminhoCompleto = @$"{novoCaminho}{nomeArquivoNovo}";


            try
            {
                if (File.Exists(caminho))
                {
                    File.Copy(caminho, novoCaminhoCompleto); //copia o arquivo de origem no novo caminho especificado
                    Console.WriteLine("Arquivo copiado com sucesso!");
                }
                else
                {
                    Console.WriteLine("Arquivo de não encontrado");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
        }
    }
}