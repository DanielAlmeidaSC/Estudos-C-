using System;

namespace Programa001
{
    class Pessoa
    {
        /*Criar uma classe Pessoa com os atributos privados nome e idade, e properties públicas. Depois, instanciar a classe e imprimir os dados.*/
        private string _nome = " ";
        private int _idade;

        public string Nome
        {
            set { _nome = value; }
            get { return _nome; }
        }

        public int Idade
        {
            get { return _idade; }
            set { _idade = value; }
        }

        public Pessoa(string nome, int idade){
            _nome = nome;
            _idade = idade;
        }
    }
}