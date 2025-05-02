using System;

namespace Programa001 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("1. Criar um TimeSpan de 1 hora.");

            TimeSpan umaHora = new TimeSpan(1, 00, 00); //1 hora

            Console.WriteLine(umaHora);

            Console.WriteLine("2. Criar um TimeSpan de 30 minutos.");

            TimeSpan meiaHora = new TimeSpan(00, 30, 00); //30 minutos

            Console.WriteLine(meiaHora);


            Console.WriteLine("3. Somar dois TimeSpan.");

            TimeSpan resultadoSoma = umaHora+meiaHora;

            Console.WriteLine(resultadoSoma);

            Console.WriteLine("4. Subtrair dois TimeSpan.");

            TimeSpan resultadoSub = umaHora-meiaHora;

            Console.WriteLine(resultadoSub);

            
        }
    }
}