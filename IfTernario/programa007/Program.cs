using System;

namespace Programa007 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Verificar se o salário é acima de 2000 ou não.");
            Console.Write("Digite: ");
            double salario = double.Parse(Console.ReadLine()??"0");

            string resultado = (salario > 2000)?"É acima":"Não é acima de R$2.000,00";

            Console.WriteLine(resultado
            );
        }
    }
}