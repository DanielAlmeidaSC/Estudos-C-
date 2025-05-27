using System;
namespace System
{
    public static class Contador
    {
        public static string ContadorPalavras(this string palavraEscrita)
        {
            if (palavraEscrita.Length <= 1)
            {
                throw new FormatException("Erro! Não é possível apenas um caractere!");
            }
            else
            {
                string[] separarPalavras = palavraEscrita.Split(new string[] { " ", ",", "." }, StringSplitOptions.RemoveEmptyEntries /*ignora entradas vazias*/);

                int contador = 0;

                foreach (string palavra in separarPalavras)
                {
                    contador++;
                }

                return $"{contador} palavras!";
            }
        }
    }
}