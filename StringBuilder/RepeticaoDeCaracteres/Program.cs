using System;
using System.Text;

namespace Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um caractere e um numero: ");
            string input = Console.ReadLine() ?? "0";

            string[] convertForArray = input.Split(" ");

            string caracterDigitado = convertForArray[0];
            int numeroDigitados = int.Parse(convertForArray[1]);

            StringBuilder sb = new StringBuilder(caracterDigitado);

            for (int i = 0; i < numeroDigitados; i++)
            {
                Console.WriteLine(sb.ToString());
            }

        }
    }
}