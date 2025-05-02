using System;
using System.Globalization;


namespace Programa006 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("6. Ler um número formatado em outra cultura.");

            int num = 10;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine(num.ToString("C", new CultureInfo("pt-BR")));
            Console.WriteLine(num.ToString("C", new CultureInfo("en-US")));
            Console.WriteLine(num.ToString("C", new CultureInfo("en-UK")));
            Console.WriteLine(num.ToString("C", new CultureInfo("es-MX")));
            Console.WriteLine(num.ToString("C", new CultureInfo("fr-CA")));
            Console.WriteLine(num.ToString("C", new CultureInfo("fr-FR")));
            Console.WriteLine(num.ToString("C", new CultureInfo("en-GB")));
            Console.WriteLine(num.ToString("C", new CultureInfo("ja-JP")));
            Console.WriteLine(num.ToString("C", new CultureInfo("ko-KR")));
            Console.WriteLine(num.ToString("C", new CultureInfo("hi-IN")));
            Console.WriteLine(num.ToString("C", new CultureInfo("ru-RU")));
            Console.WriteLine(num.ToString("C", new CultureInfo("tr-TR")));
            Console.WriteLine(num.ToString("C", new CultureInfo("sv-SE")));
            Console.WriteLine(num.ToString("C", new CultureInfo("ar-SA")));
        }
    }
}