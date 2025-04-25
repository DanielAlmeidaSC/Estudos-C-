
using System;
using System.Collections.Generic;
using System.Globalization;
namespace Programa005 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Contar quantos elementos tem na lista");

            List<int> lista = new List<int>();

            lista.Add(2);
            lista.Add(2);
            lista.Add(2);
            lista.Add(2);
            lista.Add(2);
            lista.Add(2);
            lista.Add(2);
            lista.Add(2);
            lista.Add(2);
            lista.Add(2);
            lista.Add(2);
            lista.Add(2);
            lista.Add(2);

            Console.WriteLine(lista.Count);

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Verificar se um número específico está na lista");

            List<int> lista2 = new List<int>();

            lista2.Add(1);
            lista2.Add(2);
            lista2.Add(3);
            lista2.Add(4);
            lista2.Add(5);
            lista2.Add(6);
            lista2.Add(7);

            Boolean temNum = lista2.Contains(2);
            Boolean temNum1 = lista2.Contains(8);
            Console.WriteLine(temNum);
            Console.WriteLine(temNum1);

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Remover um item da lista pelo valor");
            lista2.Remove(2);
            lista2.Remove(1);
            lista2.Remove(4);

            foreach (int numero in lista2)
            {
                Console.WriteLine(numero);
            }



            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Ordenar uma lista de inteiros em ordem crescente");
            List<int> lista3 = new List<int>();

            lista3.Add(2);
            lista3.Add(3);
            lista3.Add(5);
            lista3.Add(7);
            lista3.Add(1);
            lista3.Add(8);
            lista3.Add(4);
            lista3.Add(6);
            lista3.Add(9);

            lista3.Sort();

            foreach (int numero in lista3)
            {
                Console.WriteLine(numero);
            }
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Remover todos os elementos pares de uma lista de inteiros");

            List<int> lista4 = new List<int>();

            lista4.Add(1);
            lista4.Add(2);
            lista4.Add(3);
            lista4.Add(4);
            lista4.Add(5);
            lista4.Add(6);
            lista4.Add(7);
            lista4.Add(8);
            lista4.Add(9);
            lista4.Add(10);

            lista4.RemoveAll(n => n % 2 == 0); //remove todos os numeros N em que N é divisivel por 2

            foreach (int numero in lista4){
                Console.WriteLine(numero);
            }

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Criar uma lista de notas e calcular a média");
            List<double> notas = new List<double>();

            notas.Add(7);
            notas.Add(6);
            notas.Add(8.54);
            double soma = 0.0;

            foreach (double nota in notas)
            {
                soma += nota;
            }

            double media = soma / notas.Count();

            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
            
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Juntar duas listas de strings em uma terceira lista.");
            List<string> nomes1 = new List<string>{"Daniel", "Ariele", "Nerci"};
            List<string> nomes2 = new List<string>{"Marcos", "Daniella", "Jéssica"};
            
            
            List<string> nomes3 = new List<string>();

            nomes3.AddRange(nomes1);
            nomes3.AddRange(nomes2);

            foreach (string nome in nomes3)
            {
                Console.WriteLine(nome);
            }

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Encontrar o maior e o menor número em uma lista");
            List<int> lista5 = new List<int>{3, 4, 5, -50, 7, 8, 9, 10};

            int maior = lista5[0];
            int menor = lista5[0];

            foreach (int numero in lista5)
            {
                if(numero < menor){
                    menor = numero;
                }else{
                    maior = numero;
                }
            }

            Console.WriteLine("maior: "+maior); 
            Console.WriteLine("menor: "+menor); 
        }
    }
}