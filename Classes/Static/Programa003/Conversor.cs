using System;

namespace Programa003
{
    class Conversor
    {
        public static double ConverterParaFahrenheit(double celcius)
        {
            double converter = (celcius * 1.8) + 32;

            return converter;
        }

        public static double ConverterParaCelsius(double fahrenheit){
            double converter =(5.0/9.0) * (fahrenheit-32);

            return converter;
        }
    }
}