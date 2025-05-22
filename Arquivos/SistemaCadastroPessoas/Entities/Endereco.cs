using SistemaCadastroPessoas.Interface;

namespace SistemaCadastroPessoas.Entities
{
    public class Endereco : IEndereco
    {
        public string? Cidade { get; set; }
        public string? Estado { get; set; }

        public Endereco(string cidade, string estado)
        {
            Cidade = cidade;
            Estado = estado;
        }


        public override string ToString()
        {
            return $"Cidade: [{Cidade}] | Estado: [{Estado}]";
        }

    }
}