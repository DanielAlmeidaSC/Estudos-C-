using System;

namespace Programa003 {
    internal class Program {
        static void Main(string[] args) {
            Dimensao dimensoes = new Dimensao (10, 5, 2);

            Veiculo veiculo = new Veiculo ("Citroen", "C3", dimensoes);

            veiculo.Exibir();

            Dimensao dimensoes1 = new Dimensao (4, 3, 2.5);
            Veiculo veiculo1 = new Veiculo ("Citroen", "C3", dimensoes1);
            veiculo1.Exibir();

            Dimensao dimensoes2 = new Dimensao (1.2, 0.8, 0.5);
            Veiculo veiculo2 = new Veiculo ("Citroen", "C3", dimensoes2);
            veiculo2.Exibir();



        }
    }
}