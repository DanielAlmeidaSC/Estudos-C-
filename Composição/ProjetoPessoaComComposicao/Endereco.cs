
namespace ProjetoPessoaComComposicao
{
    public class Endereco
    {

        public string Rua { get; set; } = " ";        
        public string Cidade { get; set; } = " ";        
        public string Estado { get; set; } = " ";        
        public int Cep { get; set; }   

        public Endereco(string rua, string cidade, string estado, int cep){
            Rua = rua;
            Cidade = cidade;
            Estado = estado;
            Cep = cep;
        }

        public override string ToString()
        {
            return $"{Rua}, Cidade: {Cidade}, Estado: {Estado}, CEP: {Cep}";
        }
    }
}