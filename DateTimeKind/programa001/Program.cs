using System;

namespace Programa001 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("1. Criar um DateTime com DateTimeKind.Utc");

            DateTime dataUTC = DateTime.UtcNow;

            Console.WriteLine(dataUTC); //vai mostrar o horario na inglaterra
            Console.WriteLine(dataUTC.Kind); //vai mostrar UTC

            Console.WriteLine("2. Criar um DateTime com DateTimeKind.Local.");
            DateTime dataLocal = DateTime.Now;
            
            Console.WriteLine(dataLocal); //vai mostrar a data e horario do sistema
            Console.WriteLine(dataLocal.Kind); //vai mostrar local
        
        
        
            Console.WriteLine("Criar um DateTime com DateTimeKind.Unspecified.");

            DateTime dataUnspecified = new DateTime(2025, 05, 03);
            
            Console.WriteLine(dataUnspecified); //só vai mostrar a data, pq o horario nao foi especificado e nem o fuso horario
            Console.WriteLine(dataUnspecified.Kind); //vai mostrar Unspecified pois não foi mostrado o fuso
        
        
        
        
        
        }
    }
}