using System;
using contaepoupanca.Entities;

namespace contaepoupanca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new ContaPoupanca(200.0);
            ContaPoupanca contaPoupanca = (ContaPoupanca)conta; // só vai funcionar se conta for do tipo conta poupanca
            Console.WriteLine(contaPoupanca.RenderJuros());
        }
    }
}