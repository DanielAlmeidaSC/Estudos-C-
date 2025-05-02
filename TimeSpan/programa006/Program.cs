using System;

namespace Programa006 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Criar um TimeSpan a partir de dias.");
            TimeSpan tempo = new TimeSpan(01, 00, 00, 00);

            Console.WriteLine(tempo);
            Console.WriteLine("Dia: "+tempo.TotalDays);
            Console.WriteLine("Horas: "+tempo.TotalHours);
            Console.WriteLine("Minutos: "+tempo.TotalMinutes);
            Console.WriteLine("Segundos: "+tempo.TotalSeconds);
            Console.WriteLine("Milisegundos: "+tempo.TotalMilliseconds.ToString("N0"));
        }
    }
}