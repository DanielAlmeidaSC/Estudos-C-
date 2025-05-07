using System;
using Classes;

namespace Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe ao sistema o status do pedido (1 - Andamento 2 - Concluído  3 - Cancelado): ");
            int status = int.Parse(Console.ReadLine()??"0");

            SituacaoProduto.RetornarStatus(status);
        }
    }
}