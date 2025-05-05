using System;
using Enums;

namespace programa001.Classes
{
    public class InformarCor
    {
        //Crie um método que receba uma cor como parâmetro e retorne o nome da cor.

        public static string CorInformada(int numeroDigitado){
            Cores corRequisitada = (Cores)numeroDigitado;

            return $"A cor requisitada é {corRequisitada}";

        }
    }
}