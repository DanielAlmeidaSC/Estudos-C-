using System;

namespace Programa002 {
    internal class Program {
        static void Main(string[] args) {

        Console.WriteLine("5. Converter DateTimeKind de Local para Utc.");
        DateTime dataLocal = DateTime.Now;

        Console.WriteLine("Data: "+dataLocal+" "+dataLocal.Kind);

        DateTime novaData = dataLocal.ToUniversalTime();
        Console.WriteLine("Nova data: "+novaData+" "+novaData.Kind);
        
        Console.WriteLine("------------------------------------------------------------------------");
        Console.WriteLine("6. Converter DateTimeKind de Utc para Local.");            

        DateTime dataUTC = DateTime.UtcNow;

        Console.WriteLine("Data UTC: "+dataUTC+" "+dataUTC.Kind);

        DateTime novaDatUTC = dataUTC.ToLocalTime();

        Console.WriteLine("Nova Data UTC: "+novaDatUTC+" "+novaDatUTC.Kind);

        }
    }
}