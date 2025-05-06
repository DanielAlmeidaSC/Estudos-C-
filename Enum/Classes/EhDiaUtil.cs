using System;
using Enums;
namespace Classes
{
    public class EhDiaUtil
    {

        //O número digitado é o respectivo dia no enum. Ex: 1 = Domingo
        public static void Imprimir(int numeroDigitado)
        {
            DiaSemana dia = (DiaSemana)numeroDigitado;

            switch (numeroDigitado)
            {
                case 1:
                    Console.WriteLine("{0} É final de semana!", dia);
                    break;

                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("{0} É dia útil!", dia);
                    break;

                case 7:
                    Console.WriteLine("{0} É final de semana!", dia);
                    break;
                default:
                    Console.WriteLine("Número digitado está fora dos parâmetros");
                    break;
            }
        }
    }
}