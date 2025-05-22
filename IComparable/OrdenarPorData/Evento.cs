namespace OrdenarPorData
{
    public class Evento : IComparable
    {
        public string? Nome { get; set; }
        public DateTime? Data { get; set; } = DateTime.Today;

        public Evento(string? nome, DateTime? data)
        {
            Nome = nome;
            Data = data;
        }
        public int CompareTo(object? obj)
        {
            if (!(obj is Evento outraData))
            {
                throw new InvalidOperationException("O tipo obj não é do tipo Evento!");
            }

            // Trata casos onde Data pode ser null
            if (this.Data == null && outraData.Data == null) return 0;
            if (this.Data == null) return -1;
            if (outraData.Data == null) return 1;


            outraData = obj as Evento;

            return this.Data.Value.CompareTo(outraData.Data.Value);
        }
    }
}