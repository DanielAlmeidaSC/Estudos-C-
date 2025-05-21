using System;
using System.IO;

namespace LerEContar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ler um arquivo linha por linha e contar quantas linhas ele possui.
            string caminho = @"D:\Estudos C#\Arquivos\Arquivos-Para-Uso\combinado.txt";


            try
            {
                using (StreamReader rs = new StreamReader(caminho))
                {
                    int contadorLinha = 1;

                    while (!rs.EndOfStream)
                    {
                        string linha = rs.ReadLine()??"0";

                        Console.WriteLine("{0}° linha: {1}", contadorLinha, linha);

                        if (rs.EndOfStream)
                        {
                            break;
                        }
                        contadorLinha++;
                    }

                    Console.WriteLine("Quantidade de linhas: "+contadorLinha);

                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
        }
    }
}