using System;
using OrdenarPorIdade.Entities;

namespace OrdenarPorIdade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa0 = new Pessoa("Daniel Almeida", 20);
            Pessoa pessoa1 = new Pessoa("Daniella Almeida", 22);
            Pessoa pessoa2 = new Pessoa("Nerci Ribeiro", 54);
            Pessoa pessoa3 = new Pessoa("Marcos Almeida", 43);
            Pessoa pessoa4 = new Pessoa("Marcos Davi", 30);
            Pessoa pessoa5 = new Pessoa("Jessica Ribeiro", 34);

            int resultado0 = pessoa0.CompareTo(pessoa1);
            int resultado1 = pessoa1.CompareTo(pessoa2);
            int resultado2 = pessoa2.CompareTo(pessoa3);
            int resultado3 = pessoa3.CompareTo(pessoa4);
            int resultado4 = pessoa4.CompareTo(pessoa5);


            Console.WriteLine(" "+resultado0+" "+resultado1+" "+resultado2+" "+resultado3+" "+resultado4+" ");

        }
    }
}