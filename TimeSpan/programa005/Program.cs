using System;

namespace Programa005 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Converter TimeSpan para string.");

            TimeSpan hora = new TimeSpan(03, 00, 00);

            Console.WriteLine(hora.ToString());
        }
    }
}