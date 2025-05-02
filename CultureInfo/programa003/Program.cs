using System;
using System.Globalization;


namespace Programa003 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("3. Exibir um número formatado para Alemanha (vírgula como separador decimal).");

            int number = 123456;

        Console.WriteLine(number.ToString("N2", new CultureInfo("de-DE")));
        }
    }
}