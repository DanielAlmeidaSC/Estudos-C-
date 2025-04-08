using System;
using System.Globalization;
using name;

namespace Programa002 {
    internal class Program {
        static void Main(string[] args) {

            Funcionario funcionario1 = new Funcionario();
            Funcionario funcionario2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.WriteLine("Nome: ");
            funcionario1.nome = Console.ReadLine();
            Console.WriteLine("Salário: ");
            funcionario1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário:");
            Console.WriteLine("Nome: ");
            funcionario2.nome = Console.ReadLine();
            Console.WriteLine("Salário: ");
            funcionario2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            double calculaMedia = (funcionario1.salario + funcionario2.salario)/2;

            Console.WriteLine("Salário médio: "+calculaMedia.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}