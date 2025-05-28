using System;
using System.Collections.Generic;

namespace Pares
{
   class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            IEnumerable<int> pares = numeros.Where(n => n % 2 == 0);

            foreach (int par in pares )
            {
                Console.WriteLine(par);
            }
        }
    }
}