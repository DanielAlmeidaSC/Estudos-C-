﻿using System;

namespace Programa001 {
    internal class Program {
        static void Main(string[] args) {

            //Ler um número de 1 a 7 e imprimir o dia da semana
        
            Console.WriteLine("Digite um dia da semana em números: ");
            int opcao = int.Parse(Console.ReadLine()??"0");

            switch (opcao)
            {
                case 1:
                Console.WriteLine("Domingo");
                break;
                                
                case 2:
                Console.WriteLine("Segunda-Feira");
                break;
                
                case 3:
                Console.WriteLine("Terça-Feira");
                break;
                
                case 4:
                Console.WriteLine("Quarta-Feira");
                break;
                
                case 5:
                Console.WriteLine("Quinta-Feira");
                break;
                
                case 6:
                Console.WriteLine("Sexta-Feira");
                break;
                
                case 7:
                Console.WriteLine("Sábado");
                break;
                

                default:
                Console.WriteLine("Opcao inválida!");
                break;
                
            }
        }
    }
}