using System;
using System.Collections.Generic;

namespace DictionaryFrutas
{
    internal sealed class Program
    {
        private static void Main(string[] args)
        {
            Dictionary<string, double> frutas = new Dictionary<string, double>(); //cria um dictionary com chave string e valor double

            frutas["Maçã"] = 2.25;
            frutas["Banana"] = 3.00;

            frutas["Melancia"] = 6.25;
            frutas["Mamão"] = 9.95;

            frutas["Uva"] = 1.55;
            frutas["Maçã"] = 8.25; //Não vai existir, pois dictionary não tolera keys duplicados, é como se fosse um ID


            foreach (KeyValuePair<string, double> fruta in frutas)
            {
                Console.WriteLine("Fruta: " + fruta.Key + " | Preço: " + fruta.Value.ToString("C"));
            }

            if (frutas.ContainsKey("Banana"))
            {
                Console.WriteLine("Preço da Banana: "+frutas["Banana"].ToString("C")); //acessa o valor da Banana. É como se banana fosse uma variavel de valor 3
            }

        }
    }
}