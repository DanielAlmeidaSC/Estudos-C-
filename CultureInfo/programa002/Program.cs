using System;
using System.Globalization;

namespace Programa002 {
    internal class Program {
        static void Main(string[] args) {
        Console.WriteLine("Exibir a data atual em cultura americana");

        DateTime data = DateTime.Now;


        Console.WriteLine(data.ToString("D", new CultureInfo("en-US"))); // exibe por extenso em ingles

        
        
        
        }
    }
}