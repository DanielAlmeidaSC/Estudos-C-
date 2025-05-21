using System;
using System.IO;

namespace ContadorDeLinhas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Peça o nome de um arquivo .txt e exiba quantas linhas ele possui.
            Console.Clear();
            Console.Write("Digite o nome de um arquivo que está dentro da pasta (-> Estudos C# -> Arquivos -> Arquivos-Para-Uso): ");
            string arquivo = Console.ReadLine() ?? "0";

            string caminhoCompleto = @$"D:\Estudos C#\Arquivos\Arquivos-Para-Uso\{arquivo}";

            try
            {
                if (File.Exists(caminhoCompleto))
                {
                    string[] conteudoArquivo = File.ReadAllLines(caminhoCompleto);

                    int contadorLinhas = 0;
                    for (int i = 0; i < conteudoArquivo.Length; i++)
                    {
                        contadorLinhas++;
                    }

                    Console.WriteLine("Quantidade de linhas dentro do arquivo: "+contadorLinhas);
                }
                else
                {
                    Console.WriteLine("Erro! Arquivo não encontrado!");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error! " + e.Message);
            }
            

        }
    }
}