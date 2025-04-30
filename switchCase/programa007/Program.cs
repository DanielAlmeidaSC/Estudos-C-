using System;
using System.Globalization;

namespace Programa007 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Criar uma pequena calculadora usando `switch` (+, -, *, /).");

            Console.WriteLine("Digite o primeiro valor: ");
            double num1 = double.Parse(Console.ReadLine()??"0", CultureInfo.InvariantCulture);
            
            Console.WriteLine("Digite o segundo valor: ");
            double num2= double.Parse(Console.ReadLine()??"0", CultureInfo.InvariantCulture);


            Console.WriteLine("Digite o operador(+, -, /, *): ");
            char operador = char.Parse(Console.ReadLine()??"0");

            switch (operador)
            {
                case '+':
                double resultadoSoma = num1 + num2;

                Console.WriteLine("Resultado: {0}", resultadoSoma.ToString("F2", CultureInfo.InvariantCulture));
                break;
                case '-':
                double resultadoSub = num1 - num2;

                Console.WriteLine("Resultado: {0}", resultadoSub.ToString("F2", CultureInfo.InvariantCulture));
                break;
                case '*':
                double resultadoMul = num1 * num2;

                Console.WriteLine("Resultado: {0}", resultadoMul.ToString("F2", CultureInfo.InvariantCulture));
                break;
                case '/':
                double resultadoDiv = num1 / num2;

                Console.WriteLine("Resultado: {0}", resultadoDiv.ToString("F2", CultureInfo.InvariantCulture));
                break;

                default:
                Console.WriteLine("Opção inválida!");
                break;
            }
        }
    }
}