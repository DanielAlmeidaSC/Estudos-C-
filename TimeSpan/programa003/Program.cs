using System;

namespace Programa003 {
    internal class Program {
        static void Main(string[] args) {
        
        Console.WriteLine("Obter total de minutos de um TimeSpan.");

        TimeSpan quatroHoras = new TimeSpan(04, 00, 00);

        Console.WriteLine("{0} minutos", quatroHoras.TotalMinutes);
        
        Console.WriteLine("Obter total de segundos de um TimeSpan.");
     
        Console.WriteLine("{0} segundos ", quatroHoras.TotalSeconds);
     
        }
    }
}