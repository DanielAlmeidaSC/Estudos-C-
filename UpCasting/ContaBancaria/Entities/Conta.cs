namespace ContaBancaria.Entities
{
    public class Conta
    {
        public double Saldo { get; set; }

        public Conta(double saldo)
        {
            Saldo = saldo;
        }

        public void ExibirSaldo()
        {
            Console.WriteLine("Saldo: "+Saldo.ToString("C"));
        }
    }
}