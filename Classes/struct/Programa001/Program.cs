using System;

namespace Programa001 {
    internal class Program {
        static void Main(string[] args) {
            Endereco endereco = new Endereco("Rua João Goulart", 645, "Chapecó");

            Pessoa pessoa1 = new Pessoa("Daniel Almeida", 20, endereco);

            pessoa1.ExibirDados();
        }
    }
}