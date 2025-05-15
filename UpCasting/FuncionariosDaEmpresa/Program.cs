using System;
using System.Collections.Generic;
using FuncionariosDaEmpresa.Entities;

namespace FuncionariosDaEmpresa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> funcionarios = new List<Funcionario>();
            funcionarios.Add(new Gerente());
            funcionarios.Add(new Programador());

            foreach (var funcionario in funcionarios)
            {
                funcionario.Trabalhar();
            }
        }
    }
}