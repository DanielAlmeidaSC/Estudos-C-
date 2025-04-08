using System;
using System.Globalization;

namespace Programa004 {
    internal class Program {
        static void Main(string[] args) {

            Funcionario funcionario1 = new Funcionario();

            Console.Write("Nome: ");
            funcionario1.Nome = Console.ReadLine();

            Console.Write("Salário Bruto: ");
            funcionario1.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.Write("Imposto: ");
            funcionario1.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.WriteLine("Funcionário: "+funcionario1);
            
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcentagemAumentar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            funcionario1.AumentarSalario(porcentagemAumentar);

            Console.WriteLine("Dados atualizados: "+funcionario1);


        }
    }
}