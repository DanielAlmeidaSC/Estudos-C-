using System.Collections.Generic;
using SistemaCadastroPessoas.Entities;
namespace SistemaCadastroPessoas.Interface
{
    public interface ICadastro
    {
        public List<Pessoa> Pessoas { get; set; }

        void AdicionarPessoa(Pessoa pessoa);
        void RemoverPessoa(Pessoa pessoa);
    }
}