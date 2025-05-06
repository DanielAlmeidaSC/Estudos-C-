using System;
using System.Globalization;
using Classes;

namespace ProjetoClima
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Quantos graus está fazendo na sua região:");
            
            int graus = int.Parse(Console.ReadLine()??"0", CultureInfo.InvariantCulture);

            RetornaVestimenta.ImprimirRecomendacao(graus);
        }
    }
}