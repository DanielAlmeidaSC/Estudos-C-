using System;
using System.Globalization;

namespace Programa005 {
   class Produto {

    public string  Nome;
    public double Preco;
    public int Quantidade;

    public void MostrarInformacoes(){
    
        Console.WriteLine("Nome do Produto: "+Nome);
        Console.WriteLine("Preço do Produto: "+Preco.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Quantidade: "+Quantidade);

    }

    public void AdicionarProdutos(int quantidade){
        Quantidade += quantidade;
    }

    }
}