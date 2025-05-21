using GestaoFuncionarios.Interfaces;

namespace GestaoFuncionarios.Entities
{
    public class FuncionarioTerceirizado : IFuncionario
    {
        public string? Nome { get; set; }
        public double SalarioBase { get; set; }
        public double Desconto { get; set; }

        public FuncionarioTerceirizado(string nome, double salarioBase, double desconto)
        {
            Nome = nome;
            SalarioBase = salarioBase;
            Desconto = desconto;
        }
        public void CalcularSalario()
        {
            double resultado = SalarioBase - Desconto;

            Console.WriteLine("Salário: " + resultado.ToString("C"));
        }
    }
}