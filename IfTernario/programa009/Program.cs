using System;

namespace Programa009 {
    internal class Program {
        static void Main(string[] args) {
        Console.WriteLine("Determinar se o usuário tem permissão de acesso (idade >= 18).");

        Console.Write("Digite sua idade: ");
        int idade = int.Parse(Console.ReadLine()??"0");

        string resultado = (idade >= 18 )?"Acesso permitido":"Acesso negado";

        Console.WriteLine(resultado
        );
        }
    }
}