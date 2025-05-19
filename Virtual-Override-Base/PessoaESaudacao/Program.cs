using System;
using PessoaESaudacao.Entities;

namespace PessoaESaudacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Brasileiro(); // cria um brasileiro do tipo pessoa
            Console.WriteLine(pessoa.Saudar()); // só vai imprimir personalizado do tipo brasileiro se for sobrescrito, se não for, ele vai imprimir do jeito do tipo pessoa


        }
    }
}