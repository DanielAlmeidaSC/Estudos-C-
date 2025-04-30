using System;

namespace Programa006 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Ler um mês e exibir a estação correspondente.");

            Console.WriteLine("Digite o mês");
            string mes = Console.ReadLine()??"0";

            mes = mes.ToUpper();

            switch (mes) {
                case "JANEIRO":
                case "FEVEREIRO":
                case "MARCO":
                    Console.WriteLine("Estação: Verão");
                    break;
                case "ABRIL":
                case "MAIO":
                case "JUNHO":
                    Console.WriteLine("Estação: Outono");
                    break;
                case "JULHO":
                case "AGOSTO":
                case "SETEMBRO":
                    Console.WriteLine("Estação: Inverno");
                    break;
                case "OUTUBRO":
                case "NOVEMBRO":
                case "DEZEMBRO":  
                    Console.WriteLine("Estação: Primavera");
                    break;
                default:
                    Console.WriteLine("Mês inválido.");
                    break;
            }
        }
    }
}
