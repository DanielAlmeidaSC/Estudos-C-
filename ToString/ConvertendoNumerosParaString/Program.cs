using System;

namespace ConvertendoNumerosParaString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Converter um número inteiro para string.");

            int num = 10;

            string num1 = num.ToString();

            Console.WriteLine("Numero em string: {0}", num1);


            Console.WriteLine("2. Converter um número double para string com duas casas decimais.");

            double num2 = 15.0;

            string num3 = num2.ToString("F2");


            Console.WriteLine("Resultado: {0}", num3);

        }
    }
}