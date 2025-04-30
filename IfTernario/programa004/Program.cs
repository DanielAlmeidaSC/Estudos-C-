using System;
using System.Globalization;

namespace Programa004 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Atribuir reprovado ou aprovado dependendo da nota");

            Console.Write("Digite sua nota: ");
            double nota = double.Parse(Console.ReadLine()??"0", CultureInfo.InvariantCulture);

            string resultado = (nota >= 7.0)?"Aprovado":"Reprovado";

            Console.WriteLine(resultado);
        }
    }
}