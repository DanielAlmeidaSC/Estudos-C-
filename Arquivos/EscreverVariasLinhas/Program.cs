using System;
using System.IO;

namespace EscreverVariasLinhas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Peça para o usuário digitar 5 linhas de texto e grave todas em um arquivo chamado linhas.txt, uma por linha.
            try
            {
                string origem = @"D:\Estudos C#\Arquivos\Arquivos-Para-Uso\linhas.txt";
                File.WriteAllText(origem, " ");

                string[] linhas = new string[5];

                for (int i = 0; i < linhas.Length; i++)
                {
                    Console.WriteLine("Digite a {0}° linha", i + 1);
                    linhas[i] = Console.ReadLine() ?? "0";

                }

                File.WriteAllLines(origem, linhas);//escreve varias linhas de uma vez, se quiser escrever uma unica linha, utilize somente o string, sem array
                Console.WriteLine("Arquivo criado com sucesso!");
            }
            catch (IOException e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
        }
    }
}