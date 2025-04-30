using System;

namespace Programa002 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Leia uma string e transforme em maíuscula.");

            string nomePrincipal = "daniel expedito ribeiro de almeida";
            string nomeSecundario = "roberto carlos";

            string novoNome = nomePrincipal.ToUpper();
            string novoNomeSecundario= nomeSecundario.ToUpper();

            Console.WriteLine(novoNome);
            Console.WriteLine(novoNomeSecundario);
        }
    }
}