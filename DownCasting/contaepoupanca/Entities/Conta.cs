namespace contaepoupanca.Entities
{
    public class Conta
    {
        public double Saldo { get; set; }

        public Conta(double saldo)
        {
            Saldo = saldo;
        }
    }
}