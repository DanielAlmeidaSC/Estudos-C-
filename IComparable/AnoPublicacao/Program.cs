using System;
using System.Collections.Generic;

namespace AnoPublicacao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Livro> livros = new List<Livro>
            {
                new Livro { Titulo = "O Segredo do Tempo", Data = new DateTime(2015, 3, 12) },
                new Livro { Titulo = "As Sombras da Verdade", Data = new DateTime(2018, 10, 5) },
                new Livro { Titulo = "A Jornada de Elandor", Data = new DateTime(2021, 6, 22) },
                new Livro { Titulo = "Fragmentos do Amanhã", Data = new DateTime(2010, 1, 15) },
                new Livro { Titulo = "O Último Oráculo", Data = new DateTime(2020, 12, 1) },
                new Livro { Titulo = "Luz e Trevas", Data = new DateTime(2005, 7, 30) },
                new Livro { Titulo = "Códigos Perdidos", Data = new DateTime(2018, 10, 5) }, // mesma data de outro
                new Livro { Titulo = "Ventos de Inverno", Data = new DateTime(2023, 2, 8) }
            };


            livros.Sort();

            foreach (Livro livro in livros)
            {
                Console.WriteLine("Nome: " + livro.Titulo);
                Console.WriteLine("Ano de publicação: " + livro.Data.Year);
                Console.WriteLine("=================================");
            }
        }
    }
}