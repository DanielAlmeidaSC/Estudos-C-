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

            pessoas.Sort((nome1, nome2) =>
            {
                if (nome1.Nome == null && nome2.Nome == null)
                    return 0;

                if (nome1.Nome == null)
                    return 1;

                if (nome2.Nome == null)
                    return -1;


                return nome1.Nome.CompareTo(nome2.Nome);
            });

            Console.WriteLine("Ordenando por nome:\n");
            Console.WriteLine($"{"Nome",-15} {"Idade",10}");

            Console.WriteLine("-----------------------------------------");

            foreach (Pessoa pessoa in pessoas)
            {
                Console.WriteLine($"{pessoa.Nome,-15} {pessoa.Idade,10}");
            }

            pessoas.Sort((idade1, idade2) => idade1.Idade.CompareTo(idade2.Idade));

            Console.WriteLine("\nOrdenando por idade:\n");
            Console.WriteLine($"{"Nome",-15} {"Idade",10}");
            Console.WriteLine("-----------------------------------------");

            foreach (Pessoa pessoa in pessoas)
            {
                Console.WriteLine($"{pessoa.Nome,-15} {pessoa.Idade,10}");
            }
        }
    }
}