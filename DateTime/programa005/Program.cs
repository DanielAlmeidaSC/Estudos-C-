using System;

namespace Programa005 {
    internal class Program {
        static void Main(string[] args) {
        Console.WriteLine("Calcular a diferença de dias entre duas datas.");

        DateTime hoje = DateTime.Now;

        DateTime inicio = new DateTime(2025, 01, 31);

        TimeSpan resultado = hoje-inicio;

        Console.WriteLine("Diferença: "+resultado.Days);
        
        }
    }
}