using System;

namespace Programa006 {
    internal class Program {
        static void Main(string[] args) {
        
        Console.WriteLine("Leia uma matriz 4x4 e mostre qual é o maior e o menor valor armazenado, bem como suas posições.");

        int[,] matriz ={
            {3, 1, 2, 4},
            {5, 6, 7, 8},
            {11, 12, 32, 42},
            {36, 15, 21, 54},
        };


        int maior = matriz[0,0]; //armazena como padrão
        int i = 0;
        int j = 0;



        for (int linha = 0; linha < matriz.GetLength(0); linha++)
        {
            for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
            {
                if(matriz[linha, coluna] > maior){
                    maior = matriz[linha, coluna];
                    i = linha;
                    j = coluna;       

                    }
            }
        }

        Console.WriteLine("Maior = "+maior);
        Console.WriteLine($"Posição: {i} {j} ");



        }
    }
}