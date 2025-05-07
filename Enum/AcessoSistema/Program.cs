using System;
using Classes;

namespace AcessoSistema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu cargo (1 - Administrador 2 - Gerente 3 - Usuário): ");
            int numeroCargo = int.Parse(Console.ReadLine()??"0");

            TemPermissao.EnterOrNot(numeroCargo); 

        }
    }
}