using System;

namespace Programa012 {
    internal class Program {
        static void Main(string[] args) {
        Console.WriteLine("Encontre a posição da primeira ocorrência de uma letra.");
        
        string nome = "Daniel Expedito Ribeiro de Almeida";

        Console.WriteLine("Resultado: {0}", nome.IndexOf("Expedito"));
        
        }
    }
}