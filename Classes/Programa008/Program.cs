using System;
using System.Globalization;
using System.Runtime.Intrinsics.Arm;

namespace Programa008 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Você deseja acessar sua conta: ");
            Console.WriteLine(" 1 - Sim");
            Console.WriteLine(" 2 - Não");
            Console.Write("Digite: ");
            int opcao = int.Parse(Console.ReadLine()??"0");

            if(opcao == 1){
                ContaBancaria conta1 = new ContaBancaria();

                Console.WriteLine("Digite o nome do titular: ");
                conta1.Titular = Console.ReadLine()??"0";
                
                Console.WriteLine("Você deseja (1 - Sacar 2 - Depositar): ");
                int newOpcao = int.Parse(Console.ReadLine()??"0");

                if(newOpcao == 1){
                    Console.WriteLine("Qual o valor que deseja sacar: ");
                    double valor = double.Parse(Console.ReadLine()??"0", CultureInfo.InvariantCulture);

                    conta1.Sacar(valor);
                }else{
                    Console.WriteLine("Qual o valor que deseja depositar: ");
                    double valor = double.Parse(Console.ReadLine()??"0", CultureInfo.InvariantCulture);

                    conta1.Depositar(valor);

                
                }

                conta1.ExibirInformacoes();
            }else{
                Console.WriteLine("saindo...");
            }


        }
    }
}