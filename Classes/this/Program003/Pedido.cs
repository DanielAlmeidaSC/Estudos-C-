using System;

namespace Program003 {
   class Pedido{
    /*Métodos Fluent com this
    Crie uma classe Pedido com os atributos item e quantidade.
    Implemente dois métodos:
    
    DefinirItem(string item)
    
    DefinirQuantidade(int quantidade)
    
    Ambos devem retornar this, permitindo encadear os métodos.
    Adicione um método Mostrar para exibir os dados.*/

    public string Item = " ";
    public int Quantidade;

    public void DefinirItem(string item){
        Item = item;
    }

    public void DefinirQuantidade(int quantidade){
        Quantidade = quantidade;
    }

    public void Mostrar(){
        Console.WriteLine("Item = "+this.Item);
        Console.WriteLine("Quantidade = "+this.Quantidade);
    }
    }
}