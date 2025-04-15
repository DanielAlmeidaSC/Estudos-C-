using System;

namespace Programa002 {
   public struct Preco {

    public double ValorBase;
    public double Desconto;

    public Preco(double valorBase, double desconto){
        ValorBase = valorBase;
        Desconto = desconto;
    }
    public string ExibirValores(){
        return $"Valor Base = R${ValorBase} / Desconto = {Desconto}%";
    }
    }
}