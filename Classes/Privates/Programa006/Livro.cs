//Classe Livro com titulo e paginas. Criar property que verifica se o número de páginas é maior que zero antes de setar.

using System;

namespace Programa006
{
    class Livro
    {
        private string _titulo = " ";
        private int _paginas;

        public string Titulo
        {
            get { return _titulo; }
        }

        public int Paginas
        {
            get { return _paginas; }
        }

        public Livro(string titulo, int quantidadePaginas){
            _titulo = titulo;
            _paginas = quantidadePaginas;
        }

        public void AlterarNumeroDePaginas(int quantidade)
        {
            if (quantidade > 0)
            {
                _paginas = quantidade;
            }
            else
            {
                Console.WriteLine("Valor não permitido!");
            }
        }


    }
}