using System;
using System.Collections.Generic;
using OrdenarPessoa.Entities;

namespace OrdenarPessoa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            List<Pessoa> pessoas = new List<Pessoa>();
            pessoas.Add(new Pessoa("Fernanda", 54));
            pessoas.Add(new Pessoa("Bruno", 36));
            pessoas.Add(new Pessoa("Ana", 11));
            pessoas.Add(new Pessoa("Lucas", 23));
            pessoas.Add(new Pessoa("Juliana", 65));
            pessoas.Add(new Pessoa("Eduardo", 72));
            pessoas.Add(new Pessoa("Patrícia", 44));
            pessoas.Add(new Pessoa("Rafael", 30));
            pessoas.Add(new Pessoa("Beatriz", 18));

            Console.WriteLine("Ordenando por nome:");
            
            Console.WriteLine($"{"Nome:",-15} {"Idade: ",15}");
            Console.WriteLine("---------------------------------------");


            pessoas.Sort(Pessoa.OrdenarPorNome);

            foreach (Pessoa pessoa in pessoas)
            {
                Console.WriteLine($"{pessoa.Nome,-15} {pessoa.Idade,10}");
            }


            Console.WriteLine("Ordenando por idade: ");
            Console.WriteLine($"{"Nome:",-15} {"Idade: ",15}");
            Console.WriteLine("---------------------------------------");

            pessoas.Sort(Pessoa.OrdenarPorIdade);

            foreach (Pessoa pessoa in pessoas)
            {
                Console.WriteLine($"{pessoa.Nome,-15} {pessoa.Idade,10}");
            }

        }
    }
}