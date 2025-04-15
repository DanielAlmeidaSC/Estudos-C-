using System;
using System.Globalization;

namespace Programa003 {
   class Veiculo {

    private string _modelo = " ";
    private string _marca = " ";
    public Dimensao Dimensoes;

    public string Modelo{
        set{ _modelo = value; }
        get{ return _modelo;} 
    }

    public string Marca{
        set{ _marca = value; }
        get{ return _marca; }
    }

    public Veiculo (string modelo, string marca, Dimensao inserirDimensao){
        _modelo = modelo;
        _marca = marca;
        Dimensoes = inserirDimensao;
    }

    public double CalcularVolume(){
        double calcular = Dimensoes.Comprimento * Dimensoes.Largura * Dimensoes.Altura;

        return calcular;
    }

    public void Exibir(){
        Console.WriteLine("Marca: "+_marca);
        Console.WriteLine("Modelo: "+_modelo);
        Console.WriteLine(Dimensoes.Imprimir());
        Console.WriteLine("\nVolume: "+CalcularVolume().ToString("F2", CultureInfo.InvariantCulture));

    }

    }
}