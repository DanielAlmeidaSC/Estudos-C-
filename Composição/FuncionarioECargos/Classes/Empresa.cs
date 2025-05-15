using System.Collections.Generic;
using FuncionarioECargos.Enums;


namespace FuncionarioECargos.Classes
{
    public class Empresa
    {
        public List<Funcionario> Funcionario { get; set; } = new List<Funcionario>();

        public void AdicionarFuncionarios(string nome, Cargos cargos)
        {
            Funcionario.Add(new Funcionario { 
                Nome = nome, 
                Cargos = cargos });
            //Adiciona um novo objeto funcionario com parametros nome e cargo
        }

        public void RemoverFuncionario(string nome, Cargos cargos)
        {
            Funcionario.RemoveAll(f => f.Nome == nome && f.Cargos == cargos);
        }

        public void ImprimirFuncionarios(){
            Console.WriteLine("===============================");
            Console.WriteLine("Lista de funcionários: ");
            Console.WriteLine("===============================");
            foreach (var funcionario in Funcionario)
            {   
                Console.WriteLine("===============================");
                Console.WriteLine("Nome: "+funcionario.Nome);
                Console.WriteLine("Cargo: "+funcionario.Cargos);
            }
        }
    }
}