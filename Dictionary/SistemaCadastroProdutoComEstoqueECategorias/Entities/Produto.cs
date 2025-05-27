namespace SistemaCadastroProdutoComEstoqueECategorias.Entities
{
    public class Produto
    {
        public string? Nome { get; set; }
        public string? Categoria { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        
        public Produto(string nome, string categoria, double preco, int quantidade)
        {
            Nome = nome;
            Categoria = categoria;
            Preco = preco;
            Quantidade = quantidade;
        }
        public Produto( int quantidade)
        {
            Quantidade = quantidade;
        }
        
    }
}