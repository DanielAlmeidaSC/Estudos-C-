using System;

namespace Programa005 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Um `switch` para definir o nível de um game player (Beginner, Intermediate, Advanced).");

            Console.WriteLine("Digite seu nível: ");
            int nivel = int.Parse(Console.ReadLine()??"0");

            switch (nivel)
            {
                case int n when (n > 00 && n < 10):
                Console.WriteLine("Beginner");
                break;

                case int n when (n >= 10 && n < 50 ):
                Console.WriteLine("Intermediate");
                break;

                case int n when (n >= 50):
                Console.WriteLine("Advanced");
                break;
                
                default:
                Console.WriteLine("Opção inválida");
                break;
            }
        }
    }
}