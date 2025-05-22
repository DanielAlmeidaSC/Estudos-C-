namespace AnoPublicacao
{
    public class Livro : IComparable
    {
        public string? Titulo { get; set; }
        public DateTime Data { get; set; } = DateTime.Today;

        public int CompareTo(object? obj)
        {
            if (!(obj is Livro outraData))
            {
                throw new ArgumentException("O objeto não é do tipo Livro!");
            }


            return outraData.Data.Year.CompareTo(Data.Year);
        }
    }
}