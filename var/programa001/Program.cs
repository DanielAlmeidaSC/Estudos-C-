using System;

namespace Programa001 {
    internal class Program {
        static void Main(string[] args) {
            
            //Crie 3 variáveis do tipo inteiro usando `var` e some os valores.


            
            var num1 = 10; //todo tipo var precisa ser inicializado
            var num2 = 20; //ele confere automaticamente o tipo do valor declarado.
            var num3 = 30;

            var soma = num1+num2+num3;

            Console.WriteLine("Resultado: {0}", soma);
        }
    }
}