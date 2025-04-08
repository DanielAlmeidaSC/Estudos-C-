using System;
using System.Globalization;

namespace Programa007 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Você deseja criar um carro: ");
            Console.WriteLine("1 - Sim;");
            Console.WriteLine("2 - Não.");
            Console.Write("Digite: ");
            int opcao = int.Parse(Console.ReadLine()??"0", CultureInfo.InvariantCulture);

            if(opcao == 1){
                Carro carro1 = new Carro();

                Console.WriteLine("Digite a marca do carro: ");
                carro1.Marca = Console.ReadLine()??"0";

                Console.WriteLine("Digite o modelo do carro: ");
                carro1.Modelo = Console.ReadLine()??"0";

                Console.WriteLine("Digite o ano do carro: ");
                carro1.Ano =  int.Parse(Console.ReadLine()??"0");

                carro1.ExibirInformações();
            }else{
                Console.WriteLine("saindo...");
            }
            
        }
    }
}