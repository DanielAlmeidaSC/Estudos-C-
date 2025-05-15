namespace ClienteEVip.Entities
{
    public class Cliente
    {

        public string? Nome { get; protected set; } //só podem ser alterados na subclasse
        public double LimiteCredito { get; protected set; } //só podem ser alterados na subclasse

        public Cliente()
        {
        }

        public Cliente(string nome, double limiteCredito)
        {
            Nome = nome;
            LimiteCredito = limiteCredito;
        }
        
        
    }
}