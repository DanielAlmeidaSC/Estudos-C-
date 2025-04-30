using System;

namespace Programa008 {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Verificar o tipo de transporte escolhido (Carro, Avião, Trem).");

            Console.WriteLine("1 - Carro");
            Console.WriteLine("2 - Avião");
            Console.WriteLine("3 - Trem");

            Console.Write("Digite: ");
            int opcao = int.Parse(Console.ReadLine()??"0");

            switch (opcao)
            {
                case 1:
                Console.WriteLine("Você escolheu CARRO!");
                break;
                
                case 2:
                Console.WriteLine("Você escolheu AVIÃO!");
                break;

                case 3:
                Console.WriteLine("Você escolheu TREM!");
                break;


                default:
                Console.WriteLine("Opção inválida!");
                break;
            }
        }
    }
}