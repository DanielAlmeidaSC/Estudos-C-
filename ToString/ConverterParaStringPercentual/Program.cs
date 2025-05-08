using System;

namespace ConverterParaStringPercentual
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("5. Exibir um número como percentual.");

            double numero = 15.6 / 100; //precisa dividir para não mostrar com casas indevidas

            string novoNumero = numero.ToString("P");

            Console.WriteLine("Número normal: " + numero);
            Console.WriteLine("Novo Número: " + novoNumero);
        }
    }
}