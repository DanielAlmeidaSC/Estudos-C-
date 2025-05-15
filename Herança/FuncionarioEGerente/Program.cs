using System;
using System.Globalization;
using FuncionarioEGerente.Entities;

namespace Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome:");
            string nome = Console.ReadLine() ?? "0";

            Console.WriteLine("Digite seu Salário Base:");
            double salarioBase = double.Parse(Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);

            Gerente gerente = new Gerente(nome, salarioBase);

            Console.WriteLine(gerente.CalcularSalario());
            
        }
    }
}