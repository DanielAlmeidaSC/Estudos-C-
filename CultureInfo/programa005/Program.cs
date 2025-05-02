using System;
using System.Globalization;

namespace Programa005 {
    internal class Program {
        static void Main(string[] args) {
        Console.WriteLine("5. Formatar uma data para formato francês.");

        DateTime hoje = DateTime.Now;

        Console.WriteLine(hoje.ToString("D", new CultureInfo("fr-FR")));
        }
    }
}