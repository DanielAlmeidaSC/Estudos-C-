using System;
using System.Collections.Generic;
namespace Programa004 {
    internal class Program {
        static void Main(string[] args) {
            //Crie uma lista de `int` usando `var` e adicione alguns números.

            var lista = new List<int>(); //cria um list. var sabe que é um list por conta do valor declarado

            lista.Add(10);
            lista.Add(10);
            lista.Add(10);

            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]+10);
            }

            
        }
    }
}