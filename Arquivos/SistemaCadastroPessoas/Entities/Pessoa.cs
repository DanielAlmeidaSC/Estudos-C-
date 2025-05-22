using SistemaCadastroPessoas.Interface;

namespace SistemaCadastroPessoas.Entities
{
    public class Pessoa : IPessoa
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }
        public Endereco Endereco { get; set; }
        public Pessoa(string nome, int idade, Endereco endereco)
        {
            Nome = nome;
            Idade = idade;
            Endereco = endereco;
        }

        public override string ToString()
        {
            return $"Nome: [{Nome}] | Idade: [{Idade}] |";
        }
    }
}