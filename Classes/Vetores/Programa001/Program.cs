using System;

namespace Programa001
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Quantos quartos serão alugados: ");
            int quantidade = int.Parse(Console.ReadLine() ?? "0");

            Estudante[] quartos = new Estudante[10];


            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine($"Aluguel #{i + 1}");
                Console.WriteLine("Nome: ");
                string nome = Console.ReadLine() ?? "0";

                Console.WriteLine("Email: ");
                string email = Console.ReadLine() ?? "0";

                Console.WriteLine("Quarto: ");
                int quarto = int.Parse(Console.ReadLine() ?? "0");

                quartos[quarto] = new Estudante { Nome = nome, Email = email };

            }

            Console.WriteLine("Quartos ocupados: ");
            for (int i = 0; i < quartos.Length; i++)
            {
                if (quartos[i] != null)
                {
                    Console.WriteLine($"{i}: {quartos[i].Nome}, {quartos[i].Email}");
                }
            }

        }
    }
}