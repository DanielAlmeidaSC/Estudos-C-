using System;

namespace Programa003
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Dada uma matriz 5x5, conte quantos números pares e quantos ímpares existem.");

            int[,] matriz = {
                {1,2,3,4,5},
                {6,7,8,9,10},
                {11,12,13,14,15},
                {16,17,18,19,20},
                {21,22,23,24,25}
            };

            int contadorPar =0, contadorImpar = 0;

            for (int linha = 0; linha < matriz.GetLength(0); linha++){
                for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
                {
                    if(matriz[linha, coluna] % 2 == 0){
                        contadorPar++;
                    }else{
                        contadorImpar++;
                    }
                }
                Console.WriteLine("");    
            }

            Console.WriteLine("Par: "+contadorPar);
            Console.WriteLine("Ímpar: "+contadorImpar);
        }
    }
}