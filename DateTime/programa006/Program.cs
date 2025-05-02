using System;

namespace Programa006 {
    internal class Program {
        static void Main(string[] args) {
        
        Console.WriteLine("12. Verificar se uma data é antes de hoje.");

        Console.WriteLine("13. Verificar se uma data é depois de hoje.");
        
        DateTime hoje = DateTime.Now.Date; //Só vai considerar a data

        DateTime isYesterday = new DateTime(2025, 05, 02);

        string resultadoOntem = (isYesterday < hoje) ? "É antes de hoje" :
                                (isYesterday == hoje) ? "É hoje" :
                                 "É depois de hoje";

        Console.WriteLine(resultadoOntem);
        }
    }
}