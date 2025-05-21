using System.Collections.Generic;
using GestaoFuncionarios.Interfaces;

namespace GestaoFuncionarios.Entities
{
    public class Empresa
    {

        private List<IFuncionario> Funcionarios = new List<IFuncionario>();

        public void AdicionarFuncionarios(IFuncionario funcionario)
        {
        
            Funcionarios.Add(funcionario);
        }

        public void ExibirFolhaDePagamento()
        {
            foreach (IFuncionario funcionario in Funcionarios)
            {
                Console.WriteLine("Nome: " + funcionario.Nome);
                funcionario.CalcularSalario();
                Console.WriteLine("=======================================================");
            }
        }

    }
}