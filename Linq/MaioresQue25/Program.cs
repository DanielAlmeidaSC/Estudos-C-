using System;
using System.Linq;
using System.Collections.Generic;

namespace MaioresQue25
{
   class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int> { 10, 20, 30, 40, 50 };

            var ordernar = numeros.Where(n => n > 25);

            foreach (int numero in ordernar)
            {
                Console.WriteLine(numero);
            }            
        }
    }
}