using System;
using System.Linq;
using System.Collections.Generic;

namespace ObterMedia
{
   class Program
    {
        static void Main(string[] args)
        {
            List<int> notas = new List<int> { 7, 8, 6, 9, 5 };

            double obterMedia = notas.Average();
           
           Console.WriteLine("Média: "+obterMedia);
        }
    }
}