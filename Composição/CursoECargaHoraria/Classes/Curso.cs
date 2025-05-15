namespace CursoECargaHoraria.Classes
{
    public class Curso
    {
        public string Nome { get; set; }
        public int CargaHoraria { get; set; }

        public Curso(string nome, int cargaHoraria)
        {
            Nome = nome;
            CargaHoraria = cargaHoraria;
        }
    }
}