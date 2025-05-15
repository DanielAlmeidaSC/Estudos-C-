namespace FuncionarioEGerente.Entities
{
    public class Funcionario
    {
        public string? Nome { get; protected set; }
        public double SalarioBase { get; protected set; }

        public Funcionario()
        {

        }

        public Funcionario(string nome, double salarioBase)
        {
            Nome = nome;
            SalarioBase = salarioBase;
        }

        public virtual double CalcularSalario()
        {
            return SalarioBase;
        }


    }
}