using System;
using System.Collections.Generic;

namespace ClasseImutavel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<ChaveSeguranca> chaveSegurancas = new HashSet<ChaveSeguranca>();

            chaveSegurancas.Add(new ChaveSeguranca(1, 312321));
            chaveSegurancas.Add(new ChaveSeguranca(1, 3121));
            chaveSegurancas.Add(new ChaveSeguranca(1, 3121)); // Como o método Equals está verificando se o ID e o Nivel são iguais, esse objeto não vai aparecer, será ignorado. Se um dos dois fosse diferente, o objeto apareceria
            chaveSegurancas.Add(new ChaveSeguranca(3, 3213));
            chaveSegurancas.Add(new ChaveSeguranca(4, 5353252));

            foreach (ChaveSeguranca chave in chaveSegurancas)
            {
                Console.WriteLine(chave.ToString());
            }
        }
    }
}