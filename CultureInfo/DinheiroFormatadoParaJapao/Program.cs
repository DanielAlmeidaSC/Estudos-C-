using System;
using System.Globalization;

namespace DinheiroFormatadoParaJapao {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("4. Formatar valor monetário para Japão (JPY).");

            int numero = 1234567;

            
            Console.WriteLine(numero.ToString("C", new CultureInfo("ja-JP")));

        }
    }
}