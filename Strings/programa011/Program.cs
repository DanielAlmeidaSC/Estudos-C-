using System;

namespace Name {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Junte um array de strings em uma única string separada por vírgula.");

            string[] nomeSeparado = new string[]{"Daniel","Expedito", "Ribeiro", "De", "Almeida"};

            string juntar = string.Join(" ", nomeSeparado);

            Console.WriteLine("Resultado: {0}", juntar);  
        }
    }
}