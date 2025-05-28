using System;
using System.Collections.Generic;

namespace OrdenarStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nomes = new List<string>
           {
            "Ana Silva",
            "Bruno Costa",
            "Carla Souza",
            "Daniel Rocha",
            "Elisa Lima",
            "Felipe Torres",
            "Giselle Freitas",
            "Hugo Almeida",
            "Isabela Mendes",
            "João Victor",
            "Karina Nunes",
            "Lucas Martins",
            "Marina Oliveira",
            "Mateus Pereira",
            "Natalia Santos"
           };

            var ordenar = nomes.OrderBy(n => n.Length);

            foreach (string ordem in ordenar)
            {
                Console.WriteLine(ordem);
            }
        }
    }
}