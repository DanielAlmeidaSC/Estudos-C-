using System;

namespace Programa001 {
    internal class Program {
        static void Main(string[] args) {

            Pessoa pessoa1 = new Pessoa("Daniel Almeida", 20);

            Console.WriteLine("Nome: "+pessoa1.Nome);
            Console.WriteLine("Idade: "+pessoa1.Idade);

            pessoa1.ExibirInfo();

        }
    }
}