using System;

namespace Programa006 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Leia uma string e substitua 'a' por 'e'");
        
            string nome = "Amanda";

            string nomeNovo = nome.ToLower();
            string nomeAtualizado = nomeNovo.Replace('a','e');
        
            Console.WriteLine("Nome: {0}", nome);
            Console.WriteLine("Nome Atualizado: {0}", nomeAtualizado);
        }
    }
}