using System;

namespace ProjetoPessoaComComposicao
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public Endereco Endereco { get; set; } //todos os atributos que estão na classe endereço vão ser trazidas até esse código

        public Pessoa(string nome, int idade, Endereco endereco) //no endereço, ele vai ter que preencher com rua, cidade, cep...
        {
            Nome = nome;
            Idade = idade;
            Endereco = endereco; //os dados digitados no construtor na variável de endereço será armazenado no atributo endereço e alocados nos atributos de dentro da classe Endereço
        }


        public override string ToString()
        {
            return $"Nome: {Nome}, Idade: {Idade}, Endereço: {Endereco}" ;
        }
    }
}