using System;

namespace Programa005 {
    internal class Program {
        static void Main(string[] args) {
        Console.WriteLine("Leia uma string e recorte os 5 primeiros caracteres");

        string nome = "DANIEL EXPEDITO RIBEIRO DE ALMEIDA";

        Console.WriteLine("Nome: {0}",nome);

        string resultado = nome.Remove(5); //recorta os 5 primeiros caracteres e remove o restante
        Console.WriteLine("Nome com os 5 primeiros caracteres recortados: {0}",resultado);
        
        }
    }
}