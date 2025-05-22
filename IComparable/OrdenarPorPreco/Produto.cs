namespace OrdenarPorPreco 
{
    public class Produto : IComparable
    {
        public double Preco { get; set; }
        public string? Nome { get; set; }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
        public int CompareTo(object? obj)
        {
            if (!(obj is Produto))
            {
                throw new Exception("Erro: o objeto não é um produto!");
            }

            Produto? outro = obj as Produto;

            //ordem crescente, o menor preço vem primeiro
            return Preco.CompareTo(outro.Preco);
        }
    }
}