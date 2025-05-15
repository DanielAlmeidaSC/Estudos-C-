namespace ProdutoEProdutoImportado.Entities
{
    public class ProdutoImportado : Produto
    {
        public double TaxaDeImportacao { get; set; }
        public ProdutoImportado()
        {
        }

        public ProdutoImportado(double taxaDeImportacao, string nome, double preco) : base(nome, preco)
        {
            TaxaDeImportacao = taxaDeImportacao;
        }

        public double ValorFinalImportacao()
        {
            return Preco += Preco * TaxaDeImportacao;
        }
    }
}