namespace VerificarProduto
{
    public class Produto
    {

        public int ID { get; set; }
        public string? Nome { get; set; }

        public Produto(int id, string? nome)
        {
            ID = id;
            Nome = nome;
        }
        
        //Somente com equals sendo implementado, ele vai comparar, se vc chamar no principal algo como a.equals(b) ele vai aceitar tranquilo e imprimir false ou true, mas com o GetHashCode, ele imprime a quantidade excluindo duplicatas e continua verificando se são iguais 
        public override bool Equals(object? obj)
        {
            if (obj is not Produto)//verifica se obj é do tipo Produto
            {
                return false;
            }

            Produto? outroID = obj as Produto; // transforma obj em Produto e atribui a ele uma variavel outroID do tipo produto

            return ID.Equals(outroID?.ID);
        }

        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }
        public override string ToString()
        {
            return $"ID: {ID} "
                 + $"Produto: {Nome}";
        }
    }
}