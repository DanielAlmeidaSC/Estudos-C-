using System;

namespace Programa016 {
    internal class Program {
        static void Main(string[] args) {
        Console.WriteLine("16. Leia uma frase e conte quantas vezes aparece a letra 'e'.");
        
        string nome = "Daniel Expedito Ribeiro de Almeida";


        int contar = nome.Count(e => e == 'e' || e == 'E'); // ele conta onde e for igual a 'e' 

        Console.WriteLine("Quantidade de vezes: {0}", contar);
        }
    }
}