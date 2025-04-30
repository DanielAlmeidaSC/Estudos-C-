using System;

namespace Programa008 {
    internal class Program {
        static void Main(string[] args) {

            int Somar(int num1, int num2){
                int resultado = num1+num2;
                return resultado;
            }

            var calcular = Somar(2,3);

            Console.WriteLine(calcular
            );
        }
    }
}