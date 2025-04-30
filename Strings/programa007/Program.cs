using System;

namespace Programa007 {
    internal class Program {
        static void Main(string[] args) {

             Console.WriteLine("Verifique se uma string contém uma determinada palavra");

             string palavras = "ABACATE MANTEIGA BANANA MANDIOCA";

             Console.WriteLine(palavras.Contains("MANDIOCA"));
             Console.WriteLine(palavras.Contains("CEBOLA"));
        }
    }
}