using System;

namespace ArmazenarComVar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Use `var` para armazenar o resultado de uma chamada de função que retorna uma `string`.

            string ObterResultado()
            {
                return "Olá rapeize";
            }
            var mensagem = ObterResultado();
            Console.WriteLine(mensagem);
        }
    }
}