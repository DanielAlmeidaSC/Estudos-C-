using System;
using programa003.Enums;

namespace programa003.Classes
{
    public class DescreveStatus
    {

        public static string DescreverStatus(int numeroDigitado){
            StatusPedido status = (StatusPedido)numeroDigitado;

            if (numeroDigitado == 1)
            {
                return $"A entrega está em {status}";
            }
            else if(numeroDigitado == 2)
            {
                return $"A entrega foi {status}";
            }
            else if(numeroDigitado == 3)
            {
                return $"A entrega está {status}";
            }
            else{
                return "Número digitado fora dos parâmetros estabelecidos";
            }
        }        
    }
}