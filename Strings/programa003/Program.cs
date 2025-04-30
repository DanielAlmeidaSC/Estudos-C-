using System;

namespace Programa003 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine(" Conte o número de caracteres de uma string.");

            string nome = "DANIEL EXPEDITO";

            int contador= nome.Length;

            Console.WriteLine("Palavra: {0}", nome
            );
            Console.WriteLine("Quantidade de caracteres (contando espaço): {0}", contador);
        }
    }
}