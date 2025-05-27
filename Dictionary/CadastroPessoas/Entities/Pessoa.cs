using System;
using System.Collections.Generic;

namespace CadastroPessoas.Entities
{
    public class Pessoa
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa(string? nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
        
        public Pessoa(int idade)
        {
            Idade = idade;
        }
                
    }
}