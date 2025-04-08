using System;

namespace Programa001 {
   class Cotacao {

        public static double Iof = 6.0d;

        public static double ComprarDolares(double quantidade, double cotacao){
            double converter = quantidade * cotacao;
            double totalIof =converter + converter * Iof /100.00;

            return totalIof;
        }

    }
}