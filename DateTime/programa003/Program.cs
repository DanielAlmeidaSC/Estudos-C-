using System;

namespace Programa003 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Verificar se um ano é bissexto usando DateTime.");

            int ano = 2024;

            Boolean isAnoBissexto = DateTime.IsLeapYear(ano);

            string resultado = (isAnoBissexto == true)?"É ano bissexto":"Não é";

            Console.WriteLine(resultado);
        }
    }
}