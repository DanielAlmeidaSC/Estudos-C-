using System;
using System.Globalization;

namespace Programa001{
    internal class Principal {
        static void Main(string[] args) {

            Console.WriteLine("Qual é a cotação atual do dolar: ");
            double cotacao = double.Parse(Console.ReadLine()??"0", CultureInfo.InvariantCulture);
            
            Console.WriteLine("Quantos dolares você vai comprar: ");
            double quantidade = double.Parse(Console.ReadLine()??"0", CultureInfo.InvariantCulture);

            double resultadoCotacao = Cotacao.ComprarDolares(cotacao, quantidade);

            Console.WriteLine("Valor a ser pago em reais: "+resultadoCotacao.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}