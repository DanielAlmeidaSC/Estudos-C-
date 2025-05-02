using System;

namespace Programa003 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Converter um booleano para string.");


            Boolean opcao = false;

            string opcaoString = opcao.ToString();

            Console.WriteLine("Resultado: "+opcaoString);

            string novaOpcao = opcaoString.Replace("False", "Falso Demais!"); //só vai funcionar se tiver feito conversão para String

            Console.WriteLine("Resultado com alteração de frase: "+novaOpcao);

        }
    }
}