using System;

namespace Programa004 {
    internal class Program {
        static void Main(string[] args) {
        Console.WriteLine("Obter a hora atual.'.");

        DateTime hoje = DateTime.Now;

        Console.WriteLine(hoje.ToString("HH:mm:ss"));

        Console.WriteLine("15. Calcular a idade de uma pessoa (data de nascimento).");

        DateTime nascimento = new DateTime(2004, 08, 30);

        int calcular = hoje.Year - nascimento.Year;

        Console.WriteLine("{0} anos",calcular);
        }
    }
}