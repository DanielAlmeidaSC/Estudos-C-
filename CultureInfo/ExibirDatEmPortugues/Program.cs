using System;
using System.Globalization;

namespace ExibirDatEmPortugues {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("1. Exibir a data atual em cultura portuguesa.");

            //primeiro vamos ver como exibir data normalmente
            

            DateTime hoje = DateTime.Now; //cria uma variável hoje do tipo datetime. Ela vai ter tudo o q precisa de data, como data, horario, dia, mes, ano e etc..

            Console.WriteLine(hoje.ToString()); // vai exibir a data de hj em formato de string
            Console.WriteLine(hoje); // vai exibir a data de hj em formato date


            Console.WriteLine("----------------");

            Console.WriteLine(hoje.ToString("D", new CultureInfo(("pt-BR")))); //vai exibir a data por extenso, ex: sexta-feira, 2 de maio de 2025

            
            


        }
    }
}