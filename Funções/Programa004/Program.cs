using System;

namespace Programa004 {
    internal class Program {
        static void Main(string[] args) {
            //Faça uma função Potencia que recebe uma base e um expoente e retorna o resultado da exponenciação.

            Console.WriteLine("Digite a base e seu expoente: ");
            string[] numerosDigitados = Console.ReadLine().Split(' ');

            int basePotencia = int.Parse(numerosDigitados[0]);
            int expoente = int.Parse(numerosDigitados[1]);

            int calcular = Potencia(basePotencia, expoente);

            Console.WriteLine("Resultado = {0}", calcular);
        }


        static int Potencia(int basePotencia, int expoente){
            int resultado = (int) Math.Pow(basePotencia, expoente); //precisa de um casting, pois o Math é double


            return resultado;
        }
    }
}