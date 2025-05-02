using System;

namespace Programa007 {
    internal class Program {
        static void Main(string[] args) {
        Console.WriteLine("Usar o método `FromMinutes` para criar um TimeSpan");

        TimeSpan minutos = TimeSpan.FromMinutes(2);

        Console.WriteLine("Minutos: {0}", minutos);

        Console.WriteLine("Usar o método `FromHours` para criar um TimeSpan.");
        
        TimeSpan horas = TimeSpan.FromHours(2);

        Console.WriteLine("Horas: {0}", horas);

        Console.WriteLine("Usar o método `FromDays` para criar um TimeSpan.");
       
        TimeSpan dias = TimeSpan.FromDays(2);

        Console.WriteLine("Dias: {0} ou {1}", dias.Days, dias);
       
       
       
       
        }
    }
}