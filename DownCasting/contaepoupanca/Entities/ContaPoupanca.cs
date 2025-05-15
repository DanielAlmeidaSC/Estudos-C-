namespace contaepoupanca.Entities
{
    public class ContaPoupanca : Conta
    {
        public ContaPoupanca(double saldo) : base(saldo)
        {
        }

        public double RenderJuros()
        {
            return Saldo += Saldo * 0.25;
        }
    }
}