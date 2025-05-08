using System;

namespace ImprimirNumerosComWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int numero = 1;

            while (numero != 11)
            {
                Console.WriteLine(numero++);
            }
        }
    }
}