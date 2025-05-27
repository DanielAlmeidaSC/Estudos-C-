using System;
using System.Collections.Generic;

namespace OrdenarNomes
{
    class Program
    {
        static int OrdenarCrescente(string nome1, string nome2)
        {
            return nome1.CompareTo(nome2);
        }

        static int OrdenarDecrescente(string nome1, string nome2)
        {
            return nome2.CompareTo(nome1);
        }
        static void Main(string[] args)
        {
            List<string> nomes = new List<string> { "Carlos", "Fernanda", "Bruno",
                                                    "Ana", "Lucas", "Juliana",
                                                    "Eduardo", "Patrícia", "Rafael",
                                                    "Beatriz" };

            nomes.Sort(OrdenarCrescente); //usando um Delegate (utilizando um método como parâmetro)

            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);
            }

            Console.WriteLine("---------------------------------");
            nomes.Sort(OrdenarDecrescente);

            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);
            }

        }
    }
}