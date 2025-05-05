using System;
using programa002.Enums;
namespace programa002.Classes
{
    public class EhDiaUtil
    {
        //Escreva um método que imprima se o dia é útil ou final de semana. O método deve usar um switch case para determinar isso.

        public static void EhDia(int numeroDigitado)
        {

            DiaDaSemana dia = (DiaDaSemana)numeroDigitado;
            switch (numeroDigitado)
            {
                case 1: //domingo
                    Console.WriteLine($"É {dia} e não é dia útil!");
                    break;

                case 2:
                case 3: //de segunda a sexta
                case 4:
                case 5:
                case 6:
                    Console.WriteLine($"É {dia} e é dia útil!");
                    break;

                case 7: //sabado
                    Console.WriteLine($"É {dia} e não é dia útil!");
                    break;
                default:
                    Console.WriteLine("Número informado fora dos parâmetros");
                    break;

            }
        }
    }
}