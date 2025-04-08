using System;

namespace Programa001 {
    internal class Program {
        static void Main(string[] args) {

            //Crie uma função chamada Somar que recebe dois números inteiros e retorna a soma deles.
            Console.WriteLine("Digite dois números: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());


            int calcular = Somar(n1, n2);

            Console.WriteLine("{0}+{1}={2}", n1, n2, calcular);
        }

        static int Somar(int n1, int n2){
            int resultado = n1+n2;

            return resultado;
        }
    }
}