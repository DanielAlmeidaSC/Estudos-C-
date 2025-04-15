using System;

namespace Programa007 {
    internal class Program {
        static void Main(string[] args) {

            ContaBancaria conta1 = new ContaBancaria(500.00);
            conta1.Imprimir();
            conta1.Depositar(500.00);
            conta1.Imprimir();
            conta1.Sacar(255);
            conta1.Imprimir();
            conta1.Sacar(745);
            conta1.Imprimir();
            conta1.Sacar(1000);


        }
    }
}