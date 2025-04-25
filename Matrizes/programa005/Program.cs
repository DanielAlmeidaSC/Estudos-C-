using System;

namespace Programa005 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Dada uma matriz quadrada 3x3, calcule a soma da diagonal principal");

            int[,] matriz01 ={
                {1, 2, 3},
                {4, 3, 6},
                {3, 8 ,1}
            };

            int somaPrin = 0;
            

            for (int linha = 0; linha < matriz01.GetLength(0); linha++){
                for (int coluna = 0; coluna < matriz01.GetLength(1); coluna++){
                    if(linha == coluna){
                       somaPrin+= matriz01[linha, coluna]; 
                    }
                }
            }


            Console.WriteLine("resultado = "+somaPrin);
        }
    }
}