//Descrição: Crie uma lista com nomes variados e remova todos que começam com a letra A.


using System;
using System.Collections.Generic;


namespace Programa004 {
    internal class Program {
        static void Main(string[] args) {
            List<string> nomesVariados = new List<string> {"Daniel", "Ariele", "Nerci"};


            List<string> encontrar = nomesVariados.FindAll(n => n.StartsWith('A'));//encontra todos os nomes que começam com A
            
            foreach (string nomeEncontrado in encontrar)
            {
                Console.WriteLine(nomeEncontrado);
            }

            nomesVariados.RemoveAll(n => n.StartsWith('A'));//remove todos os nomes que começam com A

            foreach (string listaAtualizada in nomesVariados)
            {
                Console.WriteLine(listaAtualizada);
            }

        
        }
    }
}