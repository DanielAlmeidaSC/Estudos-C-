using System;

namespace VerificarSenha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite sua senha: ");
            int senha = Console.ReadLine();

            while (senha != "2002")
            {
                Console.WriteLine("Senha inválida!");
                Console.Write("Digite sua senha: ");
                senha = Console.ReadLine();
            }

            Console.WriteLine("Acesso permitido!");
        }
    }
}