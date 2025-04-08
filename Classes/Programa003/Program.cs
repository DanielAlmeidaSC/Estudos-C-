using System;
using System.Globalization;

namespace Programa003 {
    internal class Program {
        static void Main(string[] args) {
            Retangulo retangulo1 = new Retangulo();
            Console.WriteLine("Entre com a largura e altura do retangulo: ");
            
            Console.WriteLine("Digite a altura: ");
            retangulo1.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite a Largura: ");
            retangulo1.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double retanguloArea = retangulo1.Area();
            double retanguloPerimtro = retangulo1.Perimetro();
            double retanguloDiagonal = retangulo1.Diagonal();



            Console.WriteLine("Area = "+retanguloArea.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perímetro = "+retanguloPerimtro.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal = "+retanguloDiagonal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}