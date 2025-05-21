using GestaoFuncionarios.Interfaces;

namespace GestaoFuncionarios.Entities
{
    public class FuncionarioEfetivo : IFuncionario
    {
        public string? Nome { get; set; }
        public double SalarioBase { get; set; }
        public double Bonus { get; set; }

        public FuncionarioEfetivo(string nome, double salarioBase, double bonus)
        {
            Nome = nome;
            SalarioBase = salarioBase;
            Bonus = bonus;
        }
        public void CalcularSalario()
        {
            double resultado = SalarioBase + Bonus;

            Console.WriteLine("Salário: " + resultado.ToString("C"));
        }
    }
}