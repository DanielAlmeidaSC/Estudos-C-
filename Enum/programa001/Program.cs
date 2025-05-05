using System;
using programa001.Classes;

namespace programa001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número de 1 a 5: ");
            int numeroDigitado = int.Parse(Console.ReadLine()??"0");

            string resultado = InformarCor.CorInformada(numeroDigitado);

            Console.WriteLine(resultado);
        }
    }
}