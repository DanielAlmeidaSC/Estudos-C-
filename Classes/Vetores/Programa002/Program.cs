//Crie um vetor de 5 inteiros. Peça para o usuário digitar os valores e depois imprima todos eles.

using System;

namespace Programa002 {
    internal class Program {
        static void Main(string[] args) {

            int[] vetor = new int[5]; //vetor de 5 posições começando de 0 a 4

            for( int i = 0; i < vetor.Length; i++){
                Console.WriteLine($"Digite o vetor {i}: ");
                vetor[i] = int.Parse(Console.ReadLine()??"0");
            }


            Console.WriteLine("IMPRIMINDO");

            for (int i = 0; i < vetor.Length; i++)
                Console.WriteLine($"VETOR{i}: {vetor[i]}");
            {
                
            }
        }
    }
}