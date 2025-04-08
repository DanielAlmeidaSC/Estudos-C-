using System;

namespace Programa006 {
    internal class Program {
        static void Main(string[] args) {

            Cliente cliente1 = new Cliente();

            Console.WriteLine("Digite seu nome :");
            cliente1.Nome = Console.ReadLine()??"0";
            
            Console.WriteLine("Digite sua idade :");
            cliente1.Idade = int.Parse(Console.ReadLine()??"0");
            
            Console.WriteLine("Digite seu E-mail :");
            cliente1.Email = Console.ReadLine()??"0";

            cliente1.ExibirInformacoes();
            


        }
    }
}