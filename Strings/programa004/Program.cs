using System;

namespace Programa004 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Leia uma string e remova espaços extras");

            string nome = " DANIEL EXPEDITO RIBEIRO DE ALMEIDA "; //contem espaço no final e no inicio

            Console.WriteLine(nome);
            Console.WriteLine(nome.Trim());
        }
    }
}