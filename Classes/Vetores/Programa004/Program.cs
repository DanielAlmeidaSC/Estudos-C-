//Peça para o usuário digitar 10 números em um vetor. Encontre e mostre o maior e o menor número digitado.

using System;

namespace Programa004
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numeros = new int[10];



            for (int i = 0; i < numeros.Length; i++){
                Console.WriteLine($"Digite o {i + 1}° número: ");
                numeros[i] = int.Parse(Console.ReadLine() ?? "0");
            }

            //armazena o primeiro valor digitado
            int maior = numeros[0];
            int menor = numeros[0];
 
            for (int i = 0; i < numeros.Length; i++){
 
                if (numeros[i] > maior){
                    maior = numeros[i];
                }
                else if (numeros[i] < menor){
                    menor = numeros[i];
                }
            }

            Console.WriteLine("Maior número: " + maior);
            Console.WriteLine("Menor número: " + menor);
        }
    }
}