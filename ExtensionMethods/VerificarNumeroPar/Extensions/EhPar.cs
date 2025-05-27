using System;
namespace System
{
    public static class EhPar //precisa ser classe estática
    {

        public static string IsEven(this int numeroDigitado)
        {
            if (numeroDigitado % 2 == 0)
            {
                return $"{numeroDigitado} é par!";
            }
            else
            {
                return $"{numeroDigitado} é ímpar!";
            }
        }
    }
}