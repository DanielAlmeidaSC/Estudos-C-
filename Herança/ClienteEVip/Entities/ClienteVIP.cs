namespace ClienteEVip.Entities
{
    public class ClienteVIP : Cliente
    {
        public ClienteVIP()
        {
        }

        public ClienteVIP(string nome, double limiteCredito) : base(nome, limiteCredito)
        {
        }

        public double AumentarLimite()
        {
            return LimiteCredito += LimiteCredito * 0.5;
        }
    }
}