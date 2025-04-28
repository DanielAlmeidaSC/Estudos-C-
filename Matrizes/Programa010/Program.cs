using System;
using System.Globalization;

namespace Programa010 {
    internal class Program {
        static void Main(string[] args) {
            // - Crie uma matriz 3x3 e preencha-a com números inteiros.
            // - Implemente uma função que calcule a média dos elementos da matriz.
            // - Imprima a média.

            double[,] matriz = {
               {8.0, 7.0, 6.0},
               {5.0, 4.0, 9.0},
               {10.0, 8.5, 6.0}     
            };


            double media = 0;
            int contador = 0;
            double soma = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    soma+= matriz[i,j];
                    contador++;
                }
            }

            media = soma / contador;

            Console.WriteLine("Resultado: {0}", media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}