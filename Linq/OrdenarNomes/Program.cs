using System;
using System.Linq;
using System.Collections.Generic;

namespace OrdenarNomes
{
   class Program
    {
        static void Main(string[] args)
        {
            List<string> nomes = new List<string> { "Ana", "Bruno", "Carlos", "Bea", "Fernanda" };


            var ordenarNomes = nomes.Where(n => n.Length > 5);

            foreach (string nome in ordenarNomes)
            {
                Console.WriteLine(nome);
            }
        }
    }
}