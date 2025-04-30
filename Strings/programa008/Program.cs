using System;

namespace Programa008 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("8. Verifique se uma string começa com 'Hello'.");

            string frase = "Hello, my name is Daniel";

            Console.WriteLine(frase.StartsWith("Hello")); //verifica se começa
            Console.WriteLine(frase.StartsWith("Mandioca"));
        
        }
    }
}