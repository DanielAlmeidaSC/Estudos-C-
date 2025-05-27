using System;
using System.Collections.Generic;

namespace CadastroPessoas.Entities
{
    public class Cadastro
    {
        Dictionary<string, Pessoa> Pessoas = new Dictionary<string, Pessoa>();

        public void AdicionarUsuario(string nome, int idade)
        {
            if (Pessoas.ContainsKey(nome))
            {
                Pessoas[nome] = new Pessoa(idade); // se o objeto existir, ele vai atualizar a idade da chave nome
                Console.WriteLine("Idade atualizada!");
            }
            else
            {
                if (idade < 0)
                {
                    Console.WriteLine("Não existe idade negativa!");
                    return;
                }

                Pessoas.Add(nome, new Pessoa(nome, idade));
                Console.WriteLine("Usuário adicionado com sucesso!");
            }
        }

        public void RemoverUsuario(string nome, int idade)
        {
            if (!Pessoas.ContainsKey(nome))
            {
                Console.WriteLine("O usuário não existe!");
                return;
            }

            Pessoas.Remove(nome); //só permite remover com a chave
        }


        public void ImprimirUsuarios()
        {
            Console.WriteLine("Usuários: ");
            foreach (KeyValuePair<string, Pessoa> pessoa in Pessoas)
            {
                Console.WriteLine("Nome: "+pessoa.Key+ " Idade: "+pessoa.Value.Idade);
            }
        }
    }
}