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

            //EXEMPLO QUE DEVE DAR ERRO
            Funcionario funcionario1 = new Gerente(); //Upcassting. Cria um gerente do tipo funcionario

            try
            {
                Programador programador = (Programador)funcionario1; //NAO VAI FUNCIONAR, PQ FUNCIONARIO1 É DO TIPO GERENTE
                programador.Programar();
            }
            catch (System.Exception)
            {
                Console.WriteLine("Erro: não é possível converter gerente para programador");
                throw;
            }
        }
    }
}