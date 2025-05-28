using System;
using EstaticosEInstancia.Entities;

namespace EstaticosEInstancia
{
   class Program
    {
        public delegate int DelegateChamar(int x);
        static void Main(string[] args)
        {
            DelegateChamar chamando;

            chamando = Calculos.Quadrado; //o delegate "chamando" está apontando para o método estático Quadrado *repare que não foi instanciado objeto*

            int resultado = chamando(20);

            Console.WriteLine("Resultado: " + resultado);

            Calculos calculos = new Calculos();

            chamando = calculos.Cubo; //o delegate "chamando" está apontando para o método não estático Cubo *Repare que foi instanciado objeto, não é estático*

            resultado = chamando(3);

            Console.WriteLine("Resultado: "+ resultado);
        }
    }
}