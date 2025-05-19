using System;
using System.IO;

namespace LerConteudo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Leia o conteúdo do arquivo mensagem.txt criado no exercício anterior e exiba-o no console.

            string diretorio = @"D:\Estudos C#\Arquivos\Arquivos-Para-Uso\Atividade1.txt";

            try
            {

                string[] texto = File.ReadAllLines(diretorio); //vai criar um array do que há escrito em todas as linhas;

                int contadorLinha = 1;
                foreach (string linha in texto)
                {
                    Console.WriteLine(contadorLinha + "° linha: " + linha);
                    contadorLinha++;
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Ocorreu um erro: "+e.Message);
            }

            
        }
    }
}