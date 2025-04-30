using System;

namespace Programa002 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Verifica se é maior de idade");

            Console.WriteLine("Digite a idade: ");
            int idade = int.Parse(Console.ReadLine()??"0");

            string resultado = (idade >= 18)?"Maior de idade":"Menor de idade";

            Console.WriteLine(resultado);
        }
    }
}