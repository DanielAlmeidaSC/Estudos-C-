using System;

namespace Programa006 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Definir se uma string é vazia ou não");

            Console.Write("Digite: ");
            string palavra = Console.ReadLine()??"0";

            string resultado = (string.IsNullOrWhiteSpace(palavra))?"É vazia":"Não é";

            Console.WriteLine(resultado);
        }
    }
}
