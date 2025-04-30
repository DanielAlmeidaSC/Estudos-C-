using System;

namespace Programa007 {
    internal class Program {
        static void Main(string[] args) {
                    //Faça um loop `foreach` usando `var` para percorrer um array.
            int[] numeros = new int[]{1,2,3,4,5,6};

            foreach (var numero in numeros)
            {
                Console.WriteLine(numero);
            }
        }
    }
}