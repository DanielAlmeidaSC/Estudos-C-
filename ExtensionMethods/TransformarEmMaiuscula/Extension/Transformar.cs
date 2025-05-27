using System;
namespace System
{
    public static class Transformar
    {
        public static string Capitalize(this string palavra)
        {
            if (palavra.Length <= 1)
            {
                throw new FormatException("Erro! Não é permitido entrada com apenas um caractere");
            }
            else
            {
                return char.ToUpper(palavra[0]) + palavra.Substring(1).ToLower(); //Pega a primeira letra da palavra, converte para char e transforma em maiuscula. Pega a palavra a partir da posição um (uma letra após o inicio) e converte para minuscula
            }
        }
    }
}