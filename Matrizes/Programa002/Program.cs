using System;

namespace Programa002 {
    internal class Program {
        static void Main(string[] args) {
        Console.WriteLine("Leia uma matriz 4x4 e calcule a soma de todos os elementos");

        int[,] matriz = new int[4,4];
        int soma = 0;

        for (int i = 0; i < matriz.GetLength(0); i++){
            string[] numeros = Console.ReadLine().Split(" ");

            for (int j = 0; j < matriz.GetLength(1); j++){
                matriz[i,j] = int.Parse(numeros[j]); //vai armazenar cada numero digitado em cada coluna da matriz

                soma += matriz[i,j]; //pega o valor da linha 0 com a coluna 0 e assim suscessivamente e vai somando        
            }
        
        }

        Console.WriteLine("Resultado = "+soma);
        }


    }
}