using System;

namespace ExibirComSeparadorMilhar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Exibir um número com separador de milhar");

            int numero = 123456789;

            Console.WriteLine("Resultado: {0}", numero.ToString("N")); //Cria separadores de milhar

        }
    }
}