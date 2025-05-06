using System;
using Enums;


namespace Classes
{
    public class SituacaoProduto
    {
        public static void RetornarStatus(int numeroDigitado){
            StatusPedido status = (StatusPedido)numeroDigitado;

            if (numeroDigitado == 1)
            {
                Console.WriteLine("Seu pedido está em {0}", status);
            }
            else if(numeroDigitado == 2)
            {
                Console.WriteLine("Seu pedido foi {0}", status);
            }
            else if(numeroDigitado == 3)
            {
                Console.WriteLine("Seu pedido foi {0}",status);
            }
        }        
    }
}