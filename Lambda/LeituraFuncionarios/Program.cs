using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using LeituraFuncionarios.Entities;

namespace LeituraFuncionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            string caminho = @"D:\Estudos C#\Lambda\LeituraFuncionarios\Funcionarios.txt";
            List<Funcionario> funcionarios = new List<Funcionario>();

            using (StreamReader arquivo = File.OpenText(caminho))
            {
                while (!arquivo.EndOfStream)
                {
                    string? linha = arquivo.ReadLine();
                    if (linha != null)
                    {
                        string[] dados = linha.Split(",");
                        string nome = dados[0];
                        string email = dados[1];
                        double salario = double.Parse(dados[2], CultureInfo.InvariantCulture);


                        funcionarios.Add(new Funcionario(nome, email, salario));

                    }
                }
            }
            var ordemAlfabetica = funcionarios.OrderBy(f => f.Email).Where(f => f.Salario > 3000.0);

            foreach (Funcionario funcionario in ordemAlfabetica)
            {
                Console.WriteLine(funcionario);
            }

            Console.WriteLine("=============================================================================");

            double somarSalarios = funcionarios.Sum(f => f.Salario);
            Console.WriteLine("Soma dos salários das pessoas: " + somarSalarios.ToString("C"));

        }
    }
}