using System;
using System.Collections.Generic;

namespace OrdenarInteiros
{
    class Program
    {
        static int Ordenar(int x, int y)
        {
            return x.CompareTo(y); // retorna -1 se x for menor 0 se forem iguais e 1 se x for maior
        }
        static void Main(string[] args)
        {
            List<int> numeros = new List<int> { 100, 55, 60, 40, 565, 3, 50, 10 };

            Comparison<int> comparison = Ordenar;

            numeros.Sort(comparison);

            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

        }
    }
}