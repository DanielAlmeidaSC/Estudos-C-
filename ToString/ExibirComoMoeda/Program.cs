using System;

namespace ExibirComoMoeda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exibir um número como moeda");

            int numero = 1234567890;

            string numeroNovo = numero.ToString("C");

            Console.WriteLine("Valor: " + numeroNovo);



        }
    }
}