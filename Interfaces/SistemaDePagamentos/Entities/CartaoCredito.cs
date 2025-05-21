using SistemaDePagamentos.Interface;

namespace SistemaDePagamentos.Entities
{
    internal class CartaoCredito : IPagamento
    {

        public void Pagar(double valor)
        {
            Console.WriteLine("Você efetuou um pagamento de "+valor.ToString("C")+" no cartão de crédito");
        }

    }
}
