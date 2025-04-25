using System;

namespace Programa007 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Leia duas matrizes 2x2 e mostre o resultado da multiplicação entre elas.");

            int[,] mat1 = {
                {1, 2},
                {3, 4}
            };
            int[,] mat2 = {
                {5, 6},
                {7, 8}
            };

            int soma1 = 0;
            int soma2 = 0;

            for (int i = 0; i < mat1.GetLength(0); i++){
                for(int j = 0; j < mat1.GetLength(1); j++){
                    soma1 += mat1[i,j];
                }
            }

            for (int i = 0; i < mat2.GetLength(0); i++){
                for(int j = 0; j < mat2.GetLength(1); j++){
                    soma2 += mat2[i,j];
                }
                
            }

            int multiplica = soma1*soma2;


            Console.WriteLine("Resultado = "+multiplica);

            
        }
    }
}