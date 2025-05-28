using System;

namespace ParametroERetornoDiferentes
{
    class Program
    {
        public delegate int ReceberTexto(string texto); //Recebe uma string e retorna um inteiro (o tamanho)

        public static int TamanhoTexto(string texto)
        {
            return texto.Length;
        }
        static void Main(string[] args)
        {
            ReceberTexto apontar = TamanhoTexto;

            int tamanho = apontar("Daniel Almeida");

            Console.WriteLine("O Texto tem "+tamanho+" caracteres!");
        }
    }
}