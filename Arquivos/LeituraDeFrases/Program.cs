using System;
using System.IO;

namespace LeituraDeFrases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie um programa que pergunte ao usuário uma frase e a escreva em um arquivo chamado mensagem.txt.
            Console.WriteLine("Digite uma frase: ");
            string frase = Console.ReadLine() ?? "0";

            try
            {
                string localDoArquivo = @"D:\Estudos C#\Arquivos\Arquivos-Para-Uso\Atividade1.txt";// diretório pra pasta
                File.WriteAllText(localDoArquivo, frase); //cria o arquivo e escreve a frase armazenada


            }
            catch (IOException e)
            {
                Console.WriteLine("Ocorreu um erro: "+e.Message);
            }
        }
    }
}