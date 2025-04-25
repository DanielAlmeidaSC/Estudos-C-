//Descrição: Preencha uma lista com números e gere uma nova contendo apenas os pares.

using System;
using System.Collections.Generic;

namespace Programa003 {
    internal class Program {
        static void Main(string[] args) {
            List<int> lista1 = new List<int>();

            lista1.Add(1);
            lista1.Add(2);
            lista1.Add(3);
            lista1.Add(4);
            lista1.Add(5);
            lista1.Add(6);
            lista1.Add(7);
            lista1.Add(8);
            lista1.Add(9);
            lista1.Add(10);
            lista1.Add(11);

            List<int> pares = lista1.FindAll(par => par % 2 == 0);//onde par é o número da posição, encontrar o qual numero em que a divisão por 2 é igual a 0

            for (int i = 0; i < pares.Count; i++){
                Console.WriteLine(pares[i]);
            }



        }
    }
}