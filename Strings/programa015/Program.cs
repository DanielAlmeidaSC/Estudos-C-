using System;

namespace Programa015 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Troque todas as ocorrências de 'C#' por 'Java'.");

            string texto = "O C# é uma linguagem de programação poderosa e versátil. C# é muito utilizada para o desenvolvimento de aplicações no ecossistema .NET, sendo uma das linguagens mais populares entre os desenvolvedores. O C# é uma linguagem orientada a objetos, o que permite criar programas organizados e reutilizáveis. Com C#, é possível criar desde aplicações simples até sistemas complexos e robustos.";
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------");       
            Console.WriteLine("Texto original: {0}", texto);
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------");       

            string novoTexto = texto.Replace("C#", "JAVA"); // troca tudo o que tiver c# por java

            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------");       
            Console.WriteLine("Texto novo: {0}", novoTexto);
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------");       
        }
    }
}