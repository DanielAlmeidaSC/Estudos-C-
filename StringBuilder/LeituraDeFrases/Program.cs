using System;
using System.Text;

namespace LeituraDeFrases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie um programa que leia 5 frases do usuário e as concatene usando um StringBuilder, separando-as com um ponto final. Mostre o resultado final no console.

            string[] palavras = new string[5];

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Digite a {0}° palavra", i + 1);
                palavras[i] = Console.ReadLine() ?? "0";

                sb.Append(palavras[i]);
            }

            Console.WriteLine("Saída: "+ sb.ToString() );
        }
    }
}