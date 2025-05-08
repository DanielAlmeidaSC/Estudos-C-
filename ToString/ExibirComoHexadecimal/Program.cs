using System;

namespace ExibirComoHexadecimal
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("9. Exibir um número em formato hexadecimal.");

            int numero = 12345;

            string novoNumero = numero.ToString("X");

            Console.WriteLine("Novo número: " + novoNumero);
        }
    }
}