using System;

namespace Programa008 {
    internal class Program {
        static void Main(string[] args) {
        
        /*- Crie uma matriz 4x4 e preencha-a com números inteiros aleatórios entre 0 e 10.
          - Implemente uma função que conte quantos zeros existem na matriz.
          - Imprima a quantidade de zeros encontrados.*/


        int[,] matriz001 = {
            {0, 1, 2, 3},
            {4, 0, 5, 6},
            {7, 8, 9, 0},
            {10, 11, 0, 12}
            };


        int contadorDeZero = 0;

        for (int i = 0; i < matriz001.GetLength(0); i++){
            for (int j = 0; j < matriz001.GetLength(1); j++){
                if(matriz001[i, j] == 0){
                    contadorDeZero++;
                }
            }
        }


        Console.WriteLine("Quantidade de zeros: {0}", contadorDeZero);
        }
    }
}