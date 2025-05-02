using System;

namespace Programa002 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Multiplicar um TimeSpan por um número.");

            TimeSpan duasHoras= new TimeSpan(02, 00, 00);
        
            TimeSpan multiplicaHora = duasHoras*10;

            Console.WriteLine(multiplicaHora);

            Console.WriteLine("Dividir um TimeSpan por um número.");

            TimeSpan tresHoras = new TimeSpan(03, 00, 00);

            TimeSpan dividirHora = tresHoras/2;

            Console.WriteLine(dividirHora);


        }
    }
}