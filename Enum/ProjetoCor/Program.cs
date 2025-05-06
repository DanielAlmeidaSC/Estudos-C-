using System;
using Classes;


namespace ProjetoCor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro de 1 a 5: ");
            int numeroDigitado = int.Parse(Console.ReadLine()??"0");

            Console.WriteLine(ReceberCor.RetornarCor(numeroDigitado));
 
        }
    }
}