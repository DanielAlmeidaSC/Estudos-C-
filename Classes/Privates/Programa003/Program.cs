using System;

namespace Programa003 {
    internal class Program {
        static void Main(string[] args) {

            Carro carro1 = new Carro("Volkswagen", "Polo", 2010);
            Carro carro2 = new Carro("Renault", "Sandero", 2015);
            Carro carro3 = new Carro("Ferrari", "P1", 2025);
            Carro carro4 = new Carro("Belina", "Véia", 0);
            
            carro1.MostrarDetalhes();
            carro2.MostrarDetalhes();
            carro3.MostrarDetalhes();
            carro4.MostrarDetalhes();          

            carro4.AlterarAno = 2020;
            carro4.MostrarDetalhes();  

        }
    }
}