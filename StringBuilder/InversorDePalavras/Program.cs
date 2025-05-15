using System;
using System.Text;

namespace Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Peça ao usuário para digitar uma palavra. Use StringBuilder para inverter essa palavra e exiba o resultado.

            Console.WriteLine("Digite uma palavra: ");
            string texto = Console.ReadLine()??"0";

            char[] array = texto.ToCharArray();

            Array.Reverse(array);

            StringBuilder fraseInvertida = new StringBuilder(new string(array));

            Console.WriteLine("Frase invertida: "+fraseInvertida.ToString()); 
        }
    }
}