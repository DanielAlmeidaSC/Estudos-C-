using System;
using programa002.Classes;

namespace programa002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite em números (de 1 a 7) o dia da semana que retornaremos se é dia útil ou não: ");
            int numeroDigitado = int.Parse(Console.ReadLine()??"0");

            EhDiaUtil.EhDia(numeroDigitado);
        }
    }
}