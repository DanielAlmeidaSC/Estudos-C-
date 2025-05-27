using System;

namespace ContarPalavras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um texto: ");
            string texto = Console.ReadLine() ?? "0";


            Console.WriteLine(texto.ContadorPalavras());
        }
    }
}