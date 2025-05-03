using System;
using System.Globalization;

namespace Programa007 {
    internal class Program {
        static void Main(string[] args) {
        Console.WriteLine("Peça uma data e imprima o dia da semana em que ela está");
        Console.WriteLine("Digite uma data no formato dd/mm/aaaa: ");
        string data = Console.ReadLine()??"0";
        
        DateTime dataDigitada = DateTime.Parse(data);

        dataDigitada.ToString("dd/MM/yyyy");

        Console.WriteLine(dataDigitada.ToString("D"));

        }
    }
}