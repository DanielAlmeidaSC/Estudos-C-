using System;
using System.Collections.Generic;
using VerificarComIS.Entities;

namespace VerificarComIS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            animals.Add(new Gato());
            animals.Add(new Cachorro());
            animals.Add(new Passaro());

            foreach (Animal animal in animals) //percorra para cada animal do tipo Animal na lista Animals
            {
                if (animal is Gato gato) //animal é um gato do tipo Gato
                {
                    gato.Miar();
                }
                else if (animal is Cachorro cachorro)
                {
                    cachorro.Latir();
                }
                else if (animal is Passaro passaro)
                {
                    passaro.Piar();
                }
            }
        }
    }
}