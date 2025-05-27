using System;
namespace OrdenarPessoa.Entities
{
    public class Pessoa
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
        public static int OrdenarPorNome(Pessoa nome1, Pessoa nome2)
        {
            if (nome1.Nome == null)
            {
                throw new ArgumentNullException("Erro! Não é possível nomes nulos!");
            }

            return nome1.Nome.CompareTo(nome2.Nome);
        }

        public static int OrdenarPorIdade(Pessoa idade1, Pessoa idade2)
        {
            return idade1.Idade.CompareTo(idade2.Idade);
        }
    }
}