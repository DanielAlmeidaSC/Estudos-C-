using System;
using programa003.Classes;

namespace programa003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a opção em que o pedido se encontra (1 - Em Andamento 2 - Concluída 3 - Cancelada): ");
            int numeroDigitado = int.Parse(Console.ReadLine()??"0");


            Console.WriteLine(DescreveStatus.DescreverStatus(numeroDigitado));
        }
    }
}