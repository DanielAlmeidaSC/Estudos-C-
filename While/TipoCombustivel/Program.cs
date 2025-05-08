using System;

namespace TipoCombustivel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            


            Console.WriteLine("****BEM-VINDO AO POSTO DELTA****");

            Console.WriteLine("Escreva o tipo de combustível abastecido: ");
            Console.WriteLine(" 1 - Álcool;");
            Console.WriteLine(" 2 - Gasolina;");
            Console.WriteLine(" 3 - Diesel;");
            Console.WriteLine(" 4 - Fim.");

            Console.Write("Digite: ");
            int opcao = int.Parse(Console.ReadLine());
            int contagemAlcool = 0;
            int contagemGasolina = 0;
            int contagemDiesel = 0;


            while (opcao != 4)
            {
                if (opcao == 1)
                {
                    contagemAlcool++;
                }
                else if (opcao == 2)
                {
                    contagemGasolina++;
                }
                else if (opcao == 3)
                {
                    contagemDiesel++;
                }

                Console.Write("Digite: ");
                opcao = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO!");
            Console.WriteLine("Álcool: {0}", contagemAlcool);
            Console.WriteLine("Gasolina: {0}", contagemGasolina);
            Console.WriteLine("Diesel: {0}", contagemDiesel);
        }
    }
}