using System;
using System.Globalization;

namespace Programa002{
    internal class Program {
        static void Main(string[] args) {
        DateTime hoje = DateTime.Now;

        Console.WriteLine("-----------------------------------------------------------------------------");
        Console.WriteLine("Dia atual: "+hoje.ToString("D", new CultureInfo("pt-BR")));
        Console.WriteLine("-----------------------------------------------------------------------------");
        
        Console.WriteLine("Adicionar 10 dias à data atual");

        DateTime novaData = hoje.AddDays(10);
        Console.WriteLine("Dia modificado: "+novaData.ToString("D", new CultureInfo("pt-BR")));
        Console.WriteLine("-----------------------------------------------------------------------------");
        Console.WriteLine("5. Subtrair 5 dias da data atual.");

        DateTime novaDataSubt = hoje.AddDays(-5);

        Console.WriteLine("Dia modificado: "+novaDataSubt.ToString("D", new CultureInfo("pt-BR")));

        Console.WriteLine("-----------------------------------------------------------------------------");

        Console.WriteLine("Adicionar 3 meses à data atual.");

        DateTime novoMes = hoje.AddMonths(3);

        Console.WriteLine("Mês modificado: "+novoMes.ToString("D", new CultureInfo("pt-BR")));

        Console.WriteLine("-----------------------------------------------------------------------------");
        
        Console.WriteLine("Pegar o primeiro dia do mês.");

        DateTime primeiroDia = new DateTime(hoje.Year, hoje.Month, 1);

        Console.WriteLine("Primeiro dia do mês: "+primeiroDia.ToString("D", new CultureInfo("pt-BR")));

        Console.WriteLine("-----------------------------------------------------------------------------");
        
        Console.WriteLine("Pegar o último dia do mês.");
        
        DateTime ultimoDiaMes = new DateTime(hoje.Year, hoje.Month, 31);
        
        Console.WriteLine("Primeiro dia do mês: "+ultimoDiaMes.ToString("D", new CultureInfo("pt-BR")));
        
        
        
        
        
        
        
        }
    }
}