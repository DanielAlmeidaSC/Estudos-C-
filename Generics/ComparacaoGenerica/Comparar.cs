
namespace ComparacaoGenerica
{
    public class Comparar<T> : IComparable<Comparar<T>> where T : IComparable<T> //Classe genérica usa o IComparable que vai criar um novo objeto do tipo Classe vai usar as funções do Icomparable
    {
        public T? Valor { get; set; }


        public int CompareTo(Comparar<T>? other)
        {
            if (!(other is Comparar<T> outroValor))
            {
                throw new ArgumentException("O argumento fornecido não é compativel");
            }

            return Valor.CompareTo(outroValor.Valor);
        }
    }
}