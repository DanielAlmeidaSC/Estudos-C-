using System;
using FuncionarioECargos.Classes;
using FuncionarioECargos.Enums;

namespace FuncionarioECargos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Empresa empresa = new Empresa();

            Console.WriteLine("Quantos funcionários você deseja contratar: ");
            int quantidade = int.Parse(Console.ReadLine()??"0");

            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine("Digite o nome do {0}° funcionário: ", i+1);
                string nome = Console.ReadLine()??"0";

                Console.WriteLine("Digite o cargo do {0}° funcionário: ", i+1);
                string cargo = Console.ReadLine()??"0";

                if (cargo != "Presidente" && cargo != "Gerente" && cargo != "Desenvolvedor" && cargo != "Suporte" && cargo != "Estagiário")
                {
                    Console.WriteLine("Digite um valor válido!");
                }

                Enum.TryParse(cargo, true, out Cargos cargoEnum);
            

                empresa.AdicionarFuncionarios(nome, cargoEnum);
            }

            empresa.ImprimirFuncionarios();
            
            Console.WriteLine("Você deseja remover funcionários: ");
            string opcao = Console.ReadLine()??"0";


            opcao = opcao.ToLower();

            if (opcao == "sim")
            {
                Console.WriteLine("Quantos funcionários você deseja remover: ");
                int quantidadeParaRemover = int.Parse(Console.ReadLine()??"0");

                for (int i = 0; i < quantidadeParaRemover; i++)
                {
                    Console.WriteLine("Digite o nome da {0}° pessoa: ", i+1);
                    string nome = Console.ReadLine()??"0";

                    Console.WriteLine("Digite o cargo da {0}° pessoa: ", i+1);
                    string cargo = Console.ReadLine()??"0";
                    
                    if (!Enum.TryParse(cargo, true, out Cargos cargos))
                    {
                        Console.WriteLine("Digite um valor válido!");
                    }

                    empresa.RemoverFuncionario(nome, cargos);

                }

                empresa.ImprimirFuncionarios();
            }
        }
    }
}