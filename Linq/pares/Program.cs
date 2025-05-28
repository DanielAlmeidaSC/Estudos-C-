using System;
using System.Collections.Generic;
using System.Linq;

namespace Pares
{
   class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var filtrarPar = numeros.Where(n => n % 2 == 0);
            
            foreach (int par in filtrarPar)
            {
                Console.WriteLine(par);
            }

        }
    }
}