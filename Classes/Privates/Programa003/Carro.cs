using System;

namespace Programa003 {
   class Carro{

    /*Classe Carro com atributos privados marca, modelo, ano. Criar properties que só permitem ano >= 1886 (primeiro carro da história).*/

    private string _marca = " ";
    private string _modelo = " ";
    private int _ano;

    public string AlterarMarca
    {
        set { _marca = value; }
        get { return _marca; }
    }

    public string AlterarModelo
    {
        set { _modelo = value; }
        get { return _modelo; }
    }

    public int AlterarAno
    {
        set { if(value >= 1886){
            _ano = value;
        }else{
            Console.WriteLine("Erro! Nessa data ainda não havia carro!");
        } }
        get { return _ano; }
    }
    
    public Carro(string marca, string modelo, int ano){
        _marca = marca;
        _modelo = modelo;
        _ano = ano;
    }
    public void MostrarDetalhes(){
        Console.WriteLine("********************************");
        Console.WriteLine("Marca: "+AlterarMarca);
        Console.WriteLine("Modelo: "+AlterarModelo);
        Console.WriteLine("Ano: "+AlterarAno);
    }
    
    
    
    }
}