using System;

namespace Programa008 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Peça uma data e diga se ela cai num final de semana (sábado ou domingo).");
            
            Console.WriteLine("Digite uma data no formato dd/mm/aaaa: ");
            string anoDigitado = Console.ReadLine()??"0";

            DateTime anoDigitadoFormatado = DateTime.Parse(anoDigitado); //converte a string para datetime

            anoDigitadoFormatado.ToString("dd/MM/yyyy");

            Console.WriteLine(anoDigitadoFormatado.ToString("D"));

            DayOfWeek diaDaSemana = anoDigitadoFormatado.DayOfWeek;

            if (diaDaSemana == DayOfWeek.Sunday || diaDaSemana == DayOfWeek.Saturday)
            {
                Console.WriteLine("É Final de semana!");
            }else{
                Console.WriteLine("É dia de semana!");
            }
                
            }
        }
    }

