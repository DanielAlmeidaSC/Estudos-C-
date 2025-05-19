namespace FuncionarioComBase.Entities
{
    public class Gerente : Funcionario
    {
        // Crie a classe Gerente que herda de Funcionario e usa base(nome) para inicializar o nome no construtor.
        public Gerente(string? nome) : base(nome)
        {
            //cria um construtor Gerente e dá entrada com o nome (vai ser reaproveitado o construtor Funcionario) 
            // é util pra não precisar ficar criando novos atributos

        }
        
    }
}