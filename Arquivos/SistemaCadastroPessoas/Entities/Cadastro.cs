using SistemaCadastroPessoas.Interface;
using System.Collections.Generic;


namespace SistemaCadastroPessoas.Entities
{
    public class Cadastro : ICadastro
    {
        public List<Pessoa> Pessoas { get; set; } = new List<Pessoa>();

        public Cadastro()
        {

        }
        public void AdicionarPessoa(Pessoa pessoa)
        {
            Pessoas.Add(pessoa);
        }

        public void RemoverPessoa(Pessoa pessoa)
        {
            Pessoas.Remove(pessoa);
        }

        public void ImprimirLista()
        {
            foreach (Pessoa pessoa in Pessoas)
            {
               
                Console.WriteLine(pessoa +""+pessoa.Endereco);
            }
        }
    }
}