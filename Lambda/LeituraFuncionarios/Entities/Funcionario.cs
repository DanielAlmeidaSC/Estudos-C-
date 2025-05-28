namespace LeituraFuncionarios.Entities
{
    public class Funcionario
    {
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public double Salario { get; set; }

        public Funcionario(string nome, string email, double salario)
        {
            Nome = nome;
            Email = email;
            Salario = salario;
        }


        public override string ToString()
        {
            return $"Nome: {Nome, -20}"
                 + $"Email: {Email, -30}"
                 + $"Salário: {Salario, 10:C}";
        }
    }
}