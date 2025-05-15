namespace ProdutoEProdutoImportado.Entities
{
    public class Produto
    {

        public string? Nome { get; protected set; }
        public double Preco { get; protected set; }
        public Produto()
        {
        }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public override string ToString()
        {
            return $"Nome do produto: {Nome}"
                +  $"Preço: {Preco.ToString("C")}";
        }
        
    }
}