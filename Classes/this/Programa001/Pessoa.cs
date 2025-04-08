using System;

namespace Programa001 {
   class Pessoa {

        /*Crie uma classe Pessoa com os atributos Nome e Idade. No construtor, utilize this para diferenciar entre os parâmetros e os atributos da classe.
        Depois, crie um método ExibirInfo que mostre os dados no console.*/

    public string Nome;        
    public int Idade;


    public Pessoa(string nome, int idade){ //Não obrigatório, pois ao declarar o atributo da classe com letra maiúscula, o C# entende direto, mas se quiser não tem problema
        this.Nome = nome;
        this.Idade = idade;
    }

    /*public Pessoa(string nome, int idade){  o C# entende direto, mas se quiser não tem problema
        Nome = nome;
        Idade = idade;
    } */

    public void ExibirInfo(){
        Console.WriteLine("Nome: "+this.Nome);
        Console.WriteLine("Idade: "+this.Idade);
    }




    }
}