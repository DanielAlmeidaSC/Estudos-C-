using System;

namespace Programa002 {
   class Produto{

            /*2. Encadeando Construtores com this()
        Crie uma classe Produto com dois construtores:

        Um que recebe apenas o nome.

        Outro que recebe nome e preço.

        O construtor que recebe só o nome deve chamar o outro usando this().
        Adicione um método Mostrar para exibir os dados.
        */

    public string Nome = " ";
    public double Preco;
    
    public Produto(){
        // possibilita chamar normalmente o produto, permitindo entrada de dados pelo usuário
    }



    public Produto(string nome):this(nome, 0.0){

    }
    public Produto(string nome, double preco){
        Nome = nome;
        Preco = preco;
    }

    public void Mostrar()
    {
        Console.WriteLine("Nome: " + Nome);
        Console.WriteLine("Preço: R$ " + Preco.ToString("F2"));
    }

  
    }
}