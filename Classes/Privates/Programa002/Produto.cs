//Classe Produto com os atributos nome, preco e quantidade. Criar uma property que retorna o valor total do estoque (preco * quantidade).

using System;
using System.Globalization;

namespace Programa002 {
   class Produto{
    private string _nome = " ";
    private double _preco;
    private int _quantidade;

    public string AlterarNome
    {
        set { _nome = value; }
        get { return _nome; }
    }
    
    public double AlterarPreco
    {
        set { _preco = value; }
        get { return _preco; }
    }

    public int AlterarQuantidade
    {
        set { _quantidade = value; }
        get { return _quantidade; }
    }
    
    
    public double ValorTotalEstoque{
        get{ return AlterarPreco*AlterarQuantidade;}
    }

    public void MostrarValores(){
        Console.WriteLine("Nome = "+AlterarNome);
        Console.WriteLine("Preco = "+AlterarPreco);
        Console.WriteLine("Quantidade = "+AlterarQuantidade);
        Console.WriteLine("Valor total = "+ValorTotalEstoque.ToString("F2", CultureInfo.InvariantCulture));
    }
    }
}