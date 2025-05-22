namespace OrdenarPorIdade.Entities
{
    public class Pessoa : IComparable
    {
        // Crie uma classe Pessoa com Nome e Idade. Implemente IComparable para ordenar as pessoas da mais nova para a mais velha.

        public string? Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public int CompareTo(object? obj)
        {
            // Convertendo o objeto Icomparable para um objeto Pessoa
            Pessoa? outraPessoa = obj as Pessoa;
            if (outraPessoa == null)
            {
                throw new Exception("Error!");
            }

            return Idade.CompareTo(outraPessoa.Idade);
        }
    }
}