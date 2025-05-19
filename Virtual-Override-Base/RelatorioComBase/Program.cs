using System;
using RelatorioComBase.entities;

namespace RelatorioComBase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Relatorio relatorio = new RelatorioFinanceiro();
            relatorio.Gerar();
        }
    }
}