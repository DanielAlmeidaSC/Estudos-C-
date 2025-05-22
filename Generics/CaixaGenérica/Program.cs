using System;
using System.Collections.Generic;

namespace CaixaGenérica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Caixa<string> caixa = new Caixa<string>();

            caixa.DefinirValor("Nerci");

            Console.WriteLine(caixa.ObterValor());

            Caixa<int> caixaInt = new Caixa<int>();

            caixaInt.DefinirValor(100);

            Console.WriteLine(caixaInt.ObterValor());


            
        }
    }
}