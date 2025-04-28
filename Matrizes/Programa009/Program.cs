using System;

namespace Programa009 {
    internal class Program {
        static void Main(string[] args) {

            //- Crie uma matriz 3x3 e preencha-a com números inteiros.
            //- Implemente uma função que multiplique todos os elementos da matriz por um número escalar fornecido pelo usuário.
            //- Imprima a matriz resultante.

            int[,] matriz = {
                {0,1,2},
                {3,4,5},
                {6,7,8}
            };

            int[,] resultado = new int[3,3];
            Console.Write("Digite o número pelo qual você deseja multiplicar os elementos da matriz: ");
            int numero = int.Parse(Console.ReadLine()??"00");

            
            for (int i = 0; i < resultado.GetLength(0); i++){
                for (int j = 0; j < resultado.GetLength(1); j++){
                    resultado[i,j] = matriz[i, j] * numero;

                    Console.Write(resultado[i,j]+" ");
                }
                Console.WriteLine("");
            }
        }
    }
}