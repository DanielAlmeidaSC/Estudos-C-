namespace CaixaGenérica
{
    public class Caixa<T>
    {
        public T? Valor { get; set; }

     

        public void DefinirValor(T valor)
        {
            Valor = valor;
        }

        public T ObterValor()
        {
            if (Valor == null)
            {
                throw new ArgumentNullException("Erro! o valor não pode ser null");
            }

            return Valor;
        }
    }
}