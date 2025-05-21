namespace GestaoFuncionarios.Interfaces
{
    public interface IFuncionario
    {
        public string? Nome { get; set; }
        public double SalarioBase { get; set; }

        void CalcularSalario();   
    }
}