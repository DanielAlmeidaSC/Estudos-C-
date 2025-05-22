using System;

namespace ListaGenerica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista<int> listas = new Lista<int>();

            listas.Adicionar(20);
            listas.Adicionar(15);
            listas.Adicionar(20);
            listas.Remover(20);
            listas.Adicionar(3);

            foreach (int numero in listas) //graças ao IENUMBERABLE
            {
                Console.WriteLine(numero);
            }
        }
    }
}