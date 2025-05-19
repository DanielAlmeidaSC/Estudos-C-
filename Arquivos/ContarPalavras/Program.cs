using System;
using System.IO;

namespace ContarPalavras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string caminhoArquivo = @"D:\Estudos C#\Arquivos\Arquivos-Para-Uso\Atividade1.txt";

            try
            {
                // string[] separarPalavras = File.ReadAllText(caminhoArquivo) não dará certo, pq o método File.ReadAllText() precisa de um caminho como argumento, e ele retorna uma string, não um string[].
                string palavrasNoArquivo = File.ReadAllText(caminhoArquivo); // lê todo o conteúdo do arquivo como uma string.

                string[] separarPalavras = palavrasNoArquivo.Split(" ", ',');

                int contadorPalavra = 1;
                foreach (string palavra in separarPalavras)
                {
                    Console.WriteLine(""+palavra);
                    contadorPalavra++;
                }

                Console.WriteLine("Quantidade de palavras: "+contadorPalavra);

            }
            catch (IOException e)
            {

                Console.WriteLine("Erro: " + e.Message);
            }
        }
    }
}