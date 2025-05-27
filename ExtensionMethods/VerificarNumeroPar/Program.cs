using System;

namespace VerificarNumeroPar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro: ");
            int numero = int.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine(numero.IsEven()); //numero chama o método de extensão IsEven. Não é necessário passar nada dentro dos parenteses
        }
    }
}