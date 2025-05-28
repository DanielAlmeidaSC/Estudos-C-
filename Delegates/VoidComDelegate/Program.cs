using System;

//Crie um delegate que receba uma string e retorne void. Crie um método que imprima essa string no console. Use o delegate para chamar esse método.


namespace VoidComDelegate
{
    class Program
    {
        public delegate void DelegateReceber(string texto);

        public static void Imprimir(string texto)
        {
            Console.WriteLine("Imprimindo: "+texto);
        }
        static void Main(string[] args)
        {

            DelegateReceber delegateReceber = Imprimir;

            delegateReceber("Olá, meu nome é Daniel!");
        }
    }
}