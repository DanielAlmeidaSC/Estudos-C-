using System;
using System.Globalization;

namespace Programa003 {
    internal class Program {
        static void Main(string[] args) {

            /*Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste
            de 3 valores reais, cada um deles com uma casa decimal. Apresente a média ponderada para cada um destes
            conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem
            peso 5.*/
        
        Console.Write("Digite a quantidade de notas: ");
        int qtdNotas = int.Parse(Console.ReadLine());
        double somaNota = 0.0d;

        for (int i = 0; i < qtdNotas; i++)
        {
            Console.WriteLine("Digite a {0}° nota: ", i+1);
            double nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            somaNota += nota;
        }
        
        double calculaMedia = somaNota / qtdNotas;

        Console.WriteLine("Resultado: "+calculaMedia.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}