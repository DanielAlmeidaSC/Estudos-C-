using SistemaDePagamentos.Interface;

namespace SistemaDePagamentos.Entities
{
    internal class Boleto : IPagamento
    {
        public void Pagar(double valor)
        {
            Console.WriteLine("Você efetuou um pagamento de " + valor.ToString("C") + " no Boleto");
        }
    }
}
