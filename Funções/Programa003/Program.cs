using System;

namespace Programa003 {
    internal class Program {
        static void Main(string[] args) {
            //Implemente uma função Saudacao que recebe um nome e retorna uma mensagem no formato "Olá, [nome]!".

            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();

            string imprimeSaudacao = Saudacao(nome);
        }

        static string Saudacao(string nome){
            string saudacao = $"Olá {nome}";

            Console.WriteLine(saudacao);
            return saudacao;
        }
    }
}