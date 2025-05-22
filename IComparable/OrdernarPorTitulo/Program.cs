using System;
using System.Collections.Generic;

namespace OrdernarPorTitulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Livros> livros = new List<Livros>();

            livros.Add(new Livros("O Senhor dos Anéis", "J.R.R. Tolkien"));
            livros.Add(new Livros("Cem Anos de Solidão", "Gabriel García Márquez"));
            livros.Add(new Livros("Dom Casmurro", "Machado de Assis"));
            livros.Add(new Livros("A Revolução dos Bichos", "George Orwell"));

            livros.Sort();

            foreach (Livros livro in livros)
            {
                Console.WriteLine(""+livro.Titulo);
            }

        }
    }
}