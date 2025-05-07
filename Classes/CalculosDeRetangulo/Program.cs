using System;

namespace CalculosDeRetangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo (5, 3);

            retangulo.CalcularPerimetro(5, 3);
            retangulo.CalcularArea(5, 3);
        }
    }
}