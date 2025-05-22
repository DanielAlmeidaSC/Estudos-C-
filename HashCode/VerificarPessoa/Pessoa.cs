using System.Data;

namespace VerificarPessoa
{
    public class Pessoa
    {
        public string? Nome { get; set; }
        public long CPF { get; set; }

        public Pessoa(string nome, long cpf)
        {
            Nome = nome;
            CPF = cpf;
        }
        public override int GetHashCode()
        {
            return CPF.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (!(obj is Pessoa))
            {
                return false;
            }

            Pessoa outroCPF = obj as Pessoa;

            return CPF.Equals(outroCPF.CPF);
        }

        public override string ToString()
        {
            return $"Nome: {Nome} CPF: {CPF}";
        }
        
    }
}