using System;

namespace Programa001 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Ler um número e dizer se é positivo ou negativo usando ternário.");

            Console.Write("Digite: ");
            int numero = int.Parse(Console.ReadLine()??"0");

            string resultado = (numero > 0)?"Número Positivo":"Numero Negativo";

            Console.WriteLine(resultado);
        }
    }
}