using System;
using System.Globalization;

namespace Programa001 {
    internal class Program {
        static void Main(string[] args) {
        Console.WriteLine("1. Pegar a data atual.");
        Console.WriteLine("2. Pegar o ano atual.");
        Console.WriteLine("3. Pegar o mês atual.");
        Console.WriteLine("4. Pegar o dia atual.");

        DateTime hoje = DateTime.Now;

        Console.WriteLine("Data Atual: "+hoje.ToString("D", new CultureInfo("pt-BR"))); //Data por extenso
        Console.WriteLine("Ano Atual: "+hoje.ToString("yyyy", new CultureInfo("pt-BR"))); //ano
        Console.WriteLine("Mês Atual: "+hoje.ToString("MMMM", new CultureInfo("pt-BR"))); //MM -> em numero MMMM-> extenso
        Console.WriteLine("Dia Atual: "+hoje.ToString("dddd", new CultureInfo("pt-BR"))); //DD -> em numero dddd -> extenso

        
        }
    }
}