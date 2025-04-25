using System;

namespace Programa004 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Crie uma matriz identidade de ordem 4 (ou seja, 4x4 com 1s na diagonal principal e 0s no restante");

            string[,] matrizIdentidade = new string[4,4];

            for (int i = 0; i < matrizIdentidade.GetLength(0); i++){
                for (int j = 0; j < matrizIdentidade.GetLength(1); j++){

                    if (i == j){
                        matrizIdentidade[i,j] = "1s";
                    }else{
                        matrizIdentidade[i, j] = "0s";
                    }
                }                
            }
            for (int i = 0; i < matrizIdentidade.GetLength(0); i++){
                for (int j = 0; j < matrizIdentidade.GetLength(1); j++){
                    Console.Write(matrizIdentidade[i,j]+" ");
                }

                Console.WriteLine("");
            }
        }
    }
}