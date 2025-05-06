using System;
using System.Globalization;
using Classes;

namespace Viagem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for(int i = 0; i < 4; i++)
            {
            Console.WriteLine("Digite o veículo no qual você vai viajar: ");
            string veiculo = Console.ReadLine()??"0";

            Console.WriteLine("Digite a distância: ");
            double distancia = double.Parse(Console.ReadLine()??"0", CultureInfo.InvariantCulture);

            TempoDeViagem.RetornarTempoDeViagem(veiculo, distancia);
            
            }
        }
    }
}