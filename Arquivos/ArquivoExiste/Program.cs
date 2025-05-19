using System;
using System.IO;

namespace ArquivoExiste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string diretorio = @"D:\Estudos C#\Arquivos\Arquivos-Para-Uso\";

            Console.WriteLine("Dentro da pasta Arquivos-Para-Uso, procure um arquivo pelo nome: ");
            string nomeArquivo = Console.ReadLine() ?? "0";

            string caminhoCompleto = @$"D:\Estudos C#\Arquivos\Arquivos-Para-Uso\{nomeArquivo}"; //junta o diretório com o nome do arquivo

            if (File.Exists(caminhoCompleto))
            {
                Console.WriteLine("O arquivo existe!");
            }
            else
            {
                Console.WriteLine("O arquivo não existe!");

                try
                {
                    File.WriteAllText(caminhoCompleto, " "); //cria um arquivo sem texto

                    Console.WriteLine("Arquivo criado!");
                }
                catch (IOException e)
                {

                    Console.WriteLine("Não foi possível criar o arquivo pelo seguinte erro: " + e.Message);
                }
            }
        }
    }
}