using System;
using Classes;

namespace TempoMaximoDeEntrega
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Olá, escolha a prioridade que foi dada pelo seu supervisor a atual tarefa: ");
            Console.WriteLine("1 - Baixa; ");
            Console.WriteLine("2 - Média; ");
            Console.WriteLine("3 - Alta. ");
            Console.Write("Digite: ");
            
            int numeroDigitado = int.Parse(Console.ReadLine()??"00");

            TempoConclusao.RetornarTempoMaximo(numeroDigitado);
        }
    }
}