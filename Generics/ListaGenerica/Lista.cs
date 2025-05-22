using System.Collections;

namespace ListaGenerica
{
    public class Lista<T> : IEnumerable<T>
    {
        private List<T> _itens = new List<T>();

        public void Adicionar(T item)
        {
            _itens.Add(item);
        }

        public void Remover(T item)
        {
            _itens.Remove(item);
        }

        public void ExibirTodos()
        {
            foreach (var item in _itens)
            {
                Console.WriteLine(item);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _itens.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}