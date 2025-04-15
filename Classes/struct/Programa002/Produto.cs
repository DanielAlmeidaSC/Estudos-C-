using System;
using System.Globalization;

namespace Programa002 {
   class Produto {

    private string _nome = " ";
    private string _categoria = " ";
    public Preco Preco;
    public string Nome {
         set{ _nome = value; } 
         get{ return _nome; }
         }
    
    public string Categoria {
         set{ _categoria = value; } 
         get{ return _categoria; }
         }

    public Produto(string nome, string categoria, Preco preco){
        _nome = nome;
        _categoria = categoria;
        Preco = preco;
    }

    public double CalcularDesconto(){

        double calcular = Preco.ValorBase * (1-(Preco.Desconto/100));

        return calcular;
    }

    public void ExibirDados(){
        Console.WriteLine("Nome do produto = "+_nome);
        Console.WriteLine("Categoria = "+_categoria);
        Console.WriteLine(Preco.ExibirValores());
        Console.WriteLine("Valor final = R$"+CalcularDesconto());
        
    }
    }
}