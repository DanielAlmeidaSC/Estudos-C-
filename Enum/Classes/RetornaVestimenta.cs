using System;
using Enums;

namespace Classes
{
    public class RetornaVestimenta
    {
        public static void ImprimirRecomendacao(int temperaturaAtual){
            if (temperaturaAtual <= 0 && temperaturaAtual <= 15)
            {
                Temperatura frio = Temperatura.Frio;

                Console.WriteLine("Vista um casaco, está {0}", frio);
            }
            else if(temperaturaAtual > 15 && temperaturaAtual <= 25)
            {
                Temperatura morno = Temperatura.Morno;

                Console.WriteLine("Está {0}, use roupas leves!", morno);
            }
            else if (temperaturaAtual > 25)
            {
                Temperatura calor = Temperatura.Quente;

                Console.WriteLine("Está {0}, vista roupas leves e tome bastante água!", calor);
            }
            else
            {
                Console.WriteLine("Número fora dos parâmetros pré-estabelecidos!");
            }
        }
    }
}