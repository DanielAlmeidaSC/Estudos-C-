using System;
using AnimalEmCachorro.Entities;

namespace AnimalEmCachorro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Cachorro(); //upcasting. Cachorro é do tipo animal e vai emitir som genérico
            animal.EmitirSom();

            Cachorro cachorro = (Cachorro)animal; //downcasting. Animal é do tipo cachorro, vai emitir som específico

            cachorro.EmitirSom();
        }
    }
}