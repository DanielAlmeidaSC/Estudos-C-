using System;

namespace Programa003 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine(". Ler uma opção de menu (1-4) e executar uma ação diferente.");
        
            Console.WriteLine("Digite um número: ");
            int opcao = int.Parse(Console.ReadLine()??"0");

            switch (opcao)
            {
                case 1:
                Console.WriteLine("Cliente cadastrado");   
                break;

                case 2:
                Console.WriteLine("Cliente alterado");
                break;

                case 3:
                Console.WriteLine("Cliente inativado");
                break;

                case 4:
                Console.WriteLine("Cliente excluído");
                break;

                default:
                Console.WriteLine("Opção inválida!");
                break;
            }
        }
    }
}