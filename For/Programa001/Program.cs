using System;

namespace Programa001 {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Digite um valor: ");
            int numeroDigitado = int.Parse(Console.ReadLine());


            for (int i = 0; i <= numeroDigitado; i++)
            {
                if(i % 2 != 0){
                    Console.WriteLine(i);
                }
            }
        }
    }
}