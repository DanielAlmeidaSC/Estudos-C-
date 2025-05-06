using System;
using Classes;


namespace Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seja bem-vindo ao verificador de dia! ");
            Console.WriteLine("Digite um número de 1 a 7 que retornaremos se é dia útil ou não: ");
            int numeroDigitado = int.Parse(Console.ReadLine()??"0");

            EhDiaUtil.Imprimir(numeroDigitado);

        }
    }
}