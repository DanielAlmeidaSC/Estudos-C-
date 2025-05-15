namespace FuncionarioEGerente.Entities
{
    public class Gerente : Funcionario
    {

        public Gerente()
        {
        }

        public Gerente(string nome, double salarioBase) : base(nome, salarioBase)
        {
            //nao precisa inserir nada, pois ja está resolvido na base
        }

        public override double CalcularSalario()
        {
            return SalarioBase * 1.3;
            
        }
    }
}