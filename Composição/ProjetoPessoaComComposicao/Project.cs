using System;
using ProjetoPessoaComComposicao;

namespace Project
{
    public class ProjetoParaRodar
    {
        static void Main(string[] args)
        {
           Console.Write("Digite o nome: ");
           string nome = Console.ReadLine()??"0";

           Console.Write("Digite sua idade: ");
           int idade = int.Parse(Console.ReadLine()??"0");

           Console.WriteLine("Digite seu endereço no formato (Rua, Cidade, Estado, CEP): ");
           string endereco = Console.ReadLine()??"";
           string[] enderecoInformado = endereco.Split(", ");


            string rua = enderecoInformado[0];
            string cidade = enderecoInformado[1];
            string estado = enderecoInformado[2];
            int cep = int.Parse(enderecoInformado[3]);

            Endereco endereco1 = new Endereco(rua, cidade, estado, cep);
            Pessoa pessoa = new Pessoa(nome, idade, endereco1);

            Console.WriteLine(pessoa);

        }
    }
}