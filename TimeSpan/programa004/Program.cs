using System;

namespace Programa004 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Verificar se um TimeSpan é negativo.");

            TimeSpan hora = new TimeSpan(-02, 00, 00);

            if (hora.TotalSeconds < 0)
            {
                Console.WriteLine("Negativo");
            }else
            {
                Console.WriteLine("Positivo");
            }
        }
    }
}