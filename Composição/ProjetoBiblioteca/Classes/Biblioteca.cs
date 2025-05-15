using System.Collections.Generic;

namespace ProjetoBiblioteca.Classes
{
    public class Biblioteca
    {
        public List<Livro> Livros { get; set; } = new List<Livro>(); //cria um tipo list com a classe Livro. Vai ser possivel adicionar, remover e etc.. titulos e autores..

        public void AdicionarLivros(string titulo, string autor){
            Livros.Add(new Livro(titulo, autor)); //Cria uma função de adicionar Livros na propriedade de Lista criada acima. Ao adicionar, é esperado que ele crie um novo livro com autor e titulo, para isso ele vai istanciar um novo objeto. Ex: Quero criar na minha biblioteca o livro "A Teoria de Tudo" do Stephen Hawking. Livros.add(new Livros(A teoria de tudo, Stephen Hawking))
            Console.WriteLine("Livro adicionado!");
        }

        public void RemoverLivros(string titulo, string autor){
            for (int i = 0; i < Livros.Count; i++)
            {
                if(Livros[i].Autor == autor && Livros[i].Titulo == titulo){

                    Livros.RemoveAt(i);
                    Console.WriteLine("Livro Removido!!");
                    break;//remove só o primeiro livro que encontrar com os parametros especificados
                }
                else
                {
                    Console.WriteLine("Livro não encontrado!");
                }
            }

        }

        public void ListarLivros(){
            Console.WriteLine("========================================");
            foreach (var livro in Livros)
            {
                Console.WriteLine("Livro: "+livro.Titulo);
                Console.WriteLine("Autor: "+livro.Autor);
            }
        }
    }
}