using System;

namespace Programa008 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Ler dois números e imprimir o maior usando ternário.");

            Console.WriteLine("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine()??"0");

            Console.WriteLine("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine()??"0");


            string resultado = (num1 > num2)?$"{num1} é maior":
                               (num2 > num1)?$"{num2} é maior":"são iguais";


            Console.WriteLine(resultado);
        }
    }
}
