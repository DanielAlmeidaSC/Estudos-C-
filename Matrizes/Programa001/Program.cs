
using System;

namespace Programa001 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Leia os elementos de uma matriz 3x3 e imprima ela no formato de tabela.");

        int[,] matriz = new int[3,3]; //3 linhas e 3 colunas;

        for (int i = 0; i < matriz.GetLength(0); i++){ //for para linhas
            string[] numeros = Console.ReadLine().Split(" ");

            for (int j = 0; j < matriz.GetLength(1); j++){ //for para colunas
                matriz[i,j] = int.Parse(numeros[j]); // ele preenche cada coluna com o valor digitado no vetor numeros[] e depois passa para a proxima linha
            }
        }


        for (int i = 0; i < matriz.GetLength(0); i++){
            for (int j = 0; j < matriz.GetLength(1); j++){
                Console.Write(matriz[i,j]);
            }
            Console.WriteLine("");
        }
        }
    }
}