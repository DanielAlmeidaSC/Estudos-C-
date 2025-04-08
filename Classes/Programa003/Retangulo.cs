using System;

namespace Programa003 {
   class Retangulo {
    public double Largura;    
    public double Altura;

    public double Area(){
        double calcular = Largura*Altura;

        return calcular;
    }
    public double Perimetro(){
        double calcular = (Largura+Altura)*2;

        return calcular;
    }
    public double Diagonal(){
        double calcular = Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));

        return calcular;
    }

    
    }
}