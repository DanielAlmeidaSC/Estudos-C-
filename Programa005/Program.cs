using System;
using System.Numerics;

namespace Programa005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ex001 - Digitar três números e mostrar qual é o maior deles*/

            Console.WriteLine("Digite três números");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());


            int resultado = Maior(n1,n2,n3);

            Console.WriteLine("Maior = "+resultado);
        }

        static int Maior(int n1, int n2, int n3)
        {

            int maiorNum;
            if (n1 > n2 && n1 > n3)
            {
                maiorNum = n1;
            }
            else if (n2 > n3)
            {
                maiorNum = n2;
            }
            else
            {
                maiorNum = n3;
            }

            return maiorNum;
        }
    }
}