using System;

namespace Programa003 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Verifica se é par ou ímpar");

            Console.Write("Digite: ");
            int numero = int.Parse(Console.ReadLine()??"0");

            string resultado = (numero % 2 == 0)?"Par":"Ímpar";

            Console.WriteLine(resultado);
        }
    }
}