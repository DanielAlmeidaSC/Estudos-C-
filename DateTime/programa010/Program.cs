using System;
using System.Globalization;

namespace Programa010
{
    internal class Program
    {
        static void Main(string[] args)
        {
                /*Próxima sexta-feira:
                Dada uma data qualquer, mostre quando será a próxima sexta-feira.*/
            DateTime hoje = DateTime.Now;

            string diaDeHojeSemana = hoje.ToString("dddd", new CultureInfo("pt-BR"));
            Console.WriteLine(diaDeHojeSemana);

            DateTime proximaSexta = hoje;

            while (proximaSexta.DayOfWeek != DayOfWeek.Friday){
                proximaSexta = proximaSexta.AddDays(1);
            }

            Console.WriteLine("Próxima sexta será dia: {0}",proximaSexta.Day);
            
            
                
        }
    }
}