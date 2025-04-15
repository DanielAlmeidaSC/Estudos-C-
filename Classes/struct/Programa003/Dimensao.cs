using System;

namespace Programa003{
   public struct Dimensao {
    public double Comprimento;
    public double Largura;
    public double Altura;

    public Dimensao(double comprimento, double largura, double altura){
        Comprimento = comprimento;
        Largura = largura;
        Altura = altura;
    }
    public string Imprimir(){
        return $"Comprimento = {Comprimento}; Largura = {Largura}; Altura = {Altura}";
    }

    }
}