using System;
using SistemaDePagamentos.Entities;

namespace SistemaDePagamentos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo à central de pagamentos da X LTDA! ");
            Console.WriteLine("Escolha a forma de pagamento: ");
            Console.WriteLine("1 - Boleto;");
            Console.WriteLine("2 - Cartão de Crédito.");
            Console.Write("Digite: ");
            int opcao = int.Parse(Console.ReadLine() ?? "0");

            if (opcao == 1)
            {
                Boleto boleto = new Boleto();

                Console.Write("Digite o valor do pagamento: ");
                double valor = double.Parse(Console.ReadLine() ?? "0");

                boleto.Pagar(valor);

            }
            else if (opcao == 2)
            {
                CartaoCredito cartao = new CartaoCredito();

                Console.Write("Digite o valor do pagamento: ");
                double valor = double.Parse(Console.ReadLine() ?? "0");

                cartao.Pagar(valor);
            }
            else
            {
                Console.WriteLine("Opção inválida!");
            }

        }
    }
}
