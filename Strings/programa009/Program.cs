using System;

namespace Programa009 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("8. Verifique se uma string termina com 'World'.");

            string frase = "Hello, my name is Daniel, World";

            Console.WriteLine(frase.StartsWith("Hello")); //verifica se começa
            Console.WriteLine(frase.EndsWith("World"));//verifica se termina com
            
        
        }
    }
}