namespace PessoaESaudacao.Entities
{
    public class Brasileiro : Pessoa
    {
        public override string Saudar()
        {
            string saudacaoBase = base.Saudar();
            return saudacaoBase+" Saudação Personalizada: Oi, tudo bem?";
        }
    }
}