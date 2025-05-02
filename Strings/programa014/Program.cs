using System;

namespace Programa014 {
    internal class Program {
        static void Main(string[] args) {
        Console.WriteLine("Remova parte de uma string");

        string nome = "Daniel Expedito Ribeiro de Almeida";

        string recortarParteParaRemover = nome.Substring(16, 7); //Recorta a partir do caracter 16 e avança 7 casas
        string remover = nome.Remove(16, 7); //começa a remover a partir do caracter 16 e remove 7 caracteres 

        Console.WriteLine("Parte removida: "+recortarParteParaRemover);       
        Console.WriteLine("Nome novo: "+remover);       
        }
    }
}