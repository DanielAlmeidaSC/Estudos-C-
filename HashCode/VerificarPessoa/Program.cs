using System;
using System.Collections.Generic;

namespace VerificarPessoa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<Pessoa> pessoas = new HashSet<Pessoa>();

            pessoas.Add(new Pessoa("Daniel", 1446245594));
            pessoas.Add(new Pessoa("Nerci", 67518453285));
            pessoas.Add(new Pessoa("Daniel", 1446245594)); //Não vai aparecer pois foi duplicado

            Console.WriteLine("Pessoas no HASHSET:");

            foreach (Pessoa pessoa in pessoas)
            {
                Console.WriteLine(pessoa.ToString());
            }


        }
    }
}