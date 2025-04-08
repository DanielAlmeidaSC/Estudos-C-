using System;
using System.Globalization;

namespace Programa004
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("******************BEM-VINDO À CALCULADORA******************");

            Console.Write("Digite o primeiro número: ");
            double valor1 = double.Parse(Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);

            Console.Write("Digite a operação: ");
            char operacao = char.Parse(Console.ReadLine() ?? "0");

            Console.Write("Digite o segundo número: ");
            double valor2 = double.Parse(Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);
            
            double resultado;
            if (operacao == '+')
            {
                resultado = Calculadora.Somar(valor1, valor2);

                Console.WriteLine(resultado);
            }
            else if (operacao == '-')
            {
                resultado = Calculadora.Subtrair(valor1, valor2);
                Console.WriteLine(resultado);
            }
            else if (operacao == '*')
            {
                resultado = Calculadora.Multiplicar(valor1, valor2);
                Console.WriteLine(resultado);
            }
            else if (operacao == '/')
            {
                resultado = Calculadora.Dividir(valor1, valor2);
                Console.WriteLine(resultado);
            }
        }
    }
}