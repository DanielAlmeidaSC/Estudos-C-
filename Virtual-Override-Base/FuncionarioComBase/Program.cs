using System;
using FuncionarioComBase.Entities;

namespace FuncionarioComBase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gerente gerente = new Gerente("Daniel");

            Console.WriteLine("Nome: "+gerente.Nome);
        }
    }
}