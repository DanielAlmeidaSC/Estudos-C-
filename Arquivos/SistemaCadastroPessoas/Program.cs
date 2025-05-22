using System;
using System.IO;
using SistemaCadastroPessoas.Entities;


namespace SistemaCadastroPessoas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Estudos C#\Arquivos\SistemaCadastroPessoas\ArquivoDoSistema\cadastro.txt";

            Cadastro cadastro = new Cadastro();

            Console.Write("Você deseja adicionar alguma pessoa ao Cadastro (S/N): ");
            char escolha = char.Parse(Console.ReadLine() ?? "0");

            escolha = char.ToUpper(escolha);

            while (escolha == 'S')
            {
                Console.Write("Nome: ");
                string nome = Console.ReadLine() ?? "0";

                Console.Write("Idade: ");
                int idade = int.Parse(Console.ReadLine() ?? "0");

                Console.Write("Cidade: ");
                string cidade = Console.ReadLine() ?? "0";

                Console.Write("Estado: ");
                string estado = Console.ReadLine() ?? "0";

                Endereco endereco = new Endereco(cidade, estado);

                Pessoa pessoa = new Pessoa(nome, idade, endereco);

                cadastro.AdicionarPessoa(pessoa);

                string enviarAoDoc = $"Nome: [{nome}] | Idade: [{idade}] | Cidade: [{cidade}] | Estado: [{estado}]";
                try
                {
                    using (StreamWriter escritor = new StreamWriter(path, append: true))
                    {
                        escritor.WriteLine(enviarAoDoc);
                    }

                }
                catch (IOException e)
                {
                    Console.WriteLine("Erro: "+e.Message);
                }

                Console.Write("Você deseja adicionar alguma pessoa ao Cadastro (S/N): ");
                escolha = char.Parse(Console.ReadLine() ?? "0");
                escolha = char.ToUpper(escolha);

            }

            cadastro.ImprimirLista();


        }
    }
}