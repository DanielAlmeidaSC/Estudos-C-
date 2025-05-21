using System;
using System.IO;

namespace LerConteudoEImprimir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string caminho = @"D:\Estudos C#\Arquivos\Arquivos-Para-Uso\combinado.txt";

            
            // Ler todo o conteúdo de um arquivo texto e imprimir na tela.

            try
            {
                using (StreamReader lerConteudo = new StreamReader(caminho))
                {
                    Console.WriteLine(lerConteudo.ReadToEnd());
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
        }
    }
}
