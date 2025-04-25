using System;
using System.Collections.Generic;

namespace Programa001 {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Quantos nomes deseja cadastrar: ");
            int quantidade = int.Parse(Console.ReadLine()??"0");

            List<string> nomes = new List<string>();
            
            for (int i = 0; i < quantidade; i++){
                Console.WriteLine($"Digite o {i+1}° nome: ");
                string nome = Console.ReadLine()??"0";

                nomes.Add(nome);
            }

            foreach (string nome in nomes){
                Console.WriteLine(nome);
            }


        }
    }
}