using System;

namespace Programa010 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine(" Mostrar 'Ligado' ou 'Desligado' dependendo de uma variável booleana.");

            Boolean interruptor = false;

            string resultado = (interruptor == false)?"Desligado":"Ligado";

            Console.Write(resultado);
        }
    }
}