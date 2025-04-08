using System;
using System.Globalization;

namespace Programa002 {
    internal class Program {
        static void Main(string[] args) {
                //Escreva uma função EhPar que recebe um número inteiro e retorna true se for par e false se for ímpar.

                Console.WriteLine("Digite um número: ");
                double numeroDigitado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Boolean verifica = EhPar(numeroDigitado);

                Console.WriteLine(verifica);

        }

        static Boolean EhPar(double n1){
            Boolean par = false;

            if(n1 % 2 == 0){
                par = true;
            }else{
                par = false;
            }


            return par;
        }
    }
}