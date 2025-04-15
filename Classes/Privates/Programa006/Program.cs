using System;
using System.Globalization;

namespace Programa006 {
    internal class Program {
        static void Main(string[] args) {
            Livro livro1 = new Livro("Senhor dos Anéis", 1000);


            Console.WriteLine("Nome: "+livro1.Titulo);
            Console.WriteLine("Quantidade de páginas: "+livro1.Paginas);

            Console.WriteLine("Quantidade de páginas que o livro realmente tem: ");
            int quantidade = int.Parse(Console.ReadLine()??"0", CultureInfo.InvariantCulture);

            livro1.AlterarNumeroDePaginas(quantidade);

            Console.WriteLine("Quantidade de páginas: "+livro1.Paginas);

        }
    }
}