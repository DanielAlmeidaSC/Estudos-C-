namespace ProjetoBiblioteca.Classes
{
    public class Livro
    {
        public string? Titulo { get; set; }        
        public string? Autor { get; set; }     

        public Livro(string titulo, string autor)
        {
            Titulo = titulo;
            Autor = autor;
        }   
    }
}