using System;
using GestaoFuncionarios.Entities;

namespace GestaoFuncionarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FuncionarioEfetivo funcionario1 = new FuncionarioEfetivo("Daniel Almeida", 2500.0, 500.0);
            FuncionarioEfetivo funcionario2 = new FuncionarioEfetivo("Ariele Moellmann", 3200.0, 500.0);

            FuncionarioTerceirizado funcionario3 = new FuncionarioTerceirizado("João", 2300.0, 250.0);
            FuncionarioTerceirizado funcionario4 = new FuncionarioTerceirizado("Amanda", 2600.0, 750.0);

            Empresa empresa = new Empresa();

            empresa.AdicionarFuncionarios(funcionario1);
            empresa.AdicionarFuncionarios(funcionario2);
            empresa.AdicionarFuncionarios(funcionario3);
            empresa.AdicionarFuncionarios(funcionario4);

            empresa.ExibirFolhaDePagamento();
        }
    }
}