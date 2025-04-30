using System;

namespace Programa005 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Definir se um ano é bissexto ou não");

            Console.Write("Digite o ano: ");
            int ano = int.Parse(Console.ReadLine()??"0");

            string resultado = (ano % 4 == 0 && ano % 100 != 0)|| (ano % 400 == 0)?"Ano bissexto":"Ano normal";

            Console.WriteLine(resultado); 
        
        }

    }
}