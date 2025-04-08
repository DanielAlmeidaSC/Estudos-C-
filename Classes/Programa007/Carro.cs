using System;

namespace Programa007 {
   class Carro {

    public string Marca;
    public string Modelo;
    public int Ano;

    public void ExibirInformações(){
        Console.WriteLine("Carro = "+Marca);
        Console.WriteLine("Modelo = "+Modelo);
        Console.WriteLine("Ano = "+Ano);
    }
    }
}