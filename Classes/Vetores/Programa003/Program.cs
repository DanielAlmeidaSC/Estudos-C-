//Leia 10 números inteiros em um vetor. Calcule e exiba a soma de todos os elementos.

using System;

namespace Programa003 {
    internal class Program {
        static void Main(string[] args) {
            int[] numerosInteiros = new int[10];
            int soma = 0;

            for (int i = 0; i < numerosInteiros.Length; i++)
            {
                Console.WriteLine($"Digite o {i+1}° número: ");
                numerosInteiros[i] = int.Parse(Console.ReadLine()??"0"); //cada posição do vetor irá capturar uma leitura de dados. Esse dado ficará armazenado na posição respectiva

                soma += numerosInteiros[i];

            }

            Console.WriteLine($"A soma de todos os elementos é: {soma}");           
        }
    }
}