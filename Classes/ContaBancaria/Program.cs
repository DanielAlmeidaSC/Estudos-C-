using System;

namespace ContaBancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("-------------------------------------------------");
            Console.Write("Digite seu nome:");
            string nome = Console.ReadLine()??"0";
            Console.WriteLine("-------------------------------------------------");

            Console.WriteLine("-------------------------------------------------");
            Console.Write("Digite o número da sua conta:");
            int numeroDaConta = int.Parse(Console.ReadLine()??"0");
            Console.WriteLine("-------------------------------------------------");

            ContaBancaria conta001 = new ContaBancaria(nome, numeroDaConta);
            conta001.Saldo = 100000;
            Console.WriteLine("Você deseja sacar ou depositar 1000 reais?");
            string opcao = Console.ReadLine()??"0";

            if (opcao == "depositar")
            {
                conta001.Depositar(1000);
                conta001.SaldoAtual();
                
            }
            else
            {
                conta001.Sacar(1000);
                conta001.SaldoAtual();
            }
            Console.WriteLine("-------------------------------------------------");
            conta001.ImprimirDados();
            Console.WriteLine("-------------------------------------------------");

         }
    }
}