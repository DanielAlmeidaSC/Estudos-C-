using System;
using AnimalESom.Entities;

namespace AnimalESom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Gato();
            // criar uma variável do tipo Animal que armazena um objeto do tipo Gato. Funciona, pq gato é um animal.
            a.FazerSom();


        }
    }
}