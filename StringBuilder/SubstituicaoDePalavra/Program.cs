using System;
using System.Text;

namespace Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dada a frase "Hoje o céu está nublado.", use StringBuilder para substituir a palavra "nublado" por "limpo".

            string texto = "Hoje o céu está nublado.";

            StringBuilder alterar = new StringBuilder(texto);

            alterar.Replace("nublado", "Limpo");

            Console.WriteLine("Texto final: "+alterar.ToString());
        }
    }
}