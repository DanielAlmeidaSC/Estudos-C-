using System;

namespace Programa005 {
    internal class Program {
        static void Main(string[] args) {
        Console.WriteLine("Exibir um número como moeda");

        int numero = 1234567890;

        string numeroNovo = numero.ToString("C");

        Console.WriteLine("Valor: "+numeroNovo);


        Console.WriteLine("8. Exibir um valor decimal com formatação fixa.");


        decimal pi = 3.14159265358979323846264338327950288419716939937510M;

        string novoPi = pi.ToString("F2");

        Console.WriteLine("Pi: "+pi);        
        Console.WriteLine("Novo Pi: "+novoPi);        
        }
    }
}