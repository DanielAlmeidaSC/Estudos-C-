using System;

namespace Programa010 {
    internal class Program {
        static void Main(string[] args) {
        Console.WriteLine("10. Divida uma frase em palavras e imprima cada uma.");

        string frase = "Daniel Expedito Ribeiro de Almeida";

        string[] fraseDividida = frase.Split(' ');

        for (int i = 0; i < fraseDividida.Length; i++)
        {
            Console.WriteLine(fraseDividida[i]);
        }
        
        }
    }
}