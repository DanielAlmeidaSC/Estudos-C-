using System;
using System.Globalization;

namespace Programa003 {
    internal class Program {
        static void Main(string[] args) {
            
            Console.WriteLine("Você deseja converter: ");
            Console.WriteLine("1 - Fahrenheit para Célsius;");
            Console.WriteLine("2 - Célsius para Fahrenheit.");

            Console.Write("Digite: ");
            int opcao = int.Parse(Console.ReadLine()??"0");

            if(opcao == 1 ){
                Console.Write("Digite o valor Fahrenheit: ");
                double valor = double.Parse(Console.ReadLine()??"0", CultureInfo.InvariantCulture);

                double converter = Conversor.ConverterParaCelsius(valor);

                Console.WriteLine("Está fazendo "+converter.ToString("F2", CultureInfo.InvariantCulture)+" graus célsius");
            }else{
                Console.Write("Digite o valor Célsius: ");
                double valor = double.Parse(Console.ReadLine()??"0", CultureInfo.InvariantCulture);

                double converter = Conversor.ConverterParaFahrenheit(valor);

                Console.WriteLine("Está fazendo "+converter.ToString("F2", CultureInfo.InvariantCulture));

            }
        }
    }
}