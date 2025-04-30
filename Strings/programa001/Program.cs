using System;

namespace Programa001 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Leia uma string e transforme em minúscula.");

            string nomePrincipal = "DANIEL EXPEDITO RIBEIRO DE ALMEIDA";
            string nomeSecundario = "ROBERTO CARLOS";

            string novoNome = nomePrincipal.ToLower();
            string novoNomeSecundario= nomeSecundario.ToLower();

            Console.WriteLine(novoNome);
            Console.WriteLine(novoNomeSecundario);
        }
    }
}