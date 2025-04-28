using System;

namespace Programa011
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Crie uma matriz 5x5 e preencha-a com zeros e uns aleatoriamente.
            // Implemente uma função que conte quantos uns existem na matriz.
            // Imprima a matriz e a quantidade de uns.
            int[,] matriz = {
            {0, 0, 1, 0, 1},
            {1, 0, 0, 0 ,1},
            {0, 0, 0, 0, 0},
            {1, 1, 1, 0, 1},
            {1, 0, 0, 0, 0}
        };

            int contador = 0;
            int contador1 = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i, j] == 0)
                    {
                        contador++;
                    }
                    else if (matriz[i, j] == 1)
                    {
                        contador1++;
                    }

                    Console.Write(matriz[i, j]+" ");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("Quantidade de 1: {0}", contador1);
            Console.WriteLine("Quantidade de 0: {0}", contador);
        }
    }
}