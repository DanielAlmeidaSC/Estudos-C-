namespace OrdernarPorTitulo
{
    public class Livros : IComparable<Livros>
    {
        public string? Titulo { get; set; }
        public string? Autor { get; set; }

        public Livros(string? titulo, string? autor)
        {
            Titulo = titulo;
            Autor = autor;
        }
        public int CompareTo(Livros outro)
        {
            if (Titulo == null)
            {
                throw new Exception("Erro!");
            }

            return Titulo.CompareTo(outro.Titulo); //Titulo inserido compara com outro titulo inserido

        }

        public override string ToString()
        {
            return $"{Titulo} - {Autor}";
        }
    }
}