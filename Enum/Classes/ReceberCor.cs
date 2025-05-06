using System;
using Enums;


namespace Classes
{
    public class ReceberCor
    {
        //recebe um numero que é respectivo para a cor dentro do enum Cores
        public static string RetornarCor(int numeroDigitado){
            Cores corEspecificada = (Cores)numeroDigitado; // transforma um int no tipo enum

            return $"Cor retornada: {corEspecificada}";      

        }
    }
}