using System;
using ContaBancaria.Entities;

namespace ContaBancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new ContaCorrente(500.0);

            conta.ExibirSaldo();
        }
    }
}