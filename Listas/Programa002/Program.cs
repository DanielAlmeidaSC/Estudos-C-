//Descrição: Crie uma lista de inteiros e exiba a soma total dos números.

using System;
using System.Collections.Generic;

namespace Programa002 {
    internal class Program {
        static void Main(string[] args) {

            List<int> numeros = new List<int>();

            int somar = 0;

            numeros.Add(1);
            numeros.Add(2);
            numeros.Add(3);
            numeros.Add(4);
            numeros.Add(5);
            numeros.Add(6);
            numeros.Add(7);
            numeros.Add(8);
            numeros.Add(9);
            numeros.Add(10);

            foreach (int numero in numeros){
                somar += numero;
                
            }

            Console.WriteLine(somar);

        }
    }
}