using System;

namespace Programa009 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Criar um programa que lê uma tecla e responde diferente para cada tecla (W, A, S, D).");

            Console.Write("Digite:");
            char movimento = char.Parse(Console.ReadLine()??"0");

            movimento = char.ToUpper(movimento);
            switch (movimento)
            {
                    case 'A':
                    Console.WriteLine("Você se moveu para: Esquerda ");
                    break;
                    case 'D':
                    Console.WriteLine("Você se moveu para: Direita ");
                    break;
                    case 'W':
                    Console.WriteLine("Você se moveu para: Frente ");
                    break;
                    case 'S':
                    Console.WriteLine("Você se moveu para: Trás ");
                    break;
                default:
                Console.WriteLine("Opção inválida!");
                break;
            }
        }
    }
}