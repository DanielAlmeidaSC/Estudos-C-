using System;
using System.IO;

namespace JuntarArquivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Peça dois nomes de arquivos de texto (arquivo1.txt e arquivo2.txt), leia o conteúdo de ambos e grave tudo em um novo arquivo chamado combinado.txt.

            Console.Clear();
            
            Console.WriteLine("**********************************************");
            Console.WriteLine("****************Disco Local D:****************");
            Console.WriteLine("**********************************************");

            Console.WriteLine("Cole aqui o local de origem dos arquivos: ");
            // Entrada: D:\Estudos C#\Arquivos\Arquivos-Para-Uso\
            string origemArquivo = Console.ReadLine() ?? "0";

            Console.Write("Digite o nome do primeiro arquivo da pasta ({0}): ", origemArquivo);
            string arquivo1 = Console.ReadLine() ?? "0";

            Console.Write("Digite o nome do segundo arquivo da pasta ({0}): ", origemArquivo);
            string arquivo2 = Console.ReadLine() ?? "0";

            string enderecoArquivo1 = @$"{origemArquivo}{arquivo1}";

            string enderecoArquivo2 = @$"{origemArquivo}{arquivo2}";

            try
            {
                if (Directory.Exists(origemArquivo))
                {
                    if (File.Exists(enderecoArquivo1) && File.Exists(enderecoArquivo2))
                    {
                        //cada linha lida é armazenada em um array. ReadAllLines precisa de algo para armazenar os seus valores
                        string[] lerArquivo1 = File.ReadAllLines(enderecoArquivo1);


                        Console.WriteLine("*********Conteúdo do primeiro arquivo:********");

                        foreach (string linhaArquivo1 in lerArquivo1)
                        {
                            Console.WriteLine(linhaArquivo1);
                        }

                        string[] lerArquivo2 = File.ReadAllLines(enderecoArquivo2);

                        Console.WriteLine("*********Conteúdo do segundo arquivo:*********");

                        foreach (string linhaArquivo2 in lerArquivo2)
                        {
                            Console.WriteLine(linhaArquivo2);
                        }

                        string[] juntarConteudo = lerArquivo1.Concat(lerArquivo2).ToArray(); //junta os arquivos para um novo array

                        Console.WriteLine("*********Junção de ambos os conteúdos:********");
                        foreach (string linhaNovoArquivo in juntarConteudo)
                        {
                            Console.WriteLine(linhaNovoArquivo);
                        }

                        string novoArquivo = @"D:\Estudos C#\Arquivos\Arquivos-Para-Uso\combinado.txt";

                        File.WriteAllLines(novoArquivo, juntarConteudo);

                        Console.WriteLine($"\nArquivo combinado criado com sucesso em: {novoArquivo}");

                    }
                    else
                    {
                        Console.WriteLine("Erro! Arquivos não encontrados, verifique e tente novamente!");
                    }
                }
                else
                {
                    Console.WriteLine("Erro! Diretório não encontrado, verifique e tente novamente!");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error! " + e.Message);
            }


        }
    }
}