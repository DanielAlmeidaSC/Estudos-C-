using System;
using System.Globalization;

namespace Programa004 {
    internal class Program {
        static void Main(string[] args) {
        
        Funcionario funcionario1 = new Funcionario(500.00);

        Console.WriteLine("Salário: "+funcionario1.Salario.ToString("F2", CultureInfo.InvariantCulture));

        Console.WriteLine("Você deseja alterar o salário (1 - sim 2 - não): ");
        int opcao = int.Parse(Console.ReadLine()??"0");

        if(opcao == 1){
            Console.WriteLine("Digite o valor: ");
            double aumentoValor = double.Parse(Console.ReadLine()??"0", CultureInfo.InvariantCulture);

            funcionario1.AlterarSalario = aumentoValor;
        }else{
            Console.WriteLine("Fim de programa...");
        }

        Console.WriteLine("Salário: R$"+funcionario1.Salario.ToString("F2", CultureInfo.InvariantCulture));


    
        }
    }
}