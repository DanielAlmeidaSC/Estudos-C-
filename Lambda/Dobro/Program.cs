using System;

namespace Dobro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int numero = int.Parse(Console.ReadLine() ?? "0");

            Func<int, int> dobrar = x => x * 2;

            int resultado = dobrar(numero);

            Console.WriteLine("resultado: "+resultado);


        }
    }
}