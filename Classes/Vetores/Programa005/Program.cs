//Leia dois vetores de 5 elementos cada e crie um terceiro vetor que seja a junção dos dois primeiros.

using System;

namespace Programa005 {
    internal class Program {
        static void Main(string[] args) {
            int[] vet1 = new int[5];
            int[] vet2 = new int[5];

            Console.WriteLine("************Primeiro vetor**********");
            for (int i = 0; i < vet1.Length; i++){
                Console.WriteLine($"Digite o {i+1}° valor: ");
                vet1[i] = int.Parse(Console.ReadLine()??"0");
            }
            Console.WriteLine("************Segundo vetor**********");
            for (int i = 0; i < vet2.Length; i++){
                Console.WriteLine($"Digite o {i+1}° valor: ");
                vet2[i] = int.Parse(Console.ReadLine()??"0");
            }

            int[] vet3 = new int[10];

            for (int i = 0; i < vet1.Length; i++){
                vet3[i] = vet1[i]; //para cada posição do vetor3, ele vai armazenar o que está dendo do vetor1, criando uma cópia
            }

            for (int i = 0; i < vet2.Length; i++){
                vet3[i+vet1.Length] = vet2[i]; //para cada posição do vetor3, ele vai somar com a quantidade de posições do vetor1, gerando a sexta, setima... posição, para cada posição gerada, ele vai armazenar o que está dentro de cada posição do segundo vetor

                /*i + vet1.Length é equivalente a i + 5, ou seja:

                Quando i = 0 → vet3[6] = vet2[0]

                Quando i = 1 → vet3[7] = vet2[1]

                ...

                Quando i = 4 → vet3[5] = vet2[9]*/
                
            }

            for (int i = 0; i < vet3.Length; i++){
                Console.WriteLine($"Vetor {i}: {vet3[i]}");
            }

        }
    }
}