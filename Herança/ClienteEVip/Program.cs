using System;
using System.Globalization;
using ClienteEVip.Entities;

namespace ClienteEVip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu nome:");
            string nome = Console.ReadLine() ?? "0";

            Console.Write("Digite seu limite de crédito:");
            double limite = double.Parse(Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);

            Console.WriteLine("Você é cliente VIP? ");
            string opcao = Console.ReadLine() ?? "0";

            opcao = opcao.ToLower();

            if (opcao == "sim")
            {
                ClienteVIP clienteVIP = new ClienteVIP(nome, limite);
                Console.WriteLine("Seu limite foi aumentado para: " + clienteVIP.AumentarLimite().ToString("C"));
                Console.WriteLine("Nome: " + clienteVIP.Nome);
                Console.WriteLine("Limite De Crédito: " + clienteVIP.LimiteCredito.ToString("C"));
            }
            else if (opcao == "não")
            {
                Cliente cliente = new Cliente(nome, limite);
                Console.WriteLine("Nome: " + cliente.Nome);
                Console.WriteLine("Limite De Crédito: " + cliente.LimiteCredito.ToString("C"));
            }
            else
            {
                Console.WriteLine("Opção inválida!");
            }
        }
    }
}