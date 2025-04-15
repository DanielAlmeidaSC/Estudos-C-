using System;
using Programa001;

namespace Programa001 {
   class Pessoa {

    private string _nome = " ";
    

    private int _idade;

    public Endereco Endereco; //Endereco (como se fosse string) Endereco (nome da variável)

    public string Nome
    {
        get { return _nome; }
        set { _nome = value; }
    }
    public int Idade
    {
        get { return _idade; }
        set { _idade = value; }
    }
        
    public Pessoa(string nome, int idade, Endereco enderecoRecebido){
        _nome = nome;
        _idade = idade;
        Endereco = enderecoRecebido; // vai exibir o que está armazenado na struct Endereco
    }
    public void ExibirDados(){
        Console.WriteLine("Nome: "+_nome);
        Console.WriteLine("Idade: "+_idade);
        Console.WriteLine("Endereco: "+Endereco.ExibirEndereco());
    }
    }
}